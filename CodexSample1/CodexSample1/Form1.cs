using System.Text;
using System.Text.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace CodexSample1;

public partial class Form1 : Form
{
    private readonly List<TaskItem> _tasks = new();
    private TaskItem? _editingTask;
    private readonly string _storagePath;
    private readonly string[] _defaultCategories = { "개발", "디자인", "운영", "리서치" };

    public Form1()
    {
        InitializeComponent();
        ConfigureUi();

        _storagePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "CodexSample1",
            "tasks.json");

        LoadTasks();
        EnsureSampleData();
        RefreshCategoryOptions();
        RefreshList();
    }

    private void ConfigureUi()
    {
        comboPriority.Items.AddRange(new object[] { "낮음", "보통", "높음" });
        comboPriority.SelectedIndex = 1;

        comboFilter.Items.AddRange(new object[] { "전체", "미완료", "완료", "기한지남" });
        comboFilter.SelectedIndex = 0;

        comboSort.Items.AddRange(new object[]
        {
            "정렬: 생성일 최신",
            "정렬: 마감일 빠른순",
            "정렬: 우선순위 높은순",
            "정렬: 진행률 낮은순"
        });
        comboSort.SelectedIndex = 0;

        comboCategory.DropDownStyle = ComboBoxStyle.DropDown;
        comboCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        comboCategory.AutoCompleteSource = AutoCompleteSource.ListItems;

        textTask.KeyDown += textTask_KeyDown;
        textSearch.TextChanged += (_, __) => RefreshList();
        comboFilter.SelectedIndexChanged += (_, __) => RefreshList();
        comboCategoryFilter.SelectedIndexChanged += (_, __) => RefreshList();
        comboSort.SelectedIndexChanged += (_, __) => RefreshList();

        dateDue.Value = DateTime.Today;
        dateDue.Checked = false;
        numericProgress.Value = 0;

        FormClosing += (_, __) => SaveTasks();

        ConfigureGrid();
        ConfigureChart();
        ConfigureInsightsCharts();
        ConfigureDetailsPanel();
    }

    private void ConfigureGrid()
    {
        gridTasks.AllowUserToAddRows = false;
        gridTasks.AllowUserToDeleteRows = false;
        gridTasks.ReadOnly = true;
        gridTasks.MultiSelect = false;
        gridTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridTasks.RowHeadersVisible = false;
        gridTasks.AutoGenerateColumns = false;
        gridTasks.EnableHeadersVisualStyles = false;
        gridTasks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 32, 45);
        gridTasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        gridTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        gridTasks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 227, 245);
        gridTasks.DefaultCellStyle.SelectionForeColor = Color.Black;
        gridTasks.BackgroundColor = Color.White;
        gridTasks.BorderStyle = BorderStyle.FixedSingle;

        gridTasks.Columns.Clear();
        gridTasks.Columns.Add(CreateTextColumn("Title", "제목", 200));
        gridTasks.Columns.Add(CreateTextColumn("Category", "카테고리", 90));
        gridTasks.Columns.Add(CreateTextColumn("Tags", "태그", 140));
        gridTasks.Columns.Add(CreateTextColumn("Priority", "우선순위", 80));
        gridTasks.Columns.Add(CreateTextColumn("Status", "상태", 80));
        gridTasks.Columns.Add(CreateTextColumn("Progress", "진행률", 70));
        gridTasks.Columns.Add(CreateTextColumn("Due", "마감일", 90));
        gridTasks.Columns.Add(CreateTextColumn("Created", "생성일", 90));

        foreach (DataGridViewColumn column in gridTasks.Columns)
        {
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }

    private static DataGridViewTextBoxColumn CreateTextColumn(string dataProperty, string header, int width)
    {
        return new DataGridViewTextBoxColumn
        {
            DataPropertyName = dataProperty,
            HeaderText = header,
            Width = width,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        };
    }

    private void ConfigureChart()
    {
        chartSummary.ChartAreas.Clear();
        chartSummary.Series.Clear();
        chartSummary.Titles.Clear();

        var area = new ChartArea("Main");
        area.AxisX.MajorGrid.LineColor = Color.FromArgb(230, 232, 238);
        area.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 232, 238);
        area.BackColor = Color.White;
        chartSummary.ChartAreas.Add(area);

        var series = new Series("상태 분포")
        {
            ChartType = SeriesChartType.Column,
            Color = Color.FromArgb(52, 128, 219),
            BorderWidth = 0,
            IsValueShownAsLabel = true
        };

        chartSummary.Series.Add(series);
        chartSummary.Legends.Clear();
        chartSummary.Palette = ChartColorPalette.None;
        chartSummary.PaletteCustomColors = new[]
        {
            Color.FromArgb(52, 128, 219),
            Color.FromArgb(108, 117, 125),
            Color.FromArgb(231, 76, 60)
        };

        chartSummary.Titles.Add(new Title("상태 분포", Docking.Top, new Font("Segoe UI", 10F, FontStyle.Bold), Color.FromArgb(35, 40, 55)));
    }

    private void ConfigureInsightsCharts()
    {
        ConfigureSingleChart(chartCategory, "카테고리 분포");
        ConfigureSingleChart(chartPriority, "우선순위 분포");
    }

    private static void ConfigureSingleChart(Chart chart, string title)
    {
        chart.ChartAreas.Clear();
        chart.Series.Clear();
        chart.Titles.Clear();

        var area = new ChartArea("Main");
        area.AxisX.MajorGrid.LineColor = Color.FromArgb(230, 232, 238);
        area.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 232, 238);
        area.BackColor = Color.White;
        chart.ChartAreas.Add(area);

        var series = new Series("Data")
        {
            ChartType = SeriesChartType.Doughnut,
            BorderWidth = 0,
            IsValueShownAsLabel = true
        };

        chart.Series.Add(series);
        chart.Legends.Clear();
        chart.Palette = ChartColorPalette.BrightPastel;
        chart.Titles.Add(new Title(title, Docking.Top, new Font("Segoe UI", 10F, FontStyle.Bold), Color.FromArgb(35, 40, 55)));
    }

    private void ConfigureDetailsPanel()
    {
        numericDetailProgress.Value = 0;
        textDetailNotes.Clear();
        UpdateDetailPanel(null);
    }
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        AddOrUpdateTask();
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        ToggleEditMode();
    }

    private void buttonToggle_Click(object sender, EventArgs e)
    {
        ToggleSelectedTask();
    }

    private void buttonRemove_Click(object sender, EventArgs e)
    {
        RemoveSelectedTask();
    }

    private void buttonClearDone_Click(object sender, EventArgs e)
    {
        ClearDoneTasks();
    }

    private void buttonMoveUp_Click(object sender, EventArgs e)
    {
        MoveSelectedTask(-1);
    }

    private void buttonMoveDown_Click(object sender, EventArgs e)
    {
        MoveSelectedTask(1);
    }

    private void buttonExport_Click(object sender, EventArgs e)
    {
        ExportCsv();
    }

    private void buttonCompleteAll_Click(object sender, EventArgs e)
    {
        CompleteAllTasks();
    }

    private void buttonResetSample_Click(object sender, EventArgs e)
    {
        ResetSampleData();
    }

    private void buttonSaveDetail_Click(object sender, EventArgs e)
    {
        SaveDetailChanges();
    }

    private void gridTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        ToggleSelectedTask();
    }

    private void gridTasks_SelectionChanged(object sender, EventArgs e)
    {
        UpdateDetailPanel(GetSelectedTask());
    }

    private void textTask_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            AddOrUpdateTask();
        }
    }

    private void AddOrUpdateTask()
    {
        var title = textTask.Text.Trim();
        if (title.Length == 0)
        {
            textTask.Focus();
            return;
        }

        var priority = comboPriority.SelectedItem?.ToString() ?? "보통";
        var dueDate = dateDue.Checked ? dateDue.Value.Date : (DateTime?)null;
        var category = comboCategory.Text.Trim();
        if (category.Length == 0)
        {
            category = "일반";
        }
        var tags = textTags.Text.Trim();
        var progress = (int)numericProgress.Value;

        if (_editingTask is not null)
        {
            _editingTask.Title = title;
            _editingTask.Priority = priority;
            _editingTask.DueDate = dueDate;
            _editingTask.Category = category;
            _editingTask.Tags = tags;
            _editingTask.Progress = progress;
            ExitEditMode();
        }
        else
        {
            _tasks.Add(new TaskItem
            {
                Title = title,
                Priority = priority,
                DueDate = dueDate,
                Category = category,
                Tags = tags,
                Progress = progress,
                IsDone = progress >= 100,
                CreatedAt = DateTime.Now
            });
        }

        ClearInput();
        SaveTasks();
        RefreshCategoryOptions();
        RefreshList();
    }

    private void ToggleEditMode()
    {
        if (_editingTask is not null)
        {
            ExitEditMode();
            return;
        }

        var task = GetSelectedTask();
        if (task is null)
        {
            return;
        }

        _editingTask = task;
        textTask.Text = task.Title;
        comboPriority.SelectedItem = task.Priority;
        comboCategory.Text = task.Category;
        textTags.Text = task.Tags;
        numericProgress.Value = task.Progress;

        if (task.DueDate.HasValue)
        {
            dateDue.Checked = true;
            dateDue.Value = task.DueDate.Value;
        }
        else
        {
            dateDue.Checked = false;
        }

        buttonAdd.Text = "저장";
        buttonEdit.Text = "취소";
        textTask.Focus();
        textTask.SelectAll();
    }

    private void ExitEditMode()
    {
        _editingTask = null;
        buttonAdd.Text = "추가";
        buttonEdit.Text = "수정";
        ClearInput();
    }

    private void ClearInput()
    {
        textTask.Clear();
        textTags.Clear();
        comboPriority.SelectedIndex = 1;
        numericProgress.Value = 0;
        dateDue.Checked = false;
        dateDue.Value = DateTime.Today;
        if (comboCategory.Items.Count > 0)
        {
            comboCategory.SelectedIndex = 0;
        }
        else
        {
            comboCategory.Text = "일반";
        }
        textTask.Focus();
    }

    private void ToggleSelectedTask()
    {
        var task = GetSelectedTask();
        if (task is null)
        {
            return;
        }

        task.IsDone = !task.IsDone;
        if (task.IsDone)
        {
            task.Progress = 100;
        }

        SaveTasks();
        RefreshList(task.Id);
    }

    private void RemoveSelectedTask()
    {
        var task = GetSelectedTask();
        if (task is null)
        {
            return;
        }

        if (_editingTask?.Id == task.Id)
        {
            ExitEditMode();
        }

        _tasks.Remove(task);
        SaveTasks();
        RefreshCategoryOptions();
        RefreshList();
    }

    private void ClearDoneTasks()
    {
        if (_editingTask is not null && _editingTask.IsDone)
        {
            ExitEditMode();
        }

        _tasks.RemoveAll(task => task.IsDone);
        SaveTasks();
        RefreshCategoryOptions();
        RefreshList();
    }

    private void CompleteAllTasks()
    {
        foreach (var task in _tasks)
        {
            task.IsDone = true;
            task.Progress = 100;
        }

        SaveTasks();
        RefreshList();
    }

    private void ResetSampleData()
    {
        _tasks.Clear();
        _tasks.AddRange(BuildSampleData());
        SaveTasks();
        RefreshCategoryOptions();
        RefreshList();
    }

    private void MoveSelectedTask(int direction)
    {
        var task = GetSelectedTask();
        if (task is null)
        {
            return;
        }

        var index = _tasks.FindIndex(item => item.Id == task.Id);
        if (index < 0)
        {
            return;
        }

        var newIndex = index + direction;
        if (newIndex < 0 || newIndex >= _tasks.Count)
        {
            return;
        }

        _tasks.RemoveAt(index);
        _tasks.Insert(newIndex, task);
        SaveTasks();
        RefreshList(task.Id);
    }
    private TaskItem? GetSelectedTask()
    {
        if (gridTasks.CurrentRow?.DataBoundItem is not TaskRow row)
        {
            return null;
        }

        return _tasks.FirstOrDefault(task => task.Id == row.Id);
    }

    private void RefreshList(Guid? preferredSelection = null)
    {
        var selectedId = preferredSelection ?? (gridTasks.CurrentRow?.DataBoundItem as TaskRow)?.Id;

        var search = textSearch.Text.Trim();
        var filter = comboFilter.SelectedItem?.ToString() ?? "전체";
        var categoryFilter = comboCategoryFilter.SelectedItem?.ToString() ?? "전체";

        var rows = new List<TaskRow>();
        foreach (var task in GetSortedTasks())
        {
            if (!MatchesFilter(task, filter, categoryFilter))
            {
                continue;
            }

            if (search.Length > 0 && !MatchesSearch(task, search))
            {
                continue;
            }

            rows.Add(new TaskRow
            {
                Id = task.Id,
                Title = task.Title,
                Category = task.Category,
                Tags = task.Tags,
                Priority = task.Priority,
                Status = BuildStatus(task),
                Progress = $"{task.Progress}%",
                Due = task.DueDate.HasValue ? task.DueDate.Value.ToString("yyyy-MM-dd") : "-",
                Created = task.CreatedAt.ToString("yyyy-MM-dd")
            });
        }

        gridTasks.DataSource = null;
        gridTasks.DataSource = rows;

        if (selectedId.HasValue)
        {
            for (var i = 0; i < rows.Count; i++)
            {
                if (rows[i].Id == selectedId.Value)
                {
                    gridTasks.CurrentCell = gridTasks.Rows[i].Cells[0];
                    break;
                }
            }
        }

        ApplyRowStyles();
        UpdateStats();
        UpdateChart();
        UpdateInsightsCharts();
        UpdateDetailPanel(GetSelectedTask());
    }

    private IEnumerable<TaskItem> GetSortedTasks()
    {
        return comboSort.SelectedIndex switch
        {
            1 => _tasks.OrderBy(task => task.DueDate ?? DateTime.MaxValue),
            2 => _tasks.OrderByDescending(task => PriorityRank(task.Priority)),
            3 => _tasks.OrderBy(task => task.Progress),
            _ => _tasks.OrderByDescending(task => task.CreatedAt)
        };
    }

    private static int PriorityRank(string priority)
    {
        return priority switch
        {
            "높음" => 3,
            "보통" => 2,
            "낮음" => 1,
            _ => 0
        };
    }

    private bool MatchesFilter(TaskItem task, string filter, string categoryFilter)
    {
        var statusMatches = filter switch
        {
            "미완료" => !task.IsDone,
            "완료" => task.IsDone,
            "기한지남" => IsOverdue(task),
            _ => true
        };

        if (!statusMatches)
        {
            return false;
        }

        if (categoryFilter != "전체" && !string.Equals(task.Category, categoryFilter, StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        return true;
    }

    private static bool MatchesSearch(TaskItem task, string search)
    {
        return task.Title.Contains(search, StringComparison.OrdinalIgnoreCase)
            || task.Tags.Contains(search, StringComparison.OrdinalIgnoreCase)
            || task.Notes.Contains(search, StringComparison.OrdinalIgnoreCase)
            || task.Category.Contains(search, StringComparison.OrdinalIgnoreCase);
    }

    private string BuildStatus(TaskItem task)
    {
        if (task.IsDone)
        {
            return "완료";
        }

        if (IsOverdue(task))
        {
            return "기한지남";
        }

        return "진행중";
    }

    private bool IsOverdue(TaskItem task)
    {
        return task.DueDate.HasValue && task.DueDate.Value.Date < DateTime.Today && !task.IsDone;
    }

    private void ApplyRowStyles()
    {
        foreach (DataGridViewRow row in gridTasks.Rows)
        {
            if (row.DataBoundItem is not TaskRow taskRow)
            {
                continue;
            }

            row.DefaultCellStyle.BackColor = taskRow.Status switch
            {
                "완료" => Color.FromArgb(228, 244, 230),
                "기한지남" => Color.FromArgb(251, 230, 230),
                _ => Color.White
            };
        }
    }

    private void UpdateStats()
    {
        var total = _tasks.Count;
        var done = _tasks.Count(task => task.IsDone);
        var overdue = _tasks.Count(IsOverdue);
        var pending = total - done;

        labelStats.Text = $"총 {total}개, 완료 {done}개, 미완료 {pending}개, 기한지남 {overdue}개";
        labelKpiTotalValue.Text = total.ToString();
        labelKpiDoneValue.Text = done.ToString();
        labelKpiPendingValue.Text = pending.ToString();
        labelKpiOverdueValue.Text = overdue.ToString();
    }

    private void UpdateChart()
    {
        var done = _tasks.Count(task => task.IsDone);
        var overdue = _tasks.Count(IsOverdue);
        var pending = _tasks.Count - done - overdue;

        var series = chartSummary.Series[0];
        series.Points.Clear();
        series.Points.AddXY("진행중", pending);
        series.Points.AddXY("완료", done);
        series.Points.AddXY("기한지남", overdue);
    }

    private void UpdateInsightsCharts()
    {
        UpdateCategoryChart();
        UpdatePriorityChart();
    }

    private void UpdateCategoryChart()
    {
        var series = chartCategory.Series[0];
        series.Points.Clear();

        var groups = _tasks
            .GroupBy(task => string.IsNullOrWhiteSpace(task.Category) ? "미분류" : task.Category)
            .OrderByDescending(group => group.Count());

        foreach (var group in groups)
        {
            series.Points.AddXY(group.Key, group.Count());
        }
    }

    private void UpdatePriorityChart()
    {
        var series = chartPriority.Series[0];
        series.Points.Clear();

        var groups = _tasks
            .GroupBy(task => string.IsNullOrWhiteSpace(task.Priority) ? "미지정" : task.Priority)
            .OrderByDescending(group => PriorityRank(group.Key));

        foreach (var group in groups)
        {
            series.Points.AddXY(group.Key, group.Count());
        }
    }
    private void UpdateDetailPanel(TaskItem? task)
    {
        var hasTask = task is not null;
        numericDetailProgress.Enabled = hasTask;
        textDetailNotes.Enabled = hasTask;
        buttonSaveDetail.Enabled = hasTask;

        if (!hasTask)
        {
            labelDetailTitle.Text = "-";
            labelDetailCategory.Text = "-";
            labelDetailTags.Text = "-";
            labelDetailPriority.Text = "-";
            labelDetailDue.Text = "-";
            numericDetailProgress.Value = 0;
            textDetailNotes.Clear();
            return;
        }

        labelDetailTitle.Text = task!.Title;
        labelDetailCategory.Text = task.Category;
        labelDetailTags.Text = string.IsNullOrWhiteSpace(task.Tags) ? "-" : task.Tags;
        labelDetailPriority.Text = task.Priority;
        labelDetailDue.Text = task.DueDate.HasValue ? task.DueDate.Value.ToString("yyyy-MM-dd") : "-";
        numericDetailProgress.Value = task.Progress;
        textDetailNotes.Text = task.Notes;
    }

    private void SaveDetailChanges()
    {
        var task = GetSelectedTask();
        if (task is null)
        {
            return;
        }

        task.Progress = (int)numericDetailProgress.Value;
        task.Notes = textDetailNotes.Text.Trim();
        if (task.Progress >= 100)
        {
            task.IsDone = true;
        }
        else if (task.IsDone && task.Progress < 100)
        {
            task.IsDone = false;
        }

        SaveTasks();
        RefreshList(task.Id);
    }

    private void RefreshCategoryOptions()
    {
        var categories = new SortedSet<string>(_defaultCategories, StringComparer.OrdinalIgnoreCase);
        foreach (var task in _tasks)
        {
            if (!string.IsNullOrWhiteSpace(task.Category))
            {
                categories.Add(task.Category);
            }
        }

        var currentCategory = comboCategory.Text.Trim();
        if (currentCategory.Length > 0)
        {
            categories.Add(currentCategory);
        }
        comboCategory.Items.Clear();
        foreach (var category in categories)
        {
            comboCategory.Items.Add(category);
        }
        if (comboCategory.Items.Count > 0)
        {
            comboCategory.SelectedItem = currentCategory.Length > 0 ? currentCategory : comboCategory.Items[0];
        }

        var currentFilter = comboCategoryFilter.SelectedItem?.ToString();
        comboCategoryFilter.Items.Clear();
        comboCategoryFilter.Items.Add("전체");
        foreach (var category in categories)
        {
            comboCategoryFilter.Items.Add(category);
        }
        comboCategoryFilter.SelectedItem = currentFilter ?? "전체";
    }

    private void ExportCsv()
    {
        using var dialog = new SaveFileDialog
        {
            Filter = "CSV 파일 (*.csv)|*.csv",
            FileName = $"todo_export_{DateTime.Now:yyyyMMdd_HHmm}.csv"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        var sb = new StringBuilder();
        sb.AppendLine("Title,Category,Tags,Priority,Status,Progress,DueDate,CreatedAt,Notes");

        foreach (var task in _tasks)
        {
            var line = string.Join(',',
                EscapeCsv(task.Title),
                EscapeCsv(task.Category),
                EscapeCsv(task.Tags),
                EscapeCsv(task.Priority),
                EscapeCsv(BuildStatus(task)),
                task.Progress.ToString(),
                EscapeCsv(task.DueDate?.ToString("yyyy-MM-dd") ?? string.Empty),
                EscapeCsv(task.CreatedAt.ToString("yyyy-MM-dd")),
                EscapeCsv(task.Notes));
            sb.AppendLine(line);
        }

        File.WriteAllText(dialog.FileName, sb.ToString(), Encoding.UTF8);
    }

    private static string EscapeCsv(string value)
    {
        if (value.Contains('"') || value.Contains(',') || value.Contains('\n'))
        {
            return '"' + value.Replace("\"", "\"\"") + '"';
        }

        return value;
    }

    private void LoadTasks()
    {
        if (!File.Exists(_storagePath))
        {
            return;
        }

        try
        {
            var json = File.ReadAllText(_storagePath);
            var items = JsonSerializer.Deserialize<List<TaskItem>>(json);
            if (items is not null)
            {
                _tasks.Clear();
                _tasks.AddRange(items);
            }
        }
        catch
        {
            _tasks.Clear();
        }
    }

    private void EnsureSampleData()
    {
        if (_tasks.Count > 0)
        {
            return;
        }

        _tasks.AddRange(BuildSampleData());

        SaveTasks();
    }

    private IEnumerable<TaskItem> BuildSampleData()
    {
        return new[]
        {
            new TaskItem
            {
                Title = "주간 회의 자료 준비",
                Priority = "높음",
                Category = "운영",
                Tags = "회의,보고",
                Progress = 40,
                DueDate = DateTime.Today.AddDays(1),
                IsDone = false,
                Notes = "요약본과 상세본을 분리해 작성",
                CreatedAt = DateTime.Today.AddDays(-3)
            },
            new TaskItem
            {
                Title = "UI 스타일 가이드 정리",
                Priority = "보통",
                Category = "디자인",
                Tags = "가이드,브랜드",
                Progress = 60,
                DueDate = DateTime.Today.AddDays(4),
                IsDone = false,
                Notes = "컬러 토큰과 컴포넌트 상태 정의",
                CreatedAt = DateTime.Today.AddDays(-2)
            },
            new TaskItem
            {
                Title = "데이터 정합성 체크",
                Priority = "높음",
                Category = "개발",
                Tags = "데이터,점검",
                Progress = 20,
                DueDate = DateTime.Today.AddDays(-1),
                IsDone = false,
                Notes = "ETL 파이프라인 로그 확인 필요",
                CreatedAt = DateTime.Today.AddDays(-5)
            },
            new TaskItem
            {
                Title = "고객 피드백 정리",
                Priority = "낮음",
                Category = "리서치",
                Tags = "리뷰,정리",
                Progress = 100,
                DueDate = null,
                IsDone = true,
                Notes = "주요 불만 3가지와 개선안 포함",
                CreatedAt = DateTime.Today.AddDays(-6)
            },
            new TaskItem
            {
                Title = "릴리스 노트 초안",
                Priority = "보통",
                Category = "운영",
                Tags = "릴리스,문서",
                Progress = 10,
                DueDate = DateTime.Today.AddDays(7),
                IsDone = false,
                Notes = "업데이트 항목 스크린샷 준비",
                CreatedAt = DateTime.Today.AddDays(-1)
            },
            new TaskItem
            {
                Title = "온보딩 가이드 작성",
                Priority = "보통",
                Category = "리서치",
                Tags = "문서,온보딩",
                Progress = 75,
                DueDate = DateTime.Today.AddDays(2),
                IsDone = false,
                Notes = "신규 사용자 FAQ 포함",
                CreatedAt = DateTime.Today.AddDays(-4)
            },
            new TaskItem
            {
                Title = "대시보드 성능 점검",
                Priority = "높음",
                Category = "개발",
                Tags = "성능,최적화",
                Progress = 30,
                DueDate = DateTime.Today.AddDays(3),
                IsDone = false,
                Notes = "쿼리 캐싱 여부 확인",
                CreatedAt = DateTime.Today.AddDays(-2)
            }
        };
    }

    private void SaveTasks()
    {
        var directory = Path.GetDirectoryName(_storagePath);
        if (string.IsNullOrWhiteSpace(directory))
        {
            return;
        }

        Directory.CreateDirectory(directory);
        var json = JsonSerializer.Serialize(_tasks, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_storagePath, json);
    }

    private sealed class TaskRow
    {
        public Guid Id { get; init; }
        public string Title { get; init; } = string.Empty;
        public string Category { get; init; } = string.Empty;
        public string Tags { get; init; } = string.Empty;
        public string Priority { get; init; } = string.Empty;
        public string Status { get; init; } = string.Empty;
        public string Progress { get; init; } = string.Empty;
        public string Due { get; init; } = string.Empty;
        public string Created { get; init; } = string.Empty;
    }

    private sealed class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = "일반";
        public string Tags { get; set; } = string.Empty;
        public string Priority { get; set; } = "보통";
        public DateTime? DueDate { get; set; }
        public bool IsDone { get; set; }
        public int Progress { get; set; }
        public string Notes { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}

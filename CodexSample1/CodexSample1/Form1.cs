using System.Text.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace CodexSample1;

public partial class Form1 : Form
{
    private const string DonePrefix = "[완료] ";
    private const string OverduePrefix = "[기한지남] ";

    private readonly List<TaskItem> _tasks = new();
    private TaskItem? _editingTask;
    private readonly string _storagePath;

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
        RefreshList();
    }

    private void ConfigureUi()
    {
        comboPriority.Items.AddRange(new object[] { "낮음", "보통", "높음" });
        comboPriority.SelectedIndex = 1;

        comboFilter.Items.AddRange(new object[] { "전체", "미완료", "완료", "기한지남" });
        comboFilter.SelectedIndex = 0;

        textTask.KeyDown += textTask_KeyDown;
        textSearch.TextChanged += (_, __) => RefreshList();
        comboFilter.SelectedIndexChanged += (_, __) => RefreshList();

        dateDue.Value = DateTime.Today;
        dateDue.Checked = false;

        FormClosing += (_, __) => SaveTasks();

        ConfigureGrid();
        ConfigureChart();
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
        gridTasks.Columns.Add(CreateTextColumn("Title", "제목", 220));
        gridTasks.Columns.Add(CreateTextColumn("Priority", "우선순위", 80));
        gridTasks.Columns.Add(CreateTextColumn("Status", "상태", 90));
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

        var area = new ChartArea("Main");
        area.AxisX.MajorGrid.LineColor = Color.FromArgb(230, 232, 238);
        area.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 232, 238);
        area.BackColor = Color.White;
        chartSummary.ChartAreas.Add(area);

        var series = new Series("Tasks")
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

    private void gridTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        ToggleSelectedTask();
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

        if (_editingTask is not null)
        {
            _editingTask.Title = title;
            _editingTask.Priority = priority;
            _editingTask.DueDate = dueDate;
            ExitEditMode();
        }
        else
        {
            _tasks.Add(new TaskItem
            {
                Title = title,
                Priority = priority,
                DueDate = dueDate,
                IsDone = false,
                CreatedAt = DateTime.Now
            });
        }

        ClearInput();
        SaveTasks();
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
        comboPriority.SelectedIndex = 1;
        dateDue.Checked = false;
        dateDue.Value = DateTime.Today;
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

        var rows = new List<TaskRow>();
        foreach (var task in _tasks)
        {
            if (!MatchesFilter(task, filter))
            {
                continue;
            }

            if (search.Length > 0 && task.Title.IndexOf(search, StringComparison.OrdinalIgnoreCase) < 0)
            {
                continue;
            }

            rows.Add(new TaskRow
            {
                Id = task.Id,
                Title = task.Title,
                Priority = task.Priority,
                Status = BuildStatus(task),
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

        UpdateStats();
        UpdateChart();
    }

    private bool MatchesFilter(TaskItem task, string filter)
    {
        return filter switch
        {
            "미완료" => !task.IsDone,
            "완료" => task.IsDone,
            "기한지남" => IsOverdue(task),
            _ => true
        };
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

    private string BuildDisplayText(TaskItem task)
    {
        var prefix = task.IsDone ? DonePrefix : string.Empty;
        if (!task.IsDone && IsOverdue(task))
        {
            prefix += OverduePrefix;
        }

        var meta = $"우선순위: {task.Priority}";
        if (task.DueDate.HasValue)
        {
            meta += $", 마감: {task.DueDate:yyyy-MM-dd}";
        }

        return $"{prefix}{task.Title} ({meta})";
    }

    private bool IsOverdue(TaskItem task)
    {
        return task.DueDate.HasValue && task.DueDate.Value.Date < DateTime.Today && !task.IsDone;
    }

    private void UpdateStats()
    {
        var total = _tasks.Count;
        var done = _tasks.Count(task => task.IsDone);
        var overdue = _tasks.Count(IsOverdue);
        var pending = total - done;

        labelStats.Text = $"총 {total}개, 완료 {done}개, 미완료 {pending}개, 기한지남 {overdue}개";
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

        _tasks.AddRange(new[]
        {
            new TaskItem
            {
                Title = "주간 회의 자료 준비",
                Priority = "높음",
                DueDate = DateTime.Today.AddDays(1),
                IsDone = false,
                CreatedAt = DateTime.Today.AddDays(-3)
            },
            new TaskItem
            {
                Title = "UI 스타일 가이드 정리",
                Priority = "보통",
                DueDate = DateTime.Today.AddDays(4),
                IsDone = false,
                CreatedAt = DateTime.Today.AddDays(-2)
            },
            new TaskItem
            {
                Title = "데이터 정합성 체크",
                Priority = "높음",
                DueDate = DateTime.Today.AddDays(-1),
                IsDone = false,
                CreatedAt = DateTime.Today.AddDays(-5)
            },
            new TaskItem
            {
                Title = "고객 피드백 정리",
                Priority = "낮음",
                DueDate = null,
                IsDone = true,
                CreatedAt = DateTime.Today.AddDays(-6)
            },
            new TaskItem
            {
                Title = "릴리스 노트 초안",
                Priority = "보통",
                DueDate = DateTime.Today.AddDays(7),
                IsDone = false,
                CreatedAt = DateTime.Today.AddDays(-1)
            }
        });

        SaveTasks();
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
        public string Priority { get; init; } = string.Empty;
        public string Status { get; init; } = string.Empty;
        public string Due { get; init; } = string.Empty;
        public string Created { get; init; } = string.Empty;
    }

    private sealed class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Priority { get; set; } = "보통";
        public DateTime? DueDate { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

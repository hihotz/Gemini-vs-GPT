namespace CodexSample1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        tableMain = new TableLayoutPanel();
        panelHeader = new Panel();
        labelTitle = new Label();
        labelSubtitle = new Label();
        tableKpi = new TableLayoutPanel();
        panelKpiTotal = new Panel();
        labelKpiTotalTitle = new Label();
        labelKpiTotalValue = new Label();
        panelKpiDone = new Panel();
        labelKpiDoneTitle = new Label();
        labelKpiDoneValue = new Label();
        panelKpiPending = new Panel();
        labelKpiPendingTitle = new Label();
        labelKpiPendingValue = new Label();
        panelKpiOverdue = new Panel();
        labelKpiOverdueTitle = new Label();
        labelKpiOverdueValue = new Label();
        tableFilter = new TableLayoutPanel();
        textSearch = new TextBox();
        comboFilter = new ComboBox();
        comboCategoryFilter = new ComboBox();
        tableInput = new TableLayoutPanel();
        textTask = new TextBox();
        comboPriority = new ComboBox();
        dateDue = new DateTimePicker();
        buttonAdd = new Button();
        tableMeta = new TableLayoutPanel();
        comboCategory = new ComboBox();
        textTags = new TextBox();
        panelProgress = new Panel();
        labelProgress = new Label();
        numericProgress = new NumericUpDown();
        comboSort = new ComboBox();
        splitMain = new SplitContainer();
        gridTasks = new DataGridView();
        tabRight = new TabControl();
        tabChart = new TabPage();
        chartSummary = new System.Windows.Forms.DataVisualization.Charting.Chart();
        tabInsights = new TabPage();
        tableInsights = new TableLayoutPanel();
        chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
        chartPriority = new System.Windows.Forms.DataVisualization.Charting.Chart();
        tabDetails = new TabPage();
        tableDetails = new TableLayoutPanel();
        labelDetailTitleLabel = new Label();
        labelDetailTitle = new Label();
        labelDetailCategoryLabel = new Label();
        labelDetailCategory = new Label();
        labelDetailTagsLabel = new Label();
        labelDetailTags = new Label();
        labelDetailPriorityLabel = new Label();
        labelDetailPriority = new Label();
        labelDetailDueLabel = new Label();
        labelDetailDue = new Label();
        labelDetailProgressLabel = new Label();
        numericDetailProgress = new NumericUpDown();
        labelDetailNotesLabel = new Label();
        textDetailNotes = new TextBox();
        buttonSaveDetail = new Button();
        tableActions = new TableLayoutPanel();
        buttonEdit = new Button();
        buttonToggle = new Button();
        buttonRemove = new Button();
        buttonClearDone = new Button();
        buttonMoveUp = new Button();
        buttonMoveDown = new Button();
        buttonCompleteAll = new Button();
        buttonResetSample = new Button();
        buttonExport = new Button();
        labelStats = new Label();
        tableMain.SuspendLayout();
        panelHeader.SuspendLayout();
        tableKpi.SuspendLayout();
        panelKpiTotal.SuspendLayout();
        panelKpiDone.SuspendLayout();
        panelKpiPending.SuspendLayout();
        panelKpiOverdue.SuspendLayout();
        tableFilter.SuspendLayout();
        tableInput.SuspendLayout();
        tableMeta.SuspendLayout();
        panelProgress.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericProgress).BeginInit();
        ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
        splitMain.Panel1.SuspendLayout();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridTasks).BeginInit();
        tabRight.SuspendLayout();
        tabChart.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chartSummary).BeginInit();
        tabInsights.SuspendLayout();
        tableInsights.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chartCategory).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chartPriority).BeginInit();
        tabDetails.SuspendLayout();
        tableDetails.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericDetailProgress).BeginInit();
        tableActions.SuspendLayout();
        SuspendLayout();
        // 
        // tableMain
        // 
        tableMain.ColumnCount = 1;
        tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableMain.Controls.Add(panelHeader, 0, 0);
        tableMain.Controls.Add(tableKpi, 0, 1);
        tableMain.Controls.Add(tableFilter, 0, 2);
        tableMain.Controls.Add(tableInput, 0, 3);
        tableMain.Controls.Add(tableMeta, 0, 4);
        tableMain.Controls.Add(splitMain, 0, 5);
        tableMain.Controls.Add(tableActions, 0, 6);
        tableMain.Controls.Add(labelStats, 0, 7);
        tableMain.Dock = DockStyle.Fill;
        tableMain.Location = new Point(12, 12);
        tableMain.Name = "tableMain";
        tableMain.RowCount = 8;
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        tableMain.Size = new Size(1040, 700);
        tableMain.TabIndex = 0;
        // 
        // panelHeader
        // 
        panelHeader.BackColor = Color.FromArgb(28, 32, 45);
        panelHeader.Controls.Add(labelSubtitle);
        panelHeader.Controls.Add(labelTitle);
        panelHeader.Dock = DockStyle.Fill;
        panelHeader.Location = new Point(3, 3);
        panelHeader.Name = "panelHeader";
        panelHeader.Padding = new Padding(16, 10, 16, 10);
        panelHeader.Size = new Size(1034, 58);
        panelHeader.TabIndex = 1;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        labelTitle.ForeColor = Color.White;
        labelTitle.Location = new Point(16, 8);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(171, 25);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Todo Dashboard";
        // 
        // labelSubtitle
        // 
        labelSubtitle.AutoSize = true;
        labelSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        labelSubtitle.ForeColor = Color.FromArgb(200, 205, 220);
        labelSubtitle.Location = new Point(18, 34);
        labelSubtitle.Name = "labelSubtitle";
        labelSubtitle.Size = new Size(296, 15);
        labelSubtitle.TabIndex = 1;
        labelSubtitle.Text = "우선순위, 마감일, 진행상태를 한눈에 관리하세요";
        // 
        // tableKpi
        // 
        tableKpi.ColumnCount = 4;
        tableKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableKpi.Controls.Add(panelKpiTotal, 0, 0);
        tableKpi.Controls.Add(panelKpiDone, 1, 0);
        tableKpi.Controls.Add(panelKpiPending, 2, 0);
        tableKpi.Controls.Add(panelKpiOverdue, 3, 0);
        tableKpi.Dock = DockStyle.Fill;
        tableKpi.Location = new Point(3, 67);
        tableKpi.Name = "tableKpi";
        tableKpi.RowCount = 1;
        tableKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableKpi.Size = new Size(1034, 58);
        tableKpi.TabIndex = 2;
        // 
        // panelKpiTotal
        // 
        panelKpiTotal.BackColor = Color.White;
        panelKpiTotal.Controls.Add(labelKpiTotalValue);
        panelKpiTotal.Controls.Add(labelKpiTotalTitle);
        panelKpiTotal.Dock = DockStyle.Fill;
        panelKpiTotal.Location = new Point(0, 0);
        panelKpiTotal.Margin = new Padding(0, 0, 6, 0);
        panelKpiTotal.Name = "panelKpiTotal";
        panelKpiTotal.Padding = new Padding(12, 6, 12, 6);
        panelKpiTotal.Size = new Size(252, 58);
        panelKpiTotal.TabIndex = 0;
        // 
        // labelKpiTotalTitle
        // 
        labelKpiTotalTitle.AutoSize = true;
        labelKpiTotalTitle.ForeColor = Color.FromArgb(95, 99, 110);
        labelKpiTotalTitle.Location = new Point(12, 6);
        labelKpiTotalTitle.Name = "labelKpiTotalTitle";
        labelKpiTotalTitle.Size = new Size(55, 15);
        labelKpiTotalTitle.TabIndex = 0;
        labelKpiTotalTitle.Text = "전체 작업";
        // 
        // labelKpiTotalValue
        // 
        labelKpiTotalValue.AutoSize = true;
        labelKpiTotalValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        labelKpiTotalValue.Location = new Point(12, 24);
        labelKpiTotalValue.Name = "labelKpiTotalValue";
        labelKpiTotalValue.Size = new Size(26, 30);
        labelKpiTotalValue.TabIndex = 1;
        labelKpiTotalValue.Text = "0";
        // 
        // panelKpiDone
        // 
        panelKpiDone.BackColor = Color.White;
        panelKpiDone.Controls.Add(labelKpiDoneValue);
        panelKpiDone.Controls.Add(labelKpiDoneTitle);
        panelKpiDone.Dock = DockStyle.Fill;
        panelKpiDone.Location = new Point(258, 0);
        panelKpiDone.Margin = new Padding(0, 0, 6, 0);
        panelKpiDone.Name = "panelKpiDone";
        panelKpiDone.Padding = new Padding(12, 6, 12, 6);
        panelKpiDone.Size = new Size(252, 58);
        panelKpiDone.TabIndex = 1;
        // 
        // labelKpiDoneTitle
        // 
        labelKpiDoneTitle.AutoSize = true;
        labelKpiDoneTitle.ForeColor = Color.FromArgb(95, 99, 110);
        labelKpiDoneTitle.Location = new Point(12, 6);
        labelKpiDoneTitle.Name = "labelKpiDoneTitle";
        labelKpiDoneTitle.Size = new Size(43, 15);
        labelKpiDoneTitle.TabIndex = 0;
        labelKpiDoneTitle.Text = "완료됨";
        // 
        // labelKpiDoneValue
        // 
        labelKpiDoneValue.AutoSize = true;
        labelKpiDoneValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        labelKpiDoneValue.Location = new Point(12, 24);
        labelKpiDoneValue.Name = "labelKpiDoneValue";
        labelKpiDoneValue.Size = new Size(26, 30);
        labelKpiDoneValue.TabIndex = 1;
        labelKpiDoneValue.Text = "0";
        // 
        // panelKpiPending
        // 
        panelKpiPending.BackColor = Color.White;
        panelKpiPending.Controls.Add(labelKpiPendingValue);
        panelKpiPending.Controls.Add(labelKpiPendingTitle);
        panelKpiPending.Dock = DockStyle.Fill;
        panelKpiPending.Location = new Point(516, 0);
        panelKpiPending.Margin = new Padding(0, 0, 6, 0);
        panelKpiPending.Name = "panelKpiPending";
        panelKpiPending.Padding = new Padding(12, 6, 12, 6);
        panelKpiPending.Size = new Size(252, 58);
        panelKpiPending.TabIndex = 2;
        // 
        // labelKpiPendingTitle
        // 
        labelKpiPendingTitle.AutoSize = true;
        labelKpiPendingTitle.ForeColor = Color.FromArgb(95, 99, 110);
        labelKpiPendingTitle.Location = new Point(12, 6);
        labelKpiPendingTitle.Name = "labelKpiPendingTitle";
        labelKpiPendingTitle.Size = new Size(43, 15);
        labelKpiPendingTitle.TabIndex = 0;
        labelKpiPendingTitle.Text = "진행중";
        // 
        // labelKpiPendingValue
        // 
        labelKpiPendingValue.AutoSize = true;
        labelKpiPendingValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        labelKpiPendingValue.Location = new Point(12, 24);
        labelKpiPendingValue.Name = "labelKpiPendingValue";
        labelKpiPendingValue.Size = new Size(26, 30);
        labelKpiPendingValue.TabIndex = 1;
        labelKpiPendingValue.Text = "0";
        // 
        // panelKpiOverdue
        // 
        panelKpiOverdue.BackColor = Color.White;
        panelKpiOverdue.Controls.Add(labelKpiOverdueValue);
        panelKpiOverdue.Controls.Add(labelKpiOverdueTitle);
        panelKpiOverdue.Dock = DockStyle.Fill;
        panelKpiOverdue.Location = new Point(774, 0);
        panelKpiOverdue.Margin = new Padding(0);
        panelKpiOverdue.Name = "panelKpiOverdue";
        panelKpiOverdue.Padding = new Padding(12, 6, 12, 6);
        panelKpiOverdue.Size = new Size(260, 58);
        panelKpiOverdue.TabIndex = 3;
        // 
        // labelKpiOverdueTitle
        // 
        labelKpiOverdueTitle.AutoSize = true;
        labelKpiOverdueTitle.ForeColor = Color.FromArgb(95, 99, 110);
        labelKpiOverdueTitle.Location = new Point(12, 6);
        labelKpiOverdueTitle.Name = "labelKpiOverdueTitle";
        labelKpiOverdueTitle.Size = new Size(55, 15);
        labelKpiOverdueTitle.TabIndex = 0;
        labelKpiOverdueTitle.Text = "기한 지남";
        // 
        // labelKpiOverdueValue
        // 
        labelKpiOverdueValue.AutoSize = true;
        labelKpiOverdueValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        labelKpiOverdueValue.Location = new Point(12, 24);
        labelKpiOverdueValue.Name = "labelKpiOverdueValue";
        labelKpiOverdueValue.Size = new Size(26, 30);
        labelKpiOverdueValue.TabIndex = 1;
        labelKpiOverdueValue.Text = "0";
        // 
        // tableFilter
        // 
        tableFilter.ColumnCount = 3;
        tableFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tableFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableFilter.Controls.Add(textSearch, 0, 0);
        tableFilter.Controls.Add(comboFilter, 1, 0);
        tableFilter.Controls.Add(comboCategoryFilter, 2, 0);
        tableFilter.Dock = DockStyle.Fill;
        tableFilter.Location = new Point(3, 131);
        tableFilter.Name = "tableFilter";
        tableFilter.RowCount = 1;
        tableFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableFilter.Size = new Size(1034, 30);
        tableFilter.TabIndex = 3;
        // 
        // textSearch
        // 
        textSearch.Dock = DockStyle.Fill;
        textSearch.Location = new Point(0, 0);
        textSearch.Margin = new Padding(0);
        textSearch.Name = "textSearch";
        textSearch.PlaceholderText = "검색 (제목/태그)";
        textSearch.Size = new Size(620, 27);
        textSearch.TabIndex = 0;
        // 
        // comboFilter
        // 
        comboFilter.Dock = DockStyle.Fill;
        comboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        comboFilter.FormattingEnabled = true;
        comboFilter.Location = new Point(625, 0);
        comboFilter.Margin = new Padding(5, 0, 0, 0);
        comboFilter.Name = "comboFilter";
        comboFilter.Size = new Size(201, 28);
        comboFilter.TabIndex = 1;
        // 
        // comboCategoryFilter
        // 
        comboCategoryFilter.Dock = DockStyle.Fill;
        comboCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        comboCategoryFilter.FormattingEnabled = true;
        comboCategoryFilter.Location = new Point(831, 0);
        comboCategoryFilter.Margin = new Padding(5, 0, 0, 0);
        comboCategoryFilter.Name = "comboCategoryFilter";
        comboCategoryFilter.Size = new Size(203, 28);
        comboCategoryFilter.TabIndex = 2;
        // 
        // tableInput
        // 
        tableInput.ColumnCount = 4;
        tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
        tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
        tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
        tableInput.Controls.Add(textTask, 0, 0);
        tableInput.Controls.Add(comboPriority, 1, 0);
        tableInput.Controls.Add(dateDue, 2, 0);
        tableInput.Controls.Add(buttonAdd, 3, 0);
        tableInput.Dock = DockStyle.Fill;
        tableInput.Location = new Point(3, 167);
        tableInput.Name = "tableInput";
        tableInput.RowCount = 1;
        tableInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableInput.Size = new Size(1034, 30);
        tableInput.TabIndex = 4;
        // 
        // textTask
        // 
        textTask.Dock = DockStyle.Fill;
        textTask.Location = new Point(0, 0);
        textTask.Margin = new Padding(0);
        textTask.Name = "textTask";
        textTask.PlaceholderText = "할 일을 입력하세요";
        textTask.Size = new Size(620, 27);
        textTask.TabIndex = 0;
        // 
        // comboPriority
        // 
        comboPriority.Dock = DockStyle.Fill;
        comboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
        comboPriority.FormattingEnabled = true;
        comboPriority.Location = new Point(625, 0);
        comboPriority.Margin = new Padding(5, 0, 0, 0);
        comboPriority.Name = "comboPriority";
        comboPriority.Size = new Size(119, 28);
        comboPriority.TabIndex = 1;
        // 
        // dateDue
        // 
        dateDue.Dock = DockStyle.Fill;
        dateDue.Format = DateTimePickerFormat.Short;
        dateDue.Location = new Point(749, 0);
        dateDue.Margin = new Padding(5, 0, 0, 0);
        dateDue.Name = "dateDue";
        dateDue.ShowCheckBox = true;
        dateDue.Size = new Size(181, 27);
        dateDue.TabIndex = 2;
        // 
        // buttonAdd
        // 
        buttonAdd.Dock = DockStyle.Fill;
        buttonAdd.Location = new Point(935, 0);
        buttonAdd.Margin = new Padding(5, 0, 0, 0);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(99, 30);
        buttonAdd.TabIndex = 3;
        buttonAdd.Text = "추가";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // tableMeta
        // 
        tableMeta.ColumnCount = 4;
        tableMeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableMeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        tableMeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
        tableMeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
        tableMeta.Controls.Add(comboCategory, 0, 0);
        tableMeta.Controls.Add(textTags, 1, 0);
        tableMeta.Controls.Add(panelProgress, 2, 0);
        tableMeta.Controls.Add(comboSort, 3, 0);
        tableMeta.Dock = DockStyle.Fill;
        tableMeta.Location = new Point(3, 203);
        tableMeta.Name = "tableMeta";
        tableMeta.RowCount = 1;
        tableMeta.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableMeta.Size = new Size(1034, 30);
        tableMeta.TabIndex = 5;
        // 
        // comboCategory
        // 
        comboCategory.Dock = DockStyle.Fill;
        comboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        comboCategory.FormattingEnabled = true;
        comboCategory.Location = new Point(0, 0);
        comboCategory.Margin = new Padding(0);
        comboCategory.Name = "comboCategory";
        comboCategory.Size = new Size(258, 28);
        comboCategory.TabIndex = 0;
        // 
        // textTags
        // 
        textTags.Dock = DockStyle.Fill;
        textTags.Location = new Point(263, 0);
        textTags.Margin = new Padding(5, 0, 0, 0);
        textTags.Name = "textTags";
        textTags.PlaceholderText = "태그 (쉼표로 구분)";
        textTags.Size = new Size(460, 27);
        textTags.TabIndex = 1;
        // 
        // panelProgress
        // 
        panelProgress.Controls.Add(numericProgress);
        panelProgress.Controls.Add(labelProgress);
        panelProgress.Dock = DockStyle.Fill;
        panelProgress.Location = new Point(728, 0);
        panelProgress.Margin = new Padding(5, 0, 0, 0);
        panelProgress.Name = "panelProgress";
        panelProgress.Padding = new Padding(4, 2, 4, 0);
        panelProgress.Size = new Size(155, 30);
        panelProgress.TabIndex = 2;
        // 
        // labelProgress
        // 
        labelProgress.AutoSize = true;
        labelProgress.Location = new Point(4, 6);
        labelProgress.Name = "labelProgress";
        labelProgress.Size = new Size(47, 15);
        labelProgress.TabIndex = 0;
        labelProgress.Text = "진행률";
        // 
        // numericProgress
        // 
        numericProgress.Location = new Point(56, 3);
        numericProgress.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        numericProgress.Name = "numericProgress";
        numericProgress.Size = new Size(92, 23);
        numericProgress.TabIndex = 1;
        // 
        // comboSort
        // 
        comboSort.Dock = DockStyle.Fill;
        comboSort.DropDownStyle = ComboBoxStyle.DropDownList;
        comboSort.FormattingEnabled = true;
        comboSort.Location = new Point(888, 0);
        comboSort.Margin = new Padding(5, 0, 0, 0);
        comboSort.Name = "comboSort";
        comboSort.Size = new Size(146, 28);
        comboSort.TabIndex = 3;
        // 
        // splitMain
        // 
        splitMain.Dock = DockStyle.Fill;
        splitMain.Location = new Point(3, 239);
        splitMain.Name = "splitMain";
        // 
        // splitMain.Panel1
        // 
        splitMain.Panel1.Controls.Add(gridTasks);
        splitMain.Panel1.Padding = new Padding(0, 0, 6, 0);
        // 
        // splitMain.Panel2
        // 
        splitMain.Panel2.Controls.Add(tabRight);
        splitMain.Panel2.Padding = new Padding(6, 0, 0, 0);
        splitMain.Size = new Size(1034, 418);
        splitMain.SplitterDistance = 660;
        splitMain.TabIndex = 6;
        // 
        // gridTasks
        // 
        gridTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridTasks.Dock = DockStyle.Fill;
        gridTasks.Location = new Point(0, 0);
        gridTasks.Name = "gridTasks";
        gridTasks.RowHeadersWidth = 51;
        gridTasks.RowTemplate.Height = 29;
        gridTasks.Size = new Size(654, 418);
        gridTasks.TabIndex = 0;
        gridTasks.CellDoubleClick += gridTasks_CellDoubleClick;
        gridTasks.SelectionChanged += gridTasks_SelectionChanged;
        // 
        // tabRight
        // 
        tabRight.Controls.Add(tabChart);
        tabRight.Controls.Add(tabInsights);
        tabRight.Controls.Add(tabDetails);
        tabRight.Dock = DockStyle.Fill;
        tabRight.Location = new Point(6, 0);
        tabRight.Name = "tabRight";
        tabRight.SelectedIndex = 0;
        tabRight.Size = new Size(364, 418);
        tabRight.TabIndex = 0;
        // 
        // tabChart
        // 
        tabChart.Controls.Add(chartSummary);
        tabChart.Location = new Point(4, 24);
        tabChart.Name = "tabChart";
        tabChart.Padding = new Padding(6);
        tabChart.Size = new Size(356, 390);
        tabChart.TabIndex = 0;
        tabChart.Text = "차트";
        tabChart.UseVisualStyleBackColor = true;
        // 
        // chartSummary
        // 
        chartSummary.Dock = DockStyle.Fill;
        chartSummary.Location = new Point(6, 6);
        chartSummary.Name = "chartSummary";
        chartSummary.Size = new Size(344, 378);
        chartSummary.TabIndex = 0;
        chartSummary.Text = "chartSummary";
        // 
        // tabInsights
        // 
        tabInsights.Controls.Add(tableInsights);
        tabInsights.Location = new Point(4, 24);
        tabInsights.Name = "tabInsights";
        tabInsights.Padding = new Padding(6);
        tabInsights.Size = new Size(356, 390);
        tabInsights.TabIndex = 1;
        tabInsights.Text = "분석";
        tabInsights.UseVisualStyleBackColor = true;
        // 
        // tableInsights
        // 
        tableInsights.ColumnCount = 1;
        tableInsights.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableInsights.Controls.Add(chartCategory, 0, 0);
        tableInsights.Controls.Add(chartPriority, 0, 1);
        tableInsights.Dock = DockStyle.Fill;
        tableInsights.Location = new Point(6, 6);
        tableInsights.Name = "tableInsights";
        tableInsights.RowCount = 2;
        tableInsights.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableInsights.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableInsights.Size = new Size(344, 378);
        tableInsights.TabIndex = 0;
        // 
        // chartCategory
        // 
        chartCategory.Dock = DockStyle.Fill;
        chartCategory.Location = new Point(0, 0);
        chartCategory.Name = "chartCategory";
        chartCategory.Size = new Size(344, 189);
        chartCategory.TabIndex = 0;
        chartCategory.Text = "chartCategory";
        // 
        // chartPriority
        // 
        chartPriority.Dock = DockStyle.Fill;
        chartPriority.Location = new Point(0, 189);
        chartPriority.Name = "chartPriority";
        chartPriority.Size = new Size(344, 189);
        chartPriority.TabIndex = 1;
        chartPriority.Text = "chartPriority";
        // 
        // tabDetails
        // 
        tabDetails.Controls.Add(tableDetails);
        tabDetails.Location = new Point(4, 24);
        tabDetails.Name = "tabDetails";
        tabDetails.Padding = new Padding(6);
        tabDetails.Size = new Size(356, 390);
        tabDetails.TabIndex = 2;
        tabDetails.Text = "상세";
        tabDetails.UseVisualStyleBackColor = true;
        // 
        // tableDetails
        // 
        tableDetails.ColumnCount = 2;
        tableDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
        tableDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableDetails.Controls.Add(labelDetailTitleLabel, 0, 0);
        tableDetails.Controls.Add(labelDetailTitle, 1, 0);
        tableDetails.Controls.Add(labelDetailCategoryLabel, 0, 1);
        tableDetails.Controls.Add(labelDetailCategory, 1, 1);
        tableDetails.Controls.Add(labelDetailTagsLabel, 0, 2);
        tableDetails.Controls.Add(labelDetailTags, 1, 2);
        tableDetails.Controls.Add(labelDetailPriorityLabel, 0, 3);
        tableDetails.Controls.Add(labelDetailPriority, 1, 3);
        tableDetails.Controls.Add(labelDetailDueLabel, 0, 4);
        tableDetails.Controls.Add(labelDetailDue, 1, 4);
        tableDetails.Controls.Add(labelDetailProgressLabel, 0, 5);
        tableDetails.Controls.Add(numericDetailProgress, 1, 5);
        tableDetails.Controls.Add(labelDetailNotesLabel, 0, 6);
        tableDetails.Controls.Add(textDetailNotes, 1, 6);
        tableDetails.Controls.Add(buttonSaveDetail, 1, 7);
        tableDetails.Dock = DockStyle.Fill;
        tableDetails.Location = new Point(6, 6);
        tableDetails.Name = "tableDetails";
        tableDetails.RowCount = 8;
        tableDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        tableDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        tableDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        tableDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        tableDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
        tableDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        tableDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableDetails.Size = new Size(344, 378);
        tableDetails.TabIndex = 0;
        // 
        // labelDetailTitleLabel
        // 
        labelDetailTitleLabel.AutoSize = true;
        labelDetailTitleLabel.ForeColor = Color.FromArgb(95, 99, 110);
        labelDetailTitleLabel.Location = new Point(3, 0);
        labelDetailTitleLabel.Name = "labelDetailTitleLabel";
        labelDetailTitleLabel.Size = new Size(31, 15);
        labelDetailTitleLabel.TabIndex = 0;
        labelDetailTitleLabel.Text = "제목";
        // 
        // labelDetailTitle
        // 
        labelDetailTitle.AutoEllipsis = true;
        labelDetailTitle.Dock = DockStyle.Fill;
        labelDetailTitle.Location = new Point(93, 0);
        labelDetailTitle.Name = "labelDetailTitle";
        labelDetailTitle.Size = new Size(248, 26);
        labelDetailTitle.TabIndex = 1;
        labelDetailTitle.Text = "-";
        // 
        // labelDetailCategoryLabel
        // 
        labelDetailCategoryLabel.AutoSize = true;
        labelDetailCategoryLabel.ForeColor = Color.FromArgb(95, 99, 110);
        labelDetailCategoryLabel.Location = new Point(3, 26);
        labelDetailCategoryLabel.Name = "labelDetailCategoryLabel";
        labelDetailCategoryLabel.Size = new Size(43, 15);
        labelDetailCategoryLabel.TabIndex = 2;
        labelDetailCategoryLabel.Text = "카테고리";
        // 
        // labelDetailCategory
        // 
        labelDetailCategory.Dock = DockStyle.Fill;
        labelDetailCategory.Location = new Point(93, 26);
        labelDetailCategory.Name = "labelDetailCategory";
        labelDetailCategory.Size = new Size(248, 26);
        labelDetailCategory.TabIndex = 3;
        labelDetailCategory.Text = "-";
        // 
        // labelDetailTagsLabel
        // 
        labelDetailTagsLabel.AutoSize = true;
        labelDetailTagsLabel.ForeColor = Color.FromArgb(95, 99, 110);
        labelDetailTagsLabel.Location = new Point(3, 52);
        labelDetailTagsLabel.Name = "labelDetailTagsLabel";
        labelDetailTagsLabel.Size = new Size(31, 15);
        labelDetailTagsLabel.TabIndex = 4;
        labelDetailTagsLabel.Text = "태그";
        // 
        // labelDetailTags
        // 
        labelDetailTags.Dock = DockStyle.Fill;
        labelDetailTags.Location = new Point(93, 52);
        labelDetailTags.Name = "labelDetailTags";
        labelDetailTags.Size = new Size(248, 26);
        labelDetailTags.TabIndex = 5;
        labelDetailTags.Text = "-";
        // 
        // labelDetailPriorityLabel
        // 
        labelDetailPriorityLabel.AutoSize = true;
        labelDetailPriorityLabel.ForeColor = Color.FromArgb(95, 99, 110);
        labelDetailPriorityLabel.Location = new Point(3, 78);
        labelDetailPriorityLabel.Name = "labelDetailPriorityLabel";
        labelDetailPriorityLabel.Size = new Size(43, 15);
        labelDetailPriorityLabel.TabIndex = 6;
        labelDetailPriorityLabel.Text = "우선순위";
        // 
        // labelDetailPriority
        // 
        labelDetailPriority.Dock = DockStyle.Fill;
        labelDetailPriority.Location = new Point(93, 78);
        labelDetailPriority.Name = "labelDetailPriority";
        labelDetailPriority.Size = new Size(248, 26);
        labelDetailPriority.TabIndex = 7;
        labelDetailPriority.Text = "-";
        // 
        // labelDetailDueLabel
        // 
        labelDetailDueLabel.AutoSize = true;
        labelDetailDueLabel.ForeColor = Color.FromArgb(95, 99, 110);
        labelDetailDueLabel.Location = new Point(3, 104);
        labelDetailDueLabel.Name = "labelDetailDueLabel";
        labelDetailDueLabel.Size = new Size(43, 15);
        labelDetailDueLabel.TabIndex = 8;
        labelDetailDueLabel.Text = "마감일";
        // 
        // labelDetailDue
        // 
        labelDetailDue.Dock = DockStyle.Fill;
        labelDetailDue.Location = new Point(93, 104);
        labelDetailDue.Name = "labelDetailDue";
        labelDetailDue.Size = new Size(248, 26);
        labelDetailDue.TabIndex = 9;
        labelDetailDue.Text = "-";
        // 
        // labelDetailProgressLabel
        // 
        labelDetailProgressLabel.AutoSize = true;
        labelDetailProgressLabel.ForeColor = Color.FromArgb(95, 99, 110);
        labelDetailProgressLabel.Location = new Point(3, 130);
        labelDetailProgressLabel.Name = "labelDetailProgressLabel";
        labelDetailProgressLabel.Size = new Size(47, 15);
        labelDetailProgressLabel.TabIndex = 10;
        labelDetailProgressLabel.Text = "진행률";
        // 
        // numericDetailProgress
        // 
        numericDetailProgress.Dock = DockStyle.Left;
        numericDetailProgress.Location = new Point(93, 133);
        numericDetailProgress.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        numericDetailProgress.Name = "numericDetailProgress";
        numericDetailProgress.Size = new Size(90, 23);
        numericDetailProgress.TabIndex = 11;
        // 
        // labelDetailNotesLabel
        // 
        labelDetailNotesLabel.AutoSize = true;
        labelDetailNotesLabel.ForeColor = Color.FromArgb(95, 99, 110);
        labelDetailNotesLabel.Location = new Point(3, 162);
        labelDetailNotesLabel.Name = "labelDetailNotesLabel";
        labelDetailNotesLabel.Size = new Size(31, 15);
        labelDetailNotesLabel.TabIndex = 12;
        labelDetailNotesLabel.Text = "메모";
        // 
        // textDetailNotes
        // 
        textDetailNotes.Dock = DockStyle.Fill;
        textDetailNotes.Location = new Point(93, 165);
        textDetailNotes.Multiline = true;
        textDetailNotes.Name = "textDetailNotes";
        textDetailNotes.ScrollBars = ScrollBars.Vertical;
        textDetailNotes.Size = new Size(248, 174);
        textDetailNotes.TabIndex = 13;
        // 
        // buttonSaveDetail
        // 
        buttonSaveDetail.Dock = DockStyle.Right;
        buttonSaveDetail.Location = new Point(241, 345);
        buttonSaveDetail.Name = "buttonSaveDetail";
        buttonSaveDetail.Size = new Size(100, 30);
        buttonSaveDetail.TabIndex = 14;
        buttonSaveDetail.Text = "상세 저장";
        buttonSaveDetail.UseVisualStyleBackColor = true;
        buttonSaveDetail.Click += buttonSaveDetail_Click;
        // 
        // tableActions
        // 
        tableActions.ColumnCount = 9;
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableActions.Controls.Add(buttonEdit, 0, 0);
        tableActions.Controls.Add(buttonToggle, 1, 0);
        tableActions.Controls.Add(buttonRemove, 2, 0);
        tableActions.Controls.Add(buttonClearDone, 3, 0);
        tableActions.Controls.Add(buttonMoveUp, 4, 0);
        tableActions.Controls.Add(buttonMoveDown, 5, 0);
        tableActions.Controls.Add(buttonCompleteAll, 6, 0);
        tableActions.Controls.Add(buttonResetSample, 7, 0);
        tableActions.Controls.Add(buttonExport, 8, 0);
        tableActions.Dock = DockStyle.Fill;
        tableActions.Location = new Point(3, 663);
        tableActions.Name = "tableActions";
        tableActions.RowCount = 1;
        tableActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableActions.Size = new Size(1034, 34);
        tableActions.TabIndex = 7;
        // 
        // buttonEdit
        // 
        buttonEdit.Dock = DockStyle.Fill;
        buttonEdit.Location = new Point(0, 0);
        buttonEdit.Margin = new Padding(0);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(110, 34);
        buttonEdit.TabIndex = 0;
        buttonEdit.Text = "수정";
        buttonEdit.UseVisualStyleBackColor = true;
        buttonEdit.Click += buttonEdit_Click;
        // 
        // buttonToggle
        // 
        buttonToggle.Dock = DockStyle.Fill;
        buttonToggle.Location = new Point(110, 0);
        buttonToggle.Margin = new Padding(0, 0, 0, 0);
        buttonToggle.Name = "buttonToggle";
        buttonToggle.Size = new Size(110, 34);
        buttonToggle.TabIndex = 1;
        buttonToggle.Text = "완료/해제";
        buttonToggle.UseVisualStyleBackColor = true;
        buttonToggle.Click += buttonToggle_Click;
        // 
        // buttonRemove
        // 
        buttonRemove.Dock = DockStyle.Fill;
        buttonRemove.Location = new Point(220, 0);
        buttonRemove.Margin = new Padding(0);
        buttonRemove.Name = "buttonRemove";
        buttonRemove.Size = new Size(110, 34);
        buttonRemove.TabIndex = 2;
        buttonRemove.Text = "삭제";
        buttonRemove.UseVisualStyleBackColor = true;
        buttonRemove.Click += buttonRemove_Click;
        // 
        // buttonClearDone
        // 
        buttonClearDone.Dock = DockStyle.Fill;
        buttonClearDone.Location = new Point(330, 0);
        buttonClearDone.Margin = new Padding(0);
        buttonClearDone.Name = "buttonClearDone";
        buttonClearDone.Size = new Size(140, 34);
        buttonClearDone.TabIndex = 3;
        buttonClearDone.Text = "완료 항목 삭제";
        buttonClearDone.UseVisualStyleBackColor = true;
        buttonClearDone.Click += buttonClearDone_Click;
        // 
        // buttonMoveUp
        // 
        buttonMoveUp.Dock = DockStyle.Fill;
        buttonMoveUp.Location = new Point(470, 0);
        buttonMoveUp.Margin = new Padding(0);
        buttonMoveUp.Name = "buttonMoveUp";
        buttonMoveUp.Size = new Size(70, 34);
        buttonMoveUp.TabIndex = 4;
        buttonMoveUp.Text = "위";
        buttonMoveUp.UseVisualStyleBackColor = true;
        buttonMoveUp.Click += buttonMoveUp_Click;
        // 
        // buttonMoveDown
        // 
        buttonMoveDown.Dock = DockStyle.Fill;
        buttonMoveDown.Location = new Point(540, 0);
        buttonMoveDown.Margin = new Padding(0);
        buttonMoveDown.Name = "buttonMoveDown";
        buttonMoveDown.Size = new Size(70, 34);
        buttonMoveDown.TabIndex = 5;
        buttonMoveDown.Text = "아래";
        buttonMoveDown.UseVisualStyleBackColor = true;
        buttonMoveDown.Click += buttonMoveDown_Click;
        // 
        // buttonCompleteAll
        // 
        buttonCompleteAll.Dock = DockStyle.Fill;
        buttonCompleteAll.Location = new Point(610, 0);
        buttonCompleteAll.Margin = new Padding(0);
        buttonCompleteAll.Name = "buttonCompleteAll";
        buttonCompleteAll.Size = new Size(110, 34);
        buttonCompleteAll.TabIndex = 6;
        buttonCompleteAll.Text = "모두 완료";
        buttonCompleteAll.UseVisualStyleBackColor = true;
        buttonCompleteAll.Click += buttonCompleteAll_Click;
        // 
        // buttonResetSample
        // 
        buttonResetSample.Dock = DockStyle.Fill;
        buttonResetSample.Location = new Point(720, 0);
        buttonResetSample.Margin = new Padding(0);
        buttonResetSample.Name = "buttonResetSample";
        buttonResetSample.Size = new Size(110, 34);
        buttonResetSample.TabIndex = 7;
        buttonResetSample.Text = "샘플 초기화";
        buttonResetSample.UseVisualStyleBackColor = true;
        buttonResetSample.Click += buttonResetSample_Click;
        // 
        // buttonExport
        // 
        buttonExport.Anchor = AnchorStyles.Right;
        buttonExport.Location = new Point(936, 2);
        buttonExport.Margin = new Padding(0);
        buttonExport.Name = "buttonExport";
        buttonExport.Size = new Size(98, 30);
        buttonExport.TabIndex = 8;
        buttonExport.Text = "CSV 내보내기";
        buttonExport.UseVisualStyleBackColor = true;
        buttonExport.Click += buttonExport_Click;
        // 
        // labelStats
        // 
        labelStats.AutoSize = true;
        labelStats.Dock = DockStyle.Fill;
        labelStats.Location = new Point(3, 700);
        labelStats.Name = "labelStats";
        labelStats.Padding = new Padding(0, 4, 0, 0);
        labelStats.Size = new Size(1034, 28);
        labelStats.TabIndex = 8;
        labelStats.Text = "총 0개, 완료 0개";
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(244, 246, 250);
        ClientSize = new Size(1064, 724);
        Controls.Add(tableMain);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Padding = new Padding(12);
        Name = "Form1";
        Text = "CodexSample1 - Todo";
        tableMain.ResumeLayout(false);
        tableMain.PerformLayout();
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        tableKpi.ResumeLayout(false);
        panelKpiTotal.ResumeLayout(false);
        panelKpiTotal.PerformLayout();
        panelKpiDone.ResumeLayout(false);
        panelKpiDone.PerformLayout();
        panelKpiPending.ResumeLayout(false);
        panelKpiPending.PerformLayout();
        panelKpiOverdue.ResumeLayout(false);
        panelKpiOverdue.PerformLayout();
        tableFilter.ResumeLayout(false);
        tableFilter.PerformLayout();
        tableInput.ResumeLayout(false);
        tableInput.PerformLayout();
        tableMeta.ResumeLayout(false);
        tableMeta.PerformLayout();
        panelProgress.ResumeLayout(false);
        panelProgress.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericProgress).EndInit();
        splitMain.Panel1.ResumeLayout(false);
        splitMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
        splitMain.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridTasks).EndInit();
        tabRight.ResumeLayout(false);
        tabChart.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)chartSummary).EndInit();
        tabInsights.ResumeLayout(false);
        tableInsights.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)chartCategory).EndInit();
        ((System.ComponentModel.ISupportInitialize)chartPriority).EndInit();
        tabDetails.ResumeLayout(false);
        tableDetails.ResumeLayout(false);
        tableDetails.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericDetailProgress).EndInit();
        tableActions.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableMain;
    private Panel panelHeader;
    private Label labelTitle;
    private Label labelSubtitle;
    private TableLayoutPanel tableKpi;
    private Panel panelKpiTotal;
    private Label labelKpiTotalTitle;
    private Label labelKpiTotalValue;
    private Panel panelKpiDone;
    private Label labelKpiDoneTitle;
    private Label labelKpiDoneValue;
    private Panel panelKpiPending;
    private Label labelKpiPendingTitle;
    private Label labelKpiPendingValue;
    private Panel panelKpiOverdue;
    private Label labelKpiOverdueTitle;
    private Label labelKpiOverdueValue;
    private TableLayoutPanel tableFilter;
    private TextBox textSearch;
    private ComboBox comboFilter;
    private ComboBox comboCategoryFilter;
    private TableLayoutPanel tableInput;
    private TextBox textTask;
    private ComboBox comboPriority;
    private DateTimePicker dateDue;
    private Button buttonAdd;
    private TableLayoutPanel tableMeta;
    private ComboBox comboCategory;
    private TextBox textTags;
    private Panel panelProgress;
    private Label labelProgress;
    private NumericUpDown numericProgress;
    private ComboBox comboSort;
    private SplitContainer splitMain;
    private DataGridView gridTasks;
    private TabControl tabRight;
    private TabPage tabChart;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartSummary;
    private TabPage tabInsights;
    private TableLayoutPanel tableInsights;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartPriority;
    private TabPage tabDetails;
    private TableLayoutPanel tableDetails;
    private Label labelDetailTitleLabel;
    private Label labelDetailTitle;
    private Label labelDetailCategoryLabel;
    private Label labelDetailCategory;
    private Label labelDetailTagsLabel;
    private Label labelDetailTags;
    private Label labelDetailPriorityLabel;
    private Label labelDetailPriority;
    private Label labelDetailDueLabel;
    private Label labelDetailDue;
    private Label labelDetailProgressLabel;
    private NumericUpDown numericDetailProgress;
    private Label labelDetailNotesLabel;
    private TextBox textDetailNotes;
    private Button buttonSaveDetail;
    private TableLayoutPanel tableActions;
    private Button buttonEdit;
    private Button buttonToggle;
    private Button buttonRemove;
    private Button buttonClearDone;
    private Button buttonMoveUp;
    private Button buttonMoveDown;
    private Button buttonCompleteAll;
    private Button buttonResetSample;
    private Button buttonExport;
    private Label labelStats;
}

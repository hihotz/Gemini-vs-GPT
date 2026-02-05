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
        tableFilter = new TableLayoutPanel();
        textSearch = new TextBox();
        comboFilter = new ComboBox();
        tableInput = new TableLayoutPanel();
        textTask = new TextBox();
        comboPriority = new ComboBox();
        dateDue = new DateTimePicker();
        buttonAdd = new Button();
        splitMain = new SplitContainer();
        gridTasks = new DataGridView();
        chartSummary = new System.Windows.Forms.DataVisualization.Charting.Chart();
        tableActions = new TableLayoutPanel();
        buttonEdit = new Button();
        buttonToggle = new Button();
        buttonRemove = new Button();
        buttonClearDone = new Button();
        buttonMoveUp = new Button();
        buttonMoveDown = new Button();
        labelStats = new Label();
        tableMain.SuspendLayout();
        panelHeader.SuspendLayout();
        tableFilter.SuspendLayout();
        tableInput.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
        splitMain.Panel1.SuspendLayout();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridTasks).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chartSummary).BeginInit();
        tableActions.SuspendLayout();
        SuspendLayout();
        // 
        // tableMain
        // 
        tableMain.ColumnCount = 1;
        tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableMain.Controls.Add(panelHeader, 0, 0);
        tableMain.Controls.Add(tableFilter, 0, 1);
        tableMain.Controls.Add(tableInput, 0, 2);
        tableMain.Controls.Add(splitMain, 0, 3);
        tableMain.Controls.Add(tableActions, 0, 4);
        tableMain.Controls.Add(labelStats, 0, 5);
        tableMain.Dock = DockStyle.Fill;
        tableMain.Location = new Point(12, 12);
        tableMain.Name = "tableMain";
        tableMain.RowCount = 6;
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        tableMain.Size = new Size(960, 636);
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
        panelHeader.Size = new Size(954, 58);
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
        // tableFilter
        // 
        tableFilter.ColumnCount = 2;
        tableFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
        tableFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        tableFilter.Controls.Add(textSearch, 0, 0);
        tableFilter.Controls.Add(comboFilter, 1, 0);
        tableFilter.Dock = DockStyle.Fill;
        tableFilter.Location = new Point(3, 67);
        tableFilter.Name = "tableFilter";
        tableFilter.RowCount = 1;
        tableFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableFilter.Size = new Size(954, 30);
        tableFilter.TabIndex = 2;
        // 
        // textSearch
        // 
        textSearch.Dock = DockStyle.Fill;
        textSearch.Location = new Point(0, 0);
        textSearch.Margin = new Padding(0);
        textSearch.Name = "textSearch";
        textSearch.PlaceholderText = "검색 (제목)";
        textSearch.Size = new Size(667, 27);
        textSearch.TabIndex = 0;
        // 
        // comboFilter
        // 
        comboFilter.Dock = DockStyle.Fill;
        comboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        comboFilter.FormattingEnabled = true;
        comboFilter.Location = new Point(672, 0);
        comboFilter.Margin = new Padding(5, 0, 0, 0);
        comboFilter.Name = "comboFilter";
        comboFilter.Size = new Size(282, 28);
        comboFilter.TabIndex = 1;
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
        tableInput.Location = new Point(3, 103);
        tableInput.Name = "tableInput";
        tableInput.RowCount = 1;
        tableInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableInput.Size = new Size(954, 30);
        tableInput.TabIndex = 3;
        // 
        // textTask
        // 
        textTask.Dock = DockStyle.Fill;
        textTask.Location = new Point(0, 0);
        textTask.Margin = new Padding(0);
        textTask.Name = "textTask";
        textTask.PlaceholderText = "할 일을 입력하세요";
        textTask.Size = new Size(572, 27);
        textTask.TabIndex = 0;
        // 
        // comboPriority
        // 
        comboPriority.Dock = DockStyle.Fill;
        comboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
        comboPriority.FormattingEnabled = true;
        comboPriority.Location = new Point(577, 0);
        comboPriority.Margin = new Padding(5, 0, 0, 0);
        comboPriority.Name = "comboPriority";
        comboPriority.Size = new Size(109, 28);
        comboPriority.TabIndex = 1;
        // 
        // dateDue
        // 
        dateDue.Dock = DockStyle.Fill;
        dateDue.Format = DateTimePickerFormat.Short;
        dateDue.Location = new Point(691, 0);
        dateDue.Margin = new Padding(5, 0, 0, 0);
        dateDue.Name = "dateDue";
        dateDue.ShowCheckBox = true;
        dateDue.Size = new Size(166, 27);
        dateDue.TabIndex = 2;
        // 
        // buttonAdd
        // 
        buttonAdd.Dock = DockStyle.Fill;
        buttonAdd.Location = new Point(862, 0);
        buttonAdd.Margin = new Padding(5, 0, 0, 0);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(92, 30);
        buttonAdd.TabIndex = 3;
        buttonAdd.Text = "추가";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // splitMain
        // 
        splitMain.Dock = DockStyle.Fill;
        splitMain.Location = new Point(3, 139);
        splitMain.Name = "splitMain";
        // 
        // splitMain.Panel1
        // 
        splitMain.Panel1.Controls.Add(gridTasks);
        splitMain.Panel1.Padding = new Padding(0, 0, 6, 0);
        // 
        // splitMain.Panel2
        // 
        splitMain.Panel2.Controls.Add(chartSummary);
        splitMain.Panel2.Padding = new Padding(6, 0, 0, 0);
        splitMain.Size = new Size(954, 454);
        splitMain.SplitterDistance = 610;
        splitMain.TabIndex = 4;
        // 
        // gridTasks
        // 
        gridTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridTasks.Dock = DockStyle.Fill;
        gridTasks.Location = new Point(0, 0);
        gridTasks.Name = "gridTasks";
        gridTasks.RowHeadersWidth = 51;
        gridTasks.RowTemplate.Height = 29;
        gridTasks.Size = new Size(604, 454);
        gridTasks.TabIndex = 0;
        gridTasks.CellDoubleClick += gridTasks_CellDoubleClick;
        // 
        // chartSummary
        // 
        chartSummary.Dock = DockStyle.Fill;
        chartSummary.Location = new Point(6, 0);
        chartSummary.Name = "chartSummary";
        chartSummary.Size = new Size(334, 454);
        chartSummary.TabIndex = 0;
        chartSummary.Text = "chartSummary";
        // 
        // tableActions
        // 
        tableActions.ColumnCount = 6;
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
        tableActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
        tableActions.Controls.Add(buttonEdit, 0, 0);
        tableActions.Controls.Add(buttonToggle, 1, 0);
        tableActions.Controls.Add(buttonRemove, 2, 0);
        tableActions.Controls.Add(buttonClearDone, 3, 0);
        tableActions.Controls.Add(buttonMoveUp, 4, 0);
        tableActions.Controls.Add(buttonMoveDown, 5, 0);
        tableActions.Dock = DockStyle.Fill;
        tableActions.Location = new Point(3, 599);
        tableActions.Name = "tableActions";
        tableActions.RowCount = 1;
        tableActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableActions.Size = new Size(954, 34);
        tableActions.TabIndex = 5;
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
        // labelStats
        // 
        labelStats.AutoSize = true;
        labelStats.Dock = DockStyle.Fill;
        labelStats.Location = new Point(3, 636);
        labelStats.Name = "labelStats";
        labelStats.Padding = new Padding(0, 4, 0, 0);
        labelStats.Size = new Size(954, 28);
        labelStats.TabIndex = 6;
        labelStats.Text = "총 0개, 완료 0개";
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(244, 246, 250);
        ClientSize = new Size(984, 660);
        Controls.Add(tableMain);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Padding = new Padding(12);
        Name = "Form1";
        Text = "CodexSample1 - Todo";
        tableMain.ResumeLayout(false);
        tableMain.PerformLayout();
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        tableFilter.ResumeLayout(false);
        tableFilter.PerformLayout();
        tableInput.ResumeLayout(false);
        tableInput.PerformLayout();
        splitMain.Panel1.ResumeLayout(false);
        splitMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
        splitMain.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridTasks).EndInit();
        ((System.ComponentModel.ISupportInitialize)chartSummary).EndInit();
        tableActions.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableMain;
    private Panel panelHeader;
    private Label labelTitle;
    private Label labelSubtitle;
    private TableLayoutPanel tableFilter;
    private TextBox textSearch;
    private ComboBox comboFilter;
    private TableLayoutPanel tableInput;
    private TextBox textTask;
    private ComboBox comboPriority;
    private DateTimePicker dateDue;
    private Button buttonAdd;
    private SplitContainer splitMain;
    private DataGridView gridTasks;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartSummary;
    private TableLayoutPanel tableActions;
    private Button buttonEdit;
    private Button buttonToggle;
    private Button buttonRemove;
    private Button buttonClearDone;
    private Button buttonMoveUp;
    private Button buttonMoveDown;
    private Label labelStats;
}

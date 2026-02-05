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
        labelTitle = new Label();
        textTask = new TextBox();
        buttonAdd = new Button();
        buttonToggle = new Button();
        buttonRemove = new Button();
        buttonClearDone = new Button();
        listTasks = new ListBox();
        labelStats = new Label();
        tableMain = new TableLayoutPanel();
        panelInput = new Panel();
        panelActions = new Panel();
        tableMain.SuspendLayout();
        panelInput.SuspendLayout();
        panelActions.SuspendLayout();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Dock = DockStyle.Fill;
        labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        labelTitle.Location = new Point(3, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Padding = new Padding(0, 4, 0, 4);
        labelTitle.Size = new Size(614, 32);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "간단한 할 일 목록";
        // 
        // textTask
        // 
        textTask.Location = new Point(0, 0);
        textTask.Name = "textTask";
        textTask.PlaceholderText = "할 일을 입력하세요";
        textTask.Size = new Size(392, 27);
        textTask.TabIndex = 0;
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new Point(400, 0);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(120, 28);
        buttonAdd.TabIndex = 1;
        buttonAdd.Text = "추가";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonToggle
        // 
        buttonToggle.Location = new Point(0, 0);
        buttonToggle.Name = "buttonToggle";
        buttonToggle.Size = new Size(120, 28);
        buttonToggle.TabIndex = 0;
        buttonToggle.Text = "완료/해제";
        buttonToggle.UseVisualStyleBackColor = true;
        buttonToggle.Click += buttonToggle_Click;
        // 
        // buttonRemove
        // 
        buttonRemove.Location = new Point(128, 0);
        buttonRemove.Name = "buttonRemove";
        buttonRemove.Size = new Size(120, 28);
        buttonRemove.TabIndex = 1;
        buttonRemove.Text = "삭제";
        buttonRemove.UseVisualStyleBackColor = true;
        buttonRemove.Click += buttonRemove_Click;
        // 
        // buttonClearDone
        // 
        buttonClearDone.Location = new Point(256, 0);
        buttonClearDone.Name = "buttonClearDone";
        buttonClearDone.Size = new Size(140, 28);
        buttonClearDone.TabIndex = 2;
        buttonClearDone.Text = "완료 항목 삭제";
        buttonClearDone.UseVisualStyleBackColor = true;
        buttonClearDone.Click += buttonClearDone_Click;
        // 
        // listTasks
        // 
        listTasks.Dock = DockStyle.Fill;
        listTasks.FormattingEnabled = true;
        listTasks.ItemHeight = 20;
        listTasks.Location = new Point(3, 89);
        listTasks.Name = "listTasks";
        listTasks.Size = new Size(614, 272);
        listTasks.TabIndex = 3;
        listTasks.DoubleClick += listTasks_DoubleClick;
        // 
        // labelStats
        // 
        labelStats.AutoSize = true;
        labelStats.Dock = DockStyle.Fill;
        labelStats.Location = new Point(3, 364);
        labelStats.Name = "labelStats";
        labelStats.Padding = new Padding(0, 4, 0, 0);
        labelStats.Size = new Size(614, 28);
        labelStats.TabIndex = 4;
        labelStats.Text = "총 0개, 완료 0개";
        // 
        // tableMain
        // 
        tableMain.ColumnCount = 1;
        tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableMain.Controls.Add(labelTitle, 0, 0);
        tableMain.Controls.Add(panelInput, 0, 1);
        tableMain.Controls.Add(listTasks, 0, 2);
        tableMain.Controls.Add(panelActions, 0, 3);
        tableMain.Controls.Add(labelStats, 0, 4);
        tableMain.Dock = DockStyle.Fill;
        tableMain.Location = new Point(12, 12);
        tableMain.Name = "tableMain";
        tableMain.RowCount = 5;
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
        tableMain.Size = new Size(620, 392);
        tableMain.TabIndex = 5;
        // 
        // panelInput
        // 
        panelInput.Controls.Add(textTask);
        panelInput.Controls.Add(buttonAdd);
        panelInput.Dock = DockStyle.Fill;
        panelInput.Location = new Point(3, 35);
        panelInput.Name = "panelInput";
        panelInput.Size = new Size(614, 30);
        panelInput.TabIndex = 6;
        // 
        // panelActions
        // 
        panelActions.Controls.Add(buttonToggle);
        panelActions.Controls.Add(buttonRemove);
        panelActions.Controls.Add(buttonClearDone);
        panelActions.Dock = DockStyle.Fill;
        panelActions.Location = new Point(3, 331);
        panelActions.Name = "panelActions";
        panelActions.Size = new Size(614, 30);
        panelActions.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(644, 416);
        Controls.Add(tableMain);
        Padding = new Padding(12);
        Name = "Form1";
        Text = "CodexSample1 - Todo";
        tableMain.ResumeLayout(false);
        tableMain.PerformLayout();
        panelInput.ResumeLayout(false);
        panelInput.PerformLayout();
        panelActions.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Label labelTitle;
    private TextBox textTask;
    private Button buttonAdd;
    private Button buttonToggle;
    private Button buttonRemove;
    private Button buttonClearDone;
    private ListBox listTasks;
    private Label labelStats;
    private TableLayoutPanel tableMain;
    private Panel panelInput;
    private Panel panelActions;
}

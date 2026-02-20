namespace SimpleWinFormsApp;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.panelSidebar = new System.Windows.Forms.Panel();
        this.btnNavExpenses = new System.Windows.Forms.Button();
        this.btnNavDashboard = new System.Windows.Forms.Button();
        this.btnNavNotes = new System.Windows.Forms.Button();
        this.btnNavTodo = new System.Windows.Forms.Button();
        this.lblTitle = new System.Windows.Forms.Label();
        this.panelContent = new System.Windows.Forms.Panel();
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabTodo = new System.Windows.Forms.TabPage();
        this.lblStatus = new System.Windows.Forms.Label();
        this.btnRemove = new System.Windows.Forms.Button();
        this.lstTasks = new System.Windows.Forms.ListBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.txtInput = new System.Windows.Forms.TextBox();
        this.tabNotes = new System.Windows.Forms.TabPage();
        this.btnLoadNote = new System.Windows.Forms.Button();
        this.btnSaveNote = new System.Windows.Forms.Button();
        this.rtbNotes = new System.Windows.Forms.RichTextBox();
        this.tabDashboard = new System.Windows.Forms.TabPage();
        this.lblQuote = new System.Windows.Forms.Label();
        this.grpPomodoro = new System.Windows.Forms.GroupBox();
        this.btnPomodoroReset = new System.Windows.Forms.Button();
        this.btnPomodoroAction = new System.Windows.Forms.Button();
        this.lblPomodoroTime = new System.Windows.Forms.Label();
        this.lblRam = new System.Windows.Forms.Label();
        this.progRam = new System.Windows.Forms.ProgressBar();
        this.lblCpu = new System.Windows.Forms.Label();
        this.progCpu = new System.Windows.Forms.ProgressBar();
        this.lblClock = new System.Windows.Forms.Label();
        this.tabExpenses = new System.Windows.Forms.TabPage();
        this.splitContainerExpenses = new System.Windows.Forms.SplitContainer();
        this.dgvExpenses = new System.Windows.Forms.DataGridView();
        this.picChart = new System.Windows.Forms.PictureBox();
        this.panelExpenseControls = new System.Windows.Forms.Panel();
        this.btnGenerateData = new System.Windows.Forms.Button();
        this.timerClock = new System.Windows.Forms.Timer(this.components);
        this.chkDarkMode = new System.Windows.Forms.CheckBox();
        this.timerPomodoro = new System.Windows.Forms.Timer(this.components);
        this.panelSidebar.SuspendLayout();
        this.panelContent.SuspendLayout();
        this.tabControl1.SuspendLayout();
        this.tabTodo.SuspendLayout();
        this.tabNotes.SuspendLayout();
        this.tabDashboard.SuspendLayout();
        this.grpPomodoro.SuspendLayout();
        this.tabExpenses.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.splitContainerExpenses)).BeginInit();
        this.splitContainerExpenses.Panel1.SuspendLayout();
        this.splitContainerExpenses.Panel2.SuspendLayout();
        this.splitContainerExpenses.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.picChart)).BeginInit();
        this.panelExpenseControls.SuspendLayout();
        this.SuspendLayout();
        // 
        // panelSidebar
        // 
        this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
        this.panelSidebar.Controls.Add(this.btnNavExpenses);
        this.panelSidebar.Controls.Add(this.btnNavDashboard);
        this.panelSidebar.Controls.Add(this.btnNavNotes);
        this.panelSidebar.Controls.Add(this.btnNavTodo);
        this.panelSidebar.Controls.Add(this.lblTitle);
        this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.panelSidebar.Location = new System.Drawing.Point(0, 0);
        this.panelSidebar.Name = "panelSidebar";
        this.panelSidebar.Size = new System.Drawing.Size(180, 500);
        this.panelSidebar.TabIndex = 0;
        // 
        // btnNavExpenses
        // 
        this.btnNavExpenses.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavExpenses.FlatAppearance.BorderSize = 0;
        this.btnNavExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavExpenses.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnNavExpenses.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnNavExpenses.Location = new System.Drawing.Point(0, 180);
        this.btnNavExpenses.Name = "btnNavExpenses";
        this.btnNavExpenses.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnNavExpenses.Size = new System.Drawing.Size(180, 45);
        this.btnNavExpenses.TabIndex = 4;
        this.btnNavExpenses.Text = "📊 Expenses";
        this.btnNavExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavExpenses.UseVisualStyleBackColor = true;
        this.btnNavExpenses.Click += new System.EventHandler(this.btnNavExpenses_Click);
        // 
        // btnNavDashboard
        // 
        this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavDashboard.FlatAppearance.BorderSize = 0;
        this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnNavDashboard.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnNavDashboard.Location = new System.Drawing.Point(0, 135);
        this.btnNavDashboard.Name = "btnNavDashboard";
        this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnNavDashboard.Size = new System.Drawing.Size(180, 45);
        this.btnNavDashboard.TabIndex = 3;
        this.btnNavDashboard.Text = "🏠 Dashboard";
        this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavDashboard.UseVisualStyleBackColor = true;
        this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
        // 
        // btnNavNotes
        // 
        this.btnNavNotes.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavNotes.FlatAppearance.BorderSize = 0;
        this.btnNavNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnNavNotes.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnNavNotes.Location = new System.Drawing.Point(0, 90);
        this.btnNavNotes.Name = "btnNavNotes";
        this.btnNavNotes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnNavNotes.Size = new System.Drawing.Size(180, 45);
        this.btnNavNotes.TabIndex = 2;
        this.btnNavNotes.Text = "📝 Notes";
        this.btnNavNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavNotes.UseVisualStyleBackColor = true;
        this.btnNavNotes.Click += new System.EventHandler(this.btnNavNotes_Click);
        // 
        // btnNavTodo
        // 
        this.btnNavTodo.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnNavTodo.FlatAppearance.BorderSize = 0;
        this.btnNavTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavTodo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnNavTodo.ForeColor = System.Drawing.Color.Gainsboro;
        this.btnNavTodo.Location = new System.Drawing.Point(0, 45);
        this.btnNavTodo.Name = "btnNavTodo";
        this.btnNavTodo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        this.btnNavTodo.Size = new System.Drawing.Size(180, 45);
        this.btnNavTodo.TabIndex = 1;
        this.btnNavTodo.Text = "✅ To-Do";
        this.btnNavTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavTodo.UseVisualStyleBackColor = true;
        this.btnNavTodo.Click += new System.EventHandler(this.btnNavTodo_Click);
        // 
        // lblTitle
        // 
        this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(0, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(180, 45);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "MY APP";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panelContent
        // 
        this.panelContent.Controls.Add(this.chkDarkMode);
        this.panelContent.Controls.Add(this.tabControl1);
        this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panelContent.Location = new System.Drawing.Point(180, 0);
        this.panelContent.Name = "panelContent";
        this.panelContent.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
        this.panelContent.Size = new System.Drawing.Size(620, 500);
        this.panelContent.TabIndex = 1;
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabTodo);
        this.tabControl1.Controls.Add(this.tabNotes);
        this.tabControl1.Controls.Add(this.tabDashboard);
        this.tabControl1.Controls.Add(this.tabExpenses);
        this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl1.Location = new System.Drawing.Point(0, 30);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(620, 470);
        this.tabControl1.TabIndex = 0;
        // 
        // tabTodo
        // 
        this.tabTodo.Controls.Add(this.lblStatus);
        this.tabTodo.Controls.Add(this.btnRemove);
        this.tabTodo.Controls.Add(this.lstTasks);
        this.tabTodo.Controls.Add(this.btnAdd);
        this.tabTodo.Controls.Add(this.txtInput);
        this.tabTodo.Location = new System.Drawing.Point(4, 24);
        this.tabTodo.Name = "tabTodo";
        this.tabTodo.Padding = new System.Windows.Forms.Padding(3);
        this.tabTodo.Size = new System.Drawing.Size(612, 442);
        this.tabTodo.TabIndex = 0;
        this.tabTodo.Text = "To-Do List";
        this.tabTodo.UseVisualStyleBackColor = true;
        // 
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Location = new System.Drawing.Point(20, 410);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(76, 15);
        this.lblStatus.TabIndex = 4;
        this.lblStatus.Text = "Tasks: 0";
        // 
        // btnRemove
        // 
        this.btnRemove.Location = new System.Drawing.Point(490, 60);
        this.btnRemove.Name = "btnRemove";
        this.btnRemove.Size = new System.Drawing.Size(80, 25);
        this.btnRemove.TabIndex = 3;
        this.btnRemove.Text = "Remove";
        this.btnRemove.UseVisualStyleBackColor = true;
        this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
        // 
        // lstTasks
        // 
        this.lstTasks.FormattingEnabled = true;
        this.lstTasks.ItemHeight = 15;
        this.lstTasks.Location = new System.Drawing.Point(20, 60);
        this.lstTasks.Name = "lstTasks";
        this.lstTasks.Size = new System.Drawing.Size(460, 334);
        this.lstTasks.TabIndex = 2;
        // 
        // btnAdd
        // 
        this.btnAdd.Location = new System.Drawing.Point(490, 19);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(80, 25);
        this.btnAdd.TabIndex = 1;
        this.btnAdd.Text = "Add";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        // 
        // txtInput
        // 
        this.txtInput.Location = new System.Drawing.Point(20, 20);
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new System.Drawing.Size(460, 23);
        this.txtInput.TabIndex = 0;
        this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
        // 
        // tabNotes
        // 
        this.tabNotes.Controls.Add(this.btnLoadNote);
        this.tabNotes.Controls.Add(this.btnSaveNote);
        this.tabNotes.Controls.Add(this.rtbNotes);
        this.tabNotes.Location = new System.Drawing.Point(4, 24);
        this.tabNotes.Name = "tabNotes";
        this.tabNotes.Padding = new System.Windows.Forms.Padding(3);
        this.tabNotes.Size = new System.Drawing.Size(612, 442);
        this.tabNotes.TabIndex = 1;
        this.tabNotes.Text = "Notes";
        this.tabNotes.UseVisualStyleBackColor = true;
        // 
        // btnLoadNote
        // 
        this.btnLoadNote.Location = new System.Drawing.Point(100, 380);
        this.btnLoadNote.Name = "btnLoadNote";
        this.btnLoadNote.Size = new System.Drawing.Size(75, 23);
        this.btnLoadNote.TabIndex = 2;
        this.btnLoadNote.Text = "Load";
        this.btnLoadNote.UseVisualStyleBackColor = true;
        this.btnLoadNote.Click += new System.EventHandler(this.btnLoadNote_Click);
        // 
        // btnSaveNote
        // 
        this.btnSaveNote.Location = new System.Drawing.Point(19, 380);
        this.btnSaveNote.Name = "btnSaveNote";
        this.btnSaveNote.Size = new System.Drawing.Size(75, 23);
        this.btnSaveNote.TabIndex = 1;
        this.btnSaveNote.Text = "Save";
        this.btnSaveNote.UseVisualStyleBackColor = true;
        this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
        // 
        // rtbNotes
        // 
        this.rtbNotes.Location = new System.Drawing.Point(19, 17);
        this.rtbNotes.Name = "rtbNotes";
        this.rtbNotes.Size = new System.Drawing.Size(550, 350);
        this.rtbNotes.TabIndex = 0;
        this.rtbNotes.Text = "";
        // 
        // tabDashboard
        // 
        this.tabDashboard.Controls.Add(this.lblQuote);
        this.tabDashboard.Controls.Add(this.grpPomodoro);
        this.tabDashboard.Controls.Add(this.lblRam);
        this.tabDashboard.Controls.Add(this.progRam);
        this.tabDashboard.Controls.Add(this.lblCpu);
        this.tabDashboard.Controls.Add(this.progCpu);
        this.tabDashboard.Controls.Add(this.lblClock);
        this.tabDashboard.Location = new System.Drawing.Point(4, 24);
        this.tabDashboard.Name = "tabDashboard";
        this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
        this.tabDashboard.Size = new System.Drawing.Size(612, 442);
        this.tabDashboard.TabIndex = 2;
        this.tabDashboard.Text = "Dashboard";
        this.tabDashboard.UseVisualStyleBackColor = true;
        // 
        // lblQuote
        // 
        this.lblQuote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
        this.lblQuote.Location = new System.Drawing.Point(30, 360);
        this.lblQuote.Name = "lblQuote";
        this.lblQuote.Size = new System.Drawing.Size(550, 60);
        this.lblQuote.TabIndex = 6;
        this.lblQuote.Text = "\"Believe you can and you're halfway there.\"";
        this.lblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // grpPomodoro
        // 
        this.grpPomodoro.Controls.Add(this.btnPomodoroReset);
        this.grpPomodoro.Controls.Add(this.btnPomodoroAction);
        this.grpPomodoro.Controls.Add(this.lblPomodoroTime);
        this.grpPomodoro.Location = new System.Drawing.Point(30, 20);
        this.grpPomodoro.Name = "grpPomodoro";
        this.grpPomodoro.Size = new System.Drawing.Size(200, 150);
        this.grpPomodoro.TabIndex = 5;
        this.grpPomodoro.TabStop = false;
        this.grpPomodoro.Text = "Pomodoro Timer";
        // 
        // btnPomodoroReset
        // 
        this.btnPomodoroReset.Location = new System.Drawing.Point(105, 110);
        this.btnPomodoroReset.Name = "btnPomodoroReset";
        this.btnPomodoroReset.Size = new System.Drawing.Size(75, 23);
        this.btnPomodoroReset.TabIndex = 2;
        this.btnPomodoroReset.Text = "Reset";
        this.btnPomodoroReset.UseVisualStyleBackColor = true;
        this.btnPomodoroReset.Click += new System.EventHandler(this.btnPomodoroReset_Click);
        // 
        // btnPomodoroAction
        // 
        this.btnPomodoroAction.Location = new System.Drawing.Point(20, 110);
        this.btnPomodoroAction.Name = "btnPomodoroAction";
        this.btnPomodoroAction.Size = new System.Drawing.Size(75, 23);
        this.btnPomodoroAction.TabIndex = 1;
        this.btnPomodoroAction.Text = "Start";
        this.btnPomodoroAction.UseVisualStyleBackColor = true;
        this.btnPomodoroAction.Click += new System.EventHandler(this.btnPomodoroAction_Click);
        // 
        // lblPomodoroTime
        // 
        this.lblPomodoroTime.AutoSize = true;
        this.lblPomodoroTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblPomodoroTime.Location = new System.Drawing.Point(40, 40);
        this.lblPomodoroTime.Name = "lblPomodoroTime";
        this.lblPomodoroTime.Size = new System.Drawing.Size(101, 45);
        this.lblPomodoroTime.TabIndex = 0;
        this.lblPomodoroTime.Text = "25:00";
        // 
        // lblRam
        // 
        this.lblRam.AutoSize = true;
        this.lblRam.Location = new System.Drawing.Point(280, 280);
        this.lblRam.Name = "lblRam";
        this.lblRam.Size = new System.Drawing.Size(81, 15);
        this.lblRam.TabIndex = 4;
        this.lblRam.Text = "RAM Usage: -";
        // 
        // progRam
        // 
        this.progRam.Location = new System.Drawing.Point(280, 298);
        this.progRam.Name = "progRam";
        this.progRam.Size = new System.Drawing.Size(250, 23);
        this.progRam.TabIndex = 3;
        // 
        // lblCpu
        // 
        this.lblCpu.AutoSize = true;
        this.lblCpu.Location = new System.Drawing.Point(280, 225);
        this.lblCpu.Name = "lblCpu";
        this.lblCpu.Size = new System.Drawing.Size(79, 15);
        this.lblCpu.TabIndex = 2;
        this.lblCpu.Text = "CPU Usage: -";
        // 
        // progCpu
        // 
        this.progCpu.Location = new System.Drawing.Point(280, 243);
        this.progCpu.Name = "progCpu";
        this.progCpu.Size = new System.Drawing.Size(250, 23);
        this.progCpu.TabIndex = 1;
        // 
        // lblClock
        // 
        this.lblClock.AutoSize = true;
        this.lblClock.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblClock.Location = new System.Drawing.Point(260, 80);
        this.lblClock.Name = "lblClock";
        this.lblClock.Size = new System.Drawing.Size(291, 86);
        this.lblClock.TabIndex = 0;
        this.lblClock.Text = "00:00:00";
        // 
        // tabExpenses
        // 
        this.tabExpenses.Controls.Add(this.splitContainerExpenses);
        this.tabExpenses.Controls.Add(this.panelExpenseControls);
        this.tabExpenses.Location = new System.Drawing.Point(4, 24);
        this.tabExpenses.Name = "tabExpenses";
        this.tabExpenses.Size = new System.Drawing.Size(612, 442);
        this.tabExpenses.TabIndex = 3;
        this.tabExpenses.Text = "Expenses";
        this.tabExpenses.UseVisualStyleBackColor = true;
        // 
        // splitContainerExpenses
        // 
        this.splitContainerExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
        this.splitContainerExpenses.Location = new System.Drawing.Point(0, 40);
        this.splitContainerExpenses.Name = "splitContainerExpenses";
        // 
        // splitContainerExpenses.Panel1
        // 
        this.splitContainerExpenses.Panel1.Controls.Add(this.dgvExpenses);
        // 
        // splitContainerExpenses.Panel2
        // 
        this.splitContainerExpenses.Panel2.Controls.Add(this.picChart);
        this.splitContainerExpenses.Size = new System.Drawing.Size(612, 402);
        this.splitContainerExpenses.SplitterDistance = 250;
        this.splitContainerExpenses.TabIndex = 1;
        // 
        // dgvExpenses
        // 
        this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvExpenses.Location = new System.Drawing.Point(0, 0);
        this.dgvExpenses.Name = "dgvExpenses";
        this.dgvExpenses.RowTemplate.Height = 25;
        this.dgvExpenses.Size = new System.Drawing.Size(250, 402);
        this.dgvExpenses.TabIndex = 0;
        // 
        // picChart
        // 
        this.picChart.Dock = System.Windows.Forms.DockStyle.Fill;
        this.picChart.BackColor = System.Drawing.Color.White;
        this.picChart.Location = new System.Drawing.Point(0, 0);
        this.picChart.Name = "picChart";
        this.picChart.Size = new System.Drawing.Size(358, 402);
        this.picChart.TabIndex = 0;
        this.picChart.TabStop = false;
        // 
        // panelExpenseControls
        // 
        this.panelExpenseControls.Controls.Add(this.btnGenerateData);
        this.panelExpenseControls.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelExpenseControls.Location = new System.Drawing.Point(0, 0);
        this.panelExpenseControls.Name = "panelExpenseControls";
        this.panelExpenseControls.Size = new System.Drawing.Size(612, 40);
        this.panelExpenseControls.TabIndex = 0;
        // 
        // btnGenerateData
        // 
        this.btnGenerateData.Location = new System.Drawing.Point(8, 8);
        this.btnGenerateData.Name = "btnGenerateData";
        this.btnGenerateData.Size = new System.Drawing.Size(150, 23);
        this.btnGenerateData.TabIndex = 0;
        this.btnGenerateData.Text = "Generate Sample Data";
        this.btnGenerateData.UseVisualStyleBackColor = true;
        this.btnGenerateData.Click += new System.EventHandler(this.btnGenerateData_Click);
        // 
        // timerClock
        // 
        this.timerClock.Interval = 1000;
        this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
        // 
        // chkDarkMode
        // 
        this.chkDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.chkDarkMode.AutoSize = true;
        this.chkDarkMode.BackColor = System.Drawing.Color.Transparent;
        this.chkDarkMode.Location = new System.Drawing.Point(530, 4);
        this.chkDarkMode.Name = "chkDarkMode";
        this.chkDarkMode.Size = new System.Drawing.Size(84, 19);
        this.chkDarkMode.TabIndex = 1;
        this.chkDarkMode.Text = "Dark Mode";
        this.chkDarkMode.UseVisualStyleBackColor = false;
        this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
        // 
        // timerPomodoro
        // 
        this.timerPomodoro.Interval = 1000;
        this.timerPomodoro.Tick += new System.EventHandler(this.timerPomodoro_Tick);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 500);
        this.Controls.Add(this.panelContent);
        this.Controls.Add(this.panelSidebar);
        this.Name = "Form1";
        this.Text = "My Personal Dashboard";
        this.panelSidebar.ResumeLayout(false);
        this.panelContent.ResumeLayout(false);
        this.panelContent.PerformLayout();
        this.tabControl1.ResumeLayout(false);
        this.tabTodo.ResumeLayout(false);
        this.tabTodo.PerformLayout();
        this.tabNotes.ResumeLayout(false);
        this.tabDashboard.ResumeLayout(false);
        this.tabDashboard.PerformLayout();
        this.grpPomodoro.ResumeLayout(false);
        this.grpPomodoro.PerformLayout();
        this.tabExpenses.ResumeLayout(false);
        this.splitContainerExpenses.Panel1.ResumeLayout(false);
        this.splitContainerExpenses.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.splitContainerExpenses)).EndInit();
        this.splitContainerExpenses.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.picChart)).EndInit();
        this.panelExpenseControls.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    private System.Windows.Forms.Panel panelSidebar;
    private System.Windows.Forms.Button btnNavExpenses;
    private System.Windows.Forms.Button btnNavDashboard;
    private System.Windows.Forms.Button btnNavNotes;
    private System.Windows.Forms.Button btnNavTodo;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel panelContent;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabTodo;
    private System.Windows.Forms.TabPage tabNotes;
    private System.Windows.Forms.TabPage tabDashboard;
    private System.Windows.Forms.TabPage tabExpenses;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.ListBox lstTasks;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.RichTextBox rtbNotes;
    private System.Windows.Forms.Button btnLoadNote;
    private System.Windows.Forms.Button btnSaveNote;
    private System.Windows.Forms.Label lblClock;
    private System.Windows.Forms.Timer timerClock;
    private System.Windows.Forms.SplitContainer splitContainerExpenses;
    private System.Windows.Forms.DataGridView dgvExpenses;
    private System.Windows.Forms.PictureBox picChart;
    private System.Windows.Forms.Panel panelExpenseControls;
    private System.Windows.Forms.Button btnGenerateData;
    private System.Windows.Forms.CheckBox chkDarkMode;
    private System.Windows.Forms.Label lblCpu;
    private System.Windows.Forms.ProgressBar progCpu;
    private System.Windows.Forms.Label lblRam;
    private System.Windows.Forms.ProgressBar progRam;
    private System.Windows.Forms.GroupBox grpPomodoro;
    private System.Windows.Forms.Button btnPomodoroReset;
    private System.Windows.Forms.Button btnPomodoroAction;
    private System.Windows.Forms.Label lblPomodoroTime;
    private System.Windows.Forms.Timer timerPomodoro;
    private System.Windows.Forms.Label lblQuote;
}

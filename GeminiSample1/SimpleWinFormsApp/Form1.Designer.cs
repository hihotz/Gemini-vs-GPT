namespace SimpleWinFormsApp;

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
        this.components = new System.ComponentModel.Container();
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
        this.lblClock = new System.Windows.Forms.Label();
        this.tabExpenses = new System.Windows.Forms.TabPage();
        this.splitContainerExpenses = new System.Windows.Forms.SplitContainer();
        this.dgvExpenses = new System.Windows.Forms.DataGridView();
        this.picChart = new System.Windows.Forms.PictureBox();
        this.panelExpenseControls = new System.Windows.Forms.Panel();
        this.btnGenerateData = new System.Windows.Forms.Button();
        this.timerClock = new System.Windows.Forms.Timer(this.components);
        this.tabControl1.SuspendLayout();
        this.tabTodo.SuspendLayout();
        this.tabNotes.SuspendLayout();
        this.tabDashboard.SuspendLayout();
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
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabTodo);
        this.tabControl1.Controls.Add(this.tabNotes);
        this.tabControl1.Controls.Add(this.tabDashboard);
        this.tabControl1.Controls.Add(this.tabExpenses);
        this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl1.Location = new System.Drawing.Point(0, 0);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(600, 400);
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
        this.tabTodo.Size = new System.Drawing.Size(592, 372);
        this.tabTodo.TabIndex = 0;
        this.tabTodo.Text = "To-Do List";
        this.tabTodo.UseVisualStyleBackColor = true;
        // 
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Location = new System.Drawing.Point(20, 345);
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
        this.lstTasks.Size = new System.Drawing.Size(460, 274);
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
        this.tabNotes.Size = new System.Drawing.Size(592, 372);
        this.tabNotes.TabIndex = 1;
        this.tabNotes.Text = "Notes";
        this.tabNotes.UseVisualStyleBackColor = true;
        // 
        // btnLoadNote
        // 
        this.btnLoadNote.Location = new System.Drawing.Point(100, 330);
        this.btnLoadNote.Name = "btnLoadNote";
        this.btnLoadNote.Size = new System.Drawing.Size(75, 23);
        this.btnLoadNote.TabIndex = 2;
        this.btnLoadNote.Text = "Load";
        this.btnLoadNote.UseVisualStyleBackColor = true;
        this.btnLoadNote.Click += new System.EventHandler(this.btnLoadNote_Click);
        // 
        // btnSaveNote
        // 
        this.btnSaveNote.Location = new System.Drawing.Point(19, 330);
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
        this.rtbNotes.Size = new System.Drawing.Size(550, 300);
        this.rtbNotes.TabIndex = 0;
        this.rtbNotes.Text = "";
        // 
        // tabDashboard
        // 
        this.tabDashboard.Controls.Add(this.lblClock);
        this.tabDashboard.Location = new System.Drawing.Point(4, 24);
        this.tabDashboard.Name = "tabDashboard";
        this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
        this.tabDashboard.Size = new System.Drawing.Size(592, 372);
        this.tabDashboard.TabIndex = 2;
        this.tabDashboard.Text = "Dashboard";
        this.tabDashboard.UseVisualStyleBackColor = true;
        // 
        // lblClock
        // 
        this.lblClock.AutoSize = true;
        this.lblClock.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblClock.Location = new System.Drawing.Point(150, 120);
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
        this.tabExpenses.Size = new System.Drawing.Size(592, 372);
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
        this.splitContainerExpenses.Size = new System.Drawing.Size(592, 332);
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
        this.dgvExpenses.Size = new System.Drawing.Size(250, 332);
        this.dgvExpenses.TabIndex = 0;
        // 
        // picChart
        // 
        this.picChart.Dock = System.Windows.Forms.DockStyle.Fill;
        this.picChart.BackColor = System.Drawing.Color.White;
        this.picChart.Location = new System.Drawing.Point(0, 0);
        this.picChart.Name = "picChart";
        this.picChart.Size = new System.Drawing.Size(338, 332);
        this.picChart.TabIndex = 0;
        this.picChart.TabStop = false;
        // 
        // panelExpenseControls
        // 
        this.panelExpenseControls.Controls.Add(this.btnGenerateData);
        this.panelExpenseControls.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelExpenseControls.Location = new System.Drawing.Point(0, 0);
        this.panelExpenseControls.Name = "panelExpenseControls";
        this.panelExpenseControls.Size = new System.Drawing.Size(592, 40);
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
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(600, 400);
        this.Controls.Add(this.tabControl1);
        this.Name = "Form1";
        this.Text = "My Personal Dashboard";
        this.tabControl1.ResumeLayout(false);
        this.tabTodo.ResumeLayout(false);
        this.tabTodo.PerformLayout();
        this.tabNotes.ResumeLayout(false);
        this.tabDashboard.ResumeLayout(false);
        this.tabDashboard.PerformLayout();
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

    #endregion

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
}

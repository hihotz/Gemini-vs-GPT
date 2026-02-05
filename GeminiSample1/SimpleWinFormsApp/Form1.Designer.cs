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
        this.txtInput = new System.Windows.Forms.TextBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.lstTasks = new System.Windows.Forms.ListBox();
        this.btnRemove = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // txtInput
        // 
        this.txtInput.Location = new System.Drawing.Point(20, 20);
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new System.Drawing.Size(460, 23);
        this.txtInput.TabIndex = 0;
        this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
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
        // lstTasks
        // 
        this.lstTasks.FormattingEnabled = true;
        this.lstTasks.ItemHeight = 15;
        this.lstTasks.Location = new System.Drawing.Point(20, 60);
        this.lstTasks.Name = "lstTasks";
        this.lstTasks.Size = new System.Drawing.Size(460, 289);
        this.lstTasks.TabIndex = 2;
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
        // lblStatus
        // 
        this.lblStatus.AutoSize = true;
        this.lblStatus.Location = new System.Drawing.Point(20, 360);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(76, 15);
        this.lblStatus.TabIndex = 4;
        this.lblStatus.Text = "Tasks: 0";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(600, 400);
        this.Controls.Add(this.lblStatus);
        this.Controls.Add(this.btnRemove);
        this.Controls.Add(this.lstTasks);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.txtInput);
        this.Name = "Form1";
        this.Text = "My To-Do List";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.ListBox lstTasks;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Label lblStatus;
}

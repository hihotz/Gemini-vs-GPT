using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace SimpleWinFormsApp;

public partial class Form1 : Form
{
    private DataTable expensesTable;
    private PerformanceCounter cpuCounter;
    private PerformanceCounter ramCounter;
    
    // Pomodoro State
    private int pomodoroTimeLeft = 25 * 60; // 25 minutes in seconds
    private bool isPomodoroRunning = false;

    // Quotes
    private string[] quotes = {
        "\"Believe you can and you're halfway there.\"",
        "\"The only way to do great work is to love what you do.\"",
        "\"Success is not final, failure is not fatal: it is the courage to continue that counts.\"",
        "\"Act as if what you do makes a difference. It does.\"",
        "\"Dream big and dare to fail.\""
    };

    public Form1()
    {
        InitializeComponent();
        InitializeExpenseData();
        InitializeSystemMonitors();
        
        LoadExpenses(); // Load persistence data
        ApplyTheme(chkDarkMode.Checked); // Apply initial theme
        UpdateStatus();
        timerClock.Start();
        
        // Hide Tabs Headers
        tabControl1.Appearance = TabAppearance.FlatButtons;
        tabControl1.ItemSize = new Size(0, 1);
        tabControl1.SizeMode = TabSizeMode.Fixed;
        
        // Random Quote
        lblQuote.Text = quotes[new Random().Next(quotes.Length)];
        
        // Default Tab
        SwitchTab(tabDashboard, btnNavDashboard);
    }

    // ... Existing Initialize code ...
    private void InitializeSystemMonitors()
    {
        try
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        }
        catch { /* Fallback or ignore for user mode */ }
    }

    private void InitializeExpenseData()
    {
        expensesTable = new DataTable();
        expensesTable.Columns.Add("Date", typeof(DateTime));
        expensesTable.Columns.Add("Category", typeof(string));
        expensesTable.Columns.Add("Description", typeof(string));
        expensesTable.Columns.Add("Amount", typeof(decimal));

        dgvExpenses.DataSource = expensesTable;
        dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    // Navigation Logic
    private void btnNavDashboard_Click(object sender, EventArgs e) => SwitchTab(tabDashboard, btnNavDashboard);
    private void btnNavTodo_Click(object sender, EventArgs e) => SwitchTab(tabTodo, btnNavTodo);
    private void btnNavNotes_Click(object sender, EventArgs e) => SwitchTab(tabNotes, btnNavNotes);
    private void btnNavExpenses_Click(object sender, EventArgs e) => SwitchTab(tabExpenses, btnNavExpenses);

    private void SwitchTab(TabPage tab, Button navButton)
    {
        tabControl1.SelectedTab = tab;
        
        // Reset Sidebar Buttons Style
        Color baseColor = Color.FromArgb(45, 45, 48); // Sidebar color
        btnNavDashboard.BackColor = baseColor;
        btnNavTodo.BackColor = baseColor;
        btnNavNotes.BackColor = baseColor;
        btnNavExpenses.BackColor = baseColor;

        // Highlight Active
        navButton.BackColor = Color.FromArgb(62, 62, 66); // Lighter gray for active
    }

    // Pomodoro Logic
    private void btnPomodoroAction_Click(object sender, EventArgs e)
    {
        if (isPomodoroRunning)
        {
            timerPomodoro.Stop();
            btnPomodoroAction.Text = "Start";
            isPomodoroRunning = false;
        }
        else
        {
            timerPomodoro.Start();
            btnPomodoroAction.Text = "Pause";
            isPomodoroRunning = true;
        }
    }

    private void btnPomodoroReset_Click(object sender, EventArgs e)
    {
        timerPomodoro.Stop();
        isPomodoroRunning = false;
        btnPomodoroAction.Text = "Start";
        pomodoroTimeLeft = 25 * 60;
        UpdatePomodoroDisplay();
    }

    private void timerPomodoro_Tick(object sender, EventArgs e)
    {
        if (pomodoroTimeLeft > 0)
        {
            pomodoroTimeLeft--;
            UpdatePomodoroDisplay();
        }
        else
        {
            timerPomodoro.Stop();
            isPomodoroRunning = false;
            btnPomodoroAction.Text = "Start";
            System.Media.SystemSounds.Beep.Play();
            MessageBox.Show("Time's up! Take a break.", "Pomodoro");
        }
    }

    private void UpdatePomodoroDisplay()
    {
        TimeSpan t = TimeSpan.FromSeconds(pomodoroTimeLeft);
        lblPomodoroTime.Text = t.ToString(@"mm\:ss");
    }

    // Theme Logic
    private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
    {
        ApplyTheme(chkDarkMode.Checked);
    }

    private void ApplyTheme(bool isDark)
    {
        Color backColor = isDark ? Color.FromArgb(30, 30, 30) : Color.FromArgb(240, 240, 240);
        Color foreColor = isDark ? Color.White : Color.Black;
        Color controlBack = isDark ? Color.FromArgb(50, 50, 50) : Color.White;
        
        // Sidebar stays dark usually, or we can theme it too. Let's keep sidebar dark specific.
        // panelContent.BackColor = backColor;

        this.BackColor = backColor;
        this.ForeColor = foreColor;
        chkDarkMode.ForeColor = foreColor;

        tabControl1.Parent.BackColor = backColor; // Ensure container is colored

        foreach (TabPage page in tabControl1.TabPages)
        {
            page.BackColor = backColor; // Tab background matches form
            page.ForeColor = foreColor;
            
            // Recurse for controls
            foreach(Control c in page.Controls)
            {
                ApplyThemeToControl(c, backColor, foreColor, controlBack);
            }
        }
    }

    private void ApplyThemeToControl(Control c, Color back, Color fore, Color controlBack)
    {
        if (c is Button btn)
        {
            // Don't style Sidebar buttons here, they are handled separately or manually styled
            if (!c.Name.StartsWith("btnNav")) 
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = isPomodoroButton(btn) ? (chkDarkMode.Checked ? Color.FromArgb(70,70,70) : Color.LightGray) : Color.FromArgb(0, 122, 204);
                btn.ForeColor = isPomodoroButton(btn) ? fore : Color.White;
                btn.FlatAppearance.BorderSize = 0;
            }
        }
        else if (c is TextBox || c is ListBox || c is RichTextBox)
        {
            c.BackColor = controlBack;
            c.ForeColor = fore;
        }
        else if (c is DataGridView dgv)
        {
            dgv.BackgroundColor = controlBack;
            dgv.DefaultCellStyle.BackColor = controlBack;
            dgv.DefaultCellStyle.ForeColor = fore;
            dgv.GridColor = fore;
        }
        else if (c is Panel p) { 
             p.BackColor = Color.Transparent; 
             foreach(Control child in p.Controls) ApplyThemeToControl(child, back, fore, controlBack);
        }
        else if (c is GroupBox g) {
            g.ForeColor = fore;
            foreach(Control child in g.Controls) ApplyThemeToControl(child, back, fore, controlBack);
        }
        else if (c is SplitContainer s) {
             ApplyThemeToControl(s.Panel1, back, fore, controlBack);
             ApplyThemeToControl(s.Panel2, back, fore, controlBack);
        }
        
        if (c == picChart)
        {
           c.BackColor = controlBack;
           DrawChart();
        }
    }
    
    private bool isPomodoroButton(Button b) => b.Name == "btnPomodoroAction" || b.Name == "btnPomodoroReset";

    // ... Event Handlers & Previous Logic ...

    private void timerClock_Tick(object sender, EventArgs e)
    {
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        if (cpuCounter != null && ramCounter != null)
        {
            try {
                progCpu.Value = (int)Math.Clamp(cpuCounter.NextValue(), 0, 100);
                progRam.Value = (int)Math.Clamp(ramCounter.NextValue(), 0, 100);
                lblCpu.Text = $"CPU: {progCpu.Value}%";
                lblRam.Text = $"RAM: {progRam.Value}%";
            } catch {}
        }
    }
    
    // Persistence
    private void SaveExpenses()
    {
        if (expensesTable == null) return;
        try
        {
            var data = expensesTable.AsEnumerable().Select(r => new {
                Date = r.Field<DateTime>("Date"),
                Category = r.Field<string>("Category"),
                Description = r.Field<string>("Description"),
                Amount = r.Field<decimal>("Amount")
            }).ToList();
            File.WriteAllText("expenses.json", JsonSerializer.Serialize(data));
        }
        catch {}
    }

    private void LoadExpenses()
    {
        if (File.Exists("expenses.json"))
        {
            try {
                using (JsonDocument doc = JsonDocument.Parse(File.ReadAllText("expenses.json")))
                {
                    expensesTable.Rows.Clear();
                    foreach (var el in doc.RootElement.EnumerateArray()) {
                        expensesTable.Rows.Add(
                            el.GetProperty("Date").GetDateTime(),
                            el.GetProperty("Category").GetString(),
                            el.GetProperty("Description").GetString(),
                            el.GetProperty("Amount").GetDecimal()
                        );
                    }
                }
                DrawChart();
            } catch {}
        }
    }
    protected override void OnFormClosing(FormClosingEventArgs e) { base.OnFormClosing(e); SaveExpenses(); }

    private void btnAdd_Click(object sender, EventArgs e) => AddTask();
    private void txtInput_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) { AddTask(); e.Handled = true; e.SuppressKeyPress = true; } }
    private void AddTask() { if(!string.IsNullOrWhiteSpace(txtInput.Text)) { lstTasks.Items.Add(txtInput.Text); txtInput.Clear(); txtInput.Focus(); UpdateStatus(); } }
    private void btnRemove_Click(object sender, EventArgs e) { if(lstTasks.SelectedIndex != -1) { lstTasks.Items.RemoveAt(lstTasks.SelectedIndex); UpdateStatus(); } }
    private void UpdateStatus() => lblStatus.Text = $"Tasks: {lstTasks.Items.Count}";
    private void btnSaveNote_Click(object sender, EventArgs e) { File.WriteAllText("notes.txt", rtbNotes.Text); MessageBox.Show("Saved!"); }
    private void btnLoadNote_Click(object sender, EventArgs e) { if(File.Exists("notes.txt")) rtbNotes.Text = File.ReadAllText("notes.txt"); }
    private void btnGenerateData_Click(object sender, EventArgs e) { GenerateSampleData(); DrawChart(); }
    
    private void GenerateSampleData()
    {
        expensesTable.Rows.Clear();
        Random rnd = new Random();
        string[] cats = { "Food", "Transport", "Utilities", "Entertainment", "Shopping" };
        for (int i = 0; i < 15; i++) expensesTable.Rows.Add(DateTime.Now.AddDays(-rnd.Next(30)), cats[rnd.Next(cats.Length)], "Item", rnd.Next(10, 100));
    }

    private void DrawChart()
    {
        if (picChart.Width <= 0 || picChart.Height <= 0) return;
        Bitmap bmp = new Bitmap(picChart.Width, picChart.Height);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.Clear(chkDarkMode.Checked ? Color.FromArgb(50,50,50) : Color.White);
            var q = expensesTable.AsEnumerable().GroupBy(r => r.Field<string>("Category"))
                .Select(g => new { C = g.Key, T = g.Sum(r => r.Field<decimal>("Amount")) }).ToList();
            if (q.Count > 0)
            {
                decimal max = q.Max(x => x.T);
                if(max==0) max=1;
                int w = (picChart.Width - 40) / q.Count;
                int x = 20;
                foreach(var item in q) {
                    int h = (int)((item.T / max) * (picChart.Height - 50));
                    g.FillRectangle(new SolidBrush(GetColorForCategory(item.C)), x, picChart.Height - h - 20, w - 10, h);
                    g.DrawString(item.C, new Font("Segoe UI", 8), chkDarkMode.Checked?Brushes.White:Brushes.Black, x, picChart.Height - 18);
                    x += w;
                }
            }
        }
        picChart.Image = bmp;
    }
    
    private Color GetColorForCategory(string c) => c switch { "Food" => Color.Tomato, "Transport" => Color.CornflowerBlue, "Utilities"=>Color.Orange, "Entertainment"=>Color.MediumPurple, _=>Color.SeaGreen };
}

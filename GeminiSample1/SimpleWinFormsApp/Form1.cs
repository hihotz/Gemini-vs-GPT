using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SimpleWinFormsApp;

public partial class Form1 : Form
{
    private DataTable expensesTable;

    public Form1()
    {
        InitializeComponent();
        InitializeExpenseData();
        ApplyModernStyle();
        UpdateStatus();
        timerClock.Start();
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

    private void ApplyModernStyle()
    {
        // General Form Style
        this.BackColor = Color.FromArgb(240, 240, 240);
        this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

        // TabControl Style
        // tabControl1.Appearance = TabAppearance.FlatButtons; 
        // tabControl1.ItemSize = new Size(0, 1); 
        // tabControl1.SizeMode = TabSizeMode.Fixed;
        
        // Create a custom menu strip or buttons to act as tabs if we really wanted to hide headers, 
        // but for now let's just style the tabs differently or leave them default OS style for simplicity 
        // as custom tab drawing is verbose. 
        // Instead, let's style the content areas.

        // Style Buttons
        foreach (Control c in this.Controls)
        {
            StyleControls(c);
        }
    }

    private void StyleControls(Control c)
    {
        if (c is Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.FromArgb(0, 122, 204);
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }
        else if (c is TabControl tc)
        {
             foreach (TabPage page in tc.TabPages)
             {
                 page.BackColor = Color.White;
                 foreach(Control child in page.Controls)
                 {
                     StyleControls(child);
                 }
             }
        }
        else if (c is Panel p)
        {
             foreach (Control child in p.Controls)
             {
                 StyleControls(child);
             }
        }
        else if (c is SplitContainer sc)
        {
            StyleControls(sc.Panel1);
            StyleControls(sc.Panel2);
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        AddTask();
    }

    private void txtInput_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            AddTask();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }

    private void AddTask()
    {
        if (!string.IsNullOrWhiteSpace(txtInput.Text))
        {
            lstTasks.Items.Add(txtInput.Text);
            txtInput.Clear();
            txtInput.Focus();
            UpdateStatus();
        }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        if (lstTasks.SelectedIndex != -1)
        {
            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
            UpdateStatus();
        }
        else
        {
            MessageBox.Show("Please select an item to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void UpdateStatus()
    {
        lblStatus.Text = $"Tasks: {lstTasks.Items.Count}";
    }

    private void timerClock_Tick(object sender, EventArgs e)
    {
        lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        // Center the clock
        if(lblClock.Parent != null)
        {
            lblClock.Location = new Point(
                (lblClock.Parent.Width - lblClock.Width) / 2,
                (lblClock.Parent.Height - lblClock.Height) / 2);
        }
    }

    private void btnSaveNote_Click(object sender, EventArgs e)
    {
        try
        {
            File.WriteAllText("notes.txt", rtbNotes.Text);
            MessageBox.Show("Note saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLoadNote_Click(object sender, EventArgs e)
    {
        try
        {
            if (File.Exists("notes.txt"))
            {
                rtbNotes.Text = File.ReadAllText("notes.txt");
            }
            else
            {
                MessageBox.Show("No saved note found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnGenerateData_Click(object sender, EventArgs e)
    {
        GenerateSampleData();
        DrawChart();
    }

    private void GenerateSampleData()
    {
        expensesTable.Rows.Clear();
        Random rnd = new Random();
        string[] categories = { "Food", "Transport", "Utilities", "Entertainment", "Shopping" };

        for (int i = 0; i < 15; i++)
        {
            var row = expensesTable.NewRow();
            row["Date"] = DateTime.Now.AddDays(-rnd.Next(1, 30));
            row["Category"] = categories[rnd.Next(categories.Length)];
            row["Description"] = $"Item {i + 1}";
            row["Amount"] = rnd.Next(10, 100);
            expensesTable.Rows.Add(row);
        }
    }

    private void DrawChart()
    {
        if (picChart.Width <= 0 || picChart.Height <= 0) return;

        Bitmap bmp = new Bitmap(picChart.Width, picChart.Height);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Group data by category
            var query = expensesTable.AsEnumerable()
                .GroupBy(r => r.Field<string>("Category"))
                .Select(g => new { Category = g.Key, Total = g.Sum(r => r.Field<decimal>("Amount")) })
                .ToList();

            if (query.Count == 0) return;

            decimal maxVal = query.Max(x => x.Total);
            int barWidth = (picChart.Width - 40) / query.Count; // Simple width calc
            int maxHeight = picChart.Height - 50;
            int x = 20;

            Font font = new Font("Segoe UI", 8);
            Brush textBrush = Brushes.Black;

            foreach (var item in query)
            {
                int barHeight = (int)((item.Total / maxVal) * maxHeight);
                Rectangle barRect = new Rectangle(x, picChart.Height - barHeight - 20, barWidth - 10, barHeight);
                
                // Draw bar
                g.FillRectangle(new SolidBrush(GetColorForCategory(item.Category)), barRect);
                g.DrawRectangle(Pens.Gray, barRect);

                // Draw label
                g.DrawString(item.Category, font, textBrush, x, picChart.Height - 18);
                g.DrawString($"${item.Total}", font, textBrush, x, picChart.Height - barHeight - 35);

                x += barWidth;
            }
        }

        picChart.Image = bmp;
    }

    private Color GetColorForCategory(string category)
    {
        switch (category)
        {
            case "Food": return Color.Tomato;
            case "Transport": return Color.CornflowerBlue;
            case "Utilities": return Color.Orange;
            case "Entertainment": return Color.MediumPurple;
            case "Shopping": return Color.SeaGreen;
            default: return Color.Gray;
        }
    }
}

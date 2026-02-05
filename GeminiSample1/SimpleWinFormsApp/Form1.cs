namespace SimpleWinFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        UpdateStatus();
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
            e.SuppressKeyPress = true; // Stop 'ding' sound
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
}

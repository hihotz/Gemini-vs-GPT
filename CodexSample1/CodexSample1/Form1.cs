namespace CodexSample1;

public partial class Form1 : Form
{
    private const string DonePrefix = "[완료] ";

    public Form1()
    {
        InitializeComponent();
        UpdateStats();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        AddTaskFromInput();
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

    private void listTasks_DoubleClick(object sender, EventArgs e)
    {
        ToggleSelectedTask();
    }

    private void AddTaskFromInput()
    {
        var text = textTask.Text.Trim();
        if (text.Length == 0)
        {
            textTask.Focus();
            return;
        }

        listTasks.Items.Add(text);
        textTask.Clear();
        textTask.Focus();
        UpdateStats();
    }

    private void ToggleSelectedTask()
    {
        var index = listTasks.SelectedIndex;
        if (index < 0)
        {
            return;
        }

        var current = listTasks.Items[index]?.ToString() ?? string.Empty;
        if (current.StartsWith(DonePrefix, StringComparison.Ordinal))
        {
            listTasks.Items[index] = current.Substring(DonePrefix.Length);
        }
        else
        {
            listTasks.Items[index] = DonePrefix + current;
        }

        UpdateStats();
    }

    private void RemoveSelectedTask()
    {
        var index = listTasks.SelectedIndex;
        if (index < 0)
        {
            return;
        }

        listTasks.Items.RemoveAt(index);
        UpdateStats();
    }

    private void ClearDoneTasks()
    {
        for (var i = listTasks.Items.Count - 1; i >= 0; i--)
        {
            var current = listTasks.Items[i]?.ToString() ?? string.Empty;
            if (current.StartsWith(DonePrefix, StringComparison.Ordinal))
            {
                listTasks.Items.RemoveAt(i);
            }
        }

        UpdateStats();
    }

    private void UpdateStats()
    {
        var total = listTasks.Items.Count;
        var done = 0;

        foreach (var item in listTasks.Items)
        {
            var current = item?.ToString() ?? string.Empty;
            if (current.StartsWith(DonePrefix, StringComparison.Ordinal))
            {
                done++;
            }
        }

        labelStats.Text = $"총 {total}개, 완료 {done}개";
    }
}

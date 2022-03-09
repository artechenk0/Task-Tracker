using System;
using System.Windows.Forms;

namespace Tracker2000
{
    public partial class UserInterface : UserControl
    {
        public UserInterface() => InitializeComponent();

        private void ButtonAppend(object sender, EventArgs e)
        {
            if (TaskInput.Text != "")           
                TaskOutput.Items.Add(TaskInput.Text);
            TaskInput.Text = null;
        }
        private void ButtonDelete(object sender, EventArgs e) => TaskOutput.Items.Remove(TaskOutput.SelectedItem);
    }
}

// Project Name: TimerApp
// Purpose: Basic timer/stopwatch program that showcases knowledge of real-time time tracking
// File Name: StopwatchUI.cs
// Description: Defines the stopwatchForm class, which will be responsible for the user interface of the stopwatch timer,
//              allowing users to start/stop the stopwatch and view the elapsed time
// Programmer: Cody Eckard
// Creation Date: May 18, 2026
// GitHub Repository: https://github.com/Nubbie16/TimerApp

namespace TimerApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            this.Text = tabControl.SelectedTab.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

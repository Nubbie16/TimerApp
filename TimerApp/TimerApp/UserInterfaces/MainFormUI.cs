// Project Name: TimerApp
// Purpose: Basic timer/stopwatch program that showcases knowledge of real-time time tracking
// File Name: StopwatchUI.cs
// Description: Defines the stopwatchForm class, which will be responsible for the user interface of the stopwatch timer,
//              allowing users to start/stop the stopwatch and view the elapsed time
// Programmer: Cody Eckard
// Creation Date: May 18, 2026
// GitHub Repository: https://github.com/Nubbie16/TimerApp

using System.Diagnostics;
using TimerApp.Models;

namespace TimerApp
{
    public partial class mainForm : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        int lapCount = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            this.Text = tabControl.SelectedTab.Text;
        }

        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            timeTableGV.Rows[lapCount].Cells["lapEndCol"].Value = stopwatch.
                Elapsed.ToString(@"hh\:mm\:ss");
        }

        private void startStopwatchBtn_Click(object sender, EventArgs e)
        {

            if (stopwatch.IsRunning != true && stopwatch.ElapsedTicks <= 0)
            {
                startStopwatchBtn.Text = "&Lap";
                stopwatch.Start();
                stopwatchTimer.Start();
                timeTableGV.Visible = true;
                ShowNewLap();
            } else if (stopwatch.IsRunning != true) 
            {
                stopwatch.Start();
                stopwatchTimer.Start();
            } else {
                lapCount += 1;
                ShowNewLap();
            }
        }

        private void stopStopwatchBtn_Click(object sender, EventArgs e)
        {
            startStopwatchBtn.Text = "Res&ume";
            stopwatch.Stop();
            stopwatchTimer.Stop();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            startStopwatchBtn.Text = "&Start";
            timeTableGV.Visible = false;
            stopwatch.Reset();
            stopwatchTimer.Stop();
            timeTableGV.Rows.Clear();
            lapCount = 0;
        }

        private void ShowNewLap()
        {
            timeTableGV.Rows.Add(
                lapCount + 1, 
                stopwatch.Elapsed.ToString(@"hh\:mm\:ss"),
                stopwatch.Elapsed.ToString(@"hh\:mm\:ss")
                );
        }

    }
}

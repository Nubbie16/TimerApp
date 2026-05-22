// Project Name: TimerApp
// Purpose: Basic timer/stopwatch program that showcases knowledge of real-time time tracking
// File Name: StopwatchUI.cs
// Description: Defines the stopwatchForm class, which will be responsible for the user interface of the stopwatch timer,
//              allowing users to start/stop the stopwatch and view the elapsed time
// Programmer: Cody Eckard
// Creation Date: May 18, 2026
// GitHub Repository: https://github.com/Nubbie16/TimerApp

using System.Diagnostics;
using System.Media;
using System.DirectoryServices.ActiveDirectory;
using System.Threading.Tasks;

namespace TimerApp
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            this.Text = tabControl.SelectedTab.Text;
        }

        ////Stopwatch Tab Logic////

        private Stopwatch stopwatch = new Stopwatch();
        private int lapCount = 0;

        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            timeTableGV.Rows[lapCount].Cells["lapEndCol"].Value = stopwatch.
                    Elapsed.ToString(@"hh\:mm\:ss");
            currentStopwatchLbl.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }

        private void startStopwatchBtn_Click(object sender, EventArgs e)
        {

            if (stopwatch.IsRunning != true && stopwatch.ElapsedTicks <= 0)     //new stopwatch started
            {
                startStopwatchBtn.Text = "&Lap";
                stopwatch.Start();
                stopwatchTimer.Start();
                timeTableGV.Visible = true;
                ShowNewLap();

            }
            else if (stopwatch.IsRunning != true)                             //if stopwatch was "stopped" and sstarted back
            {
                stopwatch.Start();
                stopwatchTimer.Start();
                startStopwatchBtn.Text = "&Lap";

            }
            else
            {                                                            //if user wanted to set a lap time
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
            currentStopwatchLbl.Text = "00:00:00";
        }

        private void ShowNewLap()
        {
            int rowIndex = timeTableGV.Rows.Add(
                                    lapCount + 1,
                                    stopwatch.Elapsed.ToString(@"hh\:mm\:ss"),
                                    stopwatch.Elapsed.ToString(@"hh\:mm\:ss")
                                    );

            timeTableGV.ClearSelection();
            timeTableGV.Rows[rowIndex].Selected = true;
            timeTableGV.FirstDisplayedScrollingRowIndex = rowIndex;         //Scrolls to current lap time
        }


        ////Countdown Tab Logic////

        Stopwatch countdown = new Stopwatch();
        TimeSpan countdownTime = TimeSpan.Zero;
        bool isMessageBoxShowing = false;
        CancellationTokenSource beepTokenSource;

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = countdownTime - countdown.Elapsed;
            remainingCountLbl.Text = remainingTime.ToString(@"hh\:mm\:ss\.ff");

            if (remainingTime <= TimeSpan.Zero)
            {
                countdown.Stop();
                countdownTimer.Stop();

                remainingCountLbl.Text = "00:00:00";

                ShowCountdownMessage();

            }
        }

        private void startCountdownBtn_Click(object sender, EventArgs e)
        {
            hourUD.Enabled = false;
            minuteUD.Enabled = false;
            secondUD.Enabled = false;

            if (countdown.ElapsedTicks > 0)
            {
                startCountdownBtn.Text = "&Start";
                countdown.Start();
                countdownTimer.Start();

            } else {
                int selectedHours = ((int)hourUD.Value * 60) * 60;     //Selected hours converted to seconds
            int selectedMinutes = (int)minuteUD.Value * 60;        //Selected minutes converted to seconds
            int selectedSeconds = (int)secondUD.Value;             //Selected secounds

            int selectedTimeInSec = selectedHours + selectedMinutes + selectedSeconds;      //Total selected time in seconds  

            countdownTime = TimeSpan.FromSeconds(selectedTimeInSec);

            countdown.Reset();
            countdown.Start();
            countdownTimer.Start();

            remainingCountLbl.Text = countdownTime.ToString(@"hh\:mm\:ss");
            }

        }

        private void ShowCountdownMessage()     //system makes repeated sound until messageBox is acknowledged
        {
            if (isMessageBoxShowing)
            {
                return;

            }

            isMessageBoxShowing = true;
            beepTokenSource = new CancellationTokenSource();
            Task.Run(() =>
            {
                while (!beepTokenSource.Token.IsCancellationRequested)
                {
                    Console.Beep(1500, 500);
                    Thread.Sleep(500);
                    Console.Beep(1000, 500);
                    Thread.Sleep(500);
                    Console.Beep(2000, 500);
                    Thread.Sleep(500);
                }
            });
            MessageBox.Show("Time is up!", "Countdown");

            beepTokenSource.Cancel();
            isMessageBoxShowing = false;
        }

        private void pauseCountdownBtn_Click(object sender, EventArgs e)
        {
            countdown.Stop();
            countdownTimer.Stop();
            startCountdownBtn.Text = "&Resume";
        }
    }
}

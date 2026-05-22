// Project Name: TimerApp
// Purpose: Basic Stopwatch/Countdown program that showcases knowledge of real-time time tracking
// File Name: MainFormUI.cs
// Description: Windows Forms timer application that provides stopwatch and countdown features, including lap tracking,
//              time selection, pause/resume controls, and an alert when the countdown reaches zero.
// Programmer: Cody Eckard
// Creation Date: May 18, 2026
// GitHub Repository: https://github.com/Nubbie16/TimerApp

using System.Diagnostics;
using System.Media;

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

            } else {                                                            //if user wanted to set a lap time
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
            currentStopwatchLbl.Text = "00:00:00.00";
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

                remainingCountLbl.Text = "00:00:00.00";

                if (rickRollingCB.Checked)
                {
                    RickRolled();

                } else {
                    ShowCountdownMessage();
                }
            }
        }

        private void startCountdownBtn_Click(object sender, EventArgs e)
        {
            if (countdown.ElapsedTicks > 0)
            {
                hourUD.Enabled = false;
                minuteUD.Enabled = false;
                secondUD.Enabled = false;

                startCountdownBtn.Text = "&Start";
                countdown.Start();
                countdownTimer.Start();

            } else {

                int selectedHours = ((int)hourUD.Value * 60) * 60;     //Selected hours converted to seconds
                int selectedMinutes = (int)minuteUD.Value * 60;        //Selected minutes converted to seconds
                int selectedSeconds = (int)secondUD.Value;             //Selected secounds

                int selectedTimeInSec = selectedHours + selectedMinutes + selectedSeconds;      //Total selected time in seconds  

                if (selectedTimeInSec == 0)
                {
                    MessageBox.Show("Select time greater than 0.", "Countdown");

                    hourUD.Enabled = true;
                    minuteUD.Enabled = true;
                    secondUD.Enabled = true;

                    return;
                } else {

                    hourUD.Enabled = false;
                    minuteUD.Enabled = false;
                    secondUD.Enabled = false;

                    countdownTime = TimeSpan.FromSeconds(selectedTimeInSec);

                    countdown.Reset();
                    countdown.Start();
                    countdownTimer.Start();

                    remainingCountLbl.Text = countdownTime.ToString(@"hh\:mm\:ss");
                }
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

            hourUD.Enabled = true;
            minuteUD.Enabled = true;
            secondUD.Enabled = true;
        }

        private void pauseCountdownBtn_Click(object sender, EventArgs e)
        {
            countdown.Stop();
            countdownTimer.Stop();
            if(countdown.ElapsedTicks <= 0)
            {
                return;

            } else {
                startCountdownBtn.Text = "&Resume";
            }
        }

        private void cancelCountdownBtn_Click(object sender, EventArgs e)
        {
            countdown.Reset();
            countdownTimer.Enabled = false;
            startCountdownBtn.Text = "&Start";
            remainingCountLbl.Text = "00:00:00.00";

            hourUD.Enabled = true;
            minuteUD.Enabled = true;
            secondUD.Enabled = true;
            hourUD.Value = 0;
            minuteUD.Value = 0;
            secondUD.Value = 0;
        }

        private SoundPlayer alarmPlayer;

        private void RickRolled()
        {
            if (isMessageBoxShowing)
            {
                return;
            }

            isMessageBoxShowing = true;

            string soundPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Assets",
                "Sounds",
                "RickRolled.wav"
            );

            alarmPlayer = new SoundPlayer(soundPath);
            alarmPlayer.PlayLooping();

            MessageBox.Show("Time is up!", "Countdown");
            MessageBox.Show("Not yet, click again.", "Countdown");
            MessageBox.Show("You thought that was it?", "Countdown");
            MessageBox.Show("Nope. Still going.", "Countdown");
            MessageBox.Show("You have been timer-rolled.", "Countdown");
            MessageBox.Show("Just kidding, you gotta terminate the program yourself!", "Countdown");

            isMessageBoxShowing = false;
        }
    }
}

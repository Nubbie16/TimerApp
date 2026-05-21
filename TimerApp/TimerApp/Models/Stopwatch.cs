// Project Name: TimerApp
// Purpose: Basic timer/stopwatch program that showcases knowledge of real-time time tracking
// File Name: Stopwatch.cs
// Description: Defines the Stopwatch class, which will store the necessary properties and methods for a stopwatch timer, such as start time, elapsed time
// Programmer: Cody Eckard
// Creation Date: May 18, 2026
// GitHub Repository: https://github.com/Nubbie16/TimerApp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerApp.Models
{
    public class Stopwatch
    {
        public int laps = 0;
        public int hour = 0;
        public int minute = 0;
        public int second = 0;
        public string lapTime = "";
        public string endTime = "";


    public string GetLapTime(int hr, int min, int sec, int lap = 0)
        {


            return lapTime;
        }
    }
}

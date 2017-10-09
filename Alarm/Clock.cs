using Alarm.Interface;
using System;
using System.Threading;

namespace Alarm
{
    public class Clock : IClock
    {
        private readonly IBell _bell;
        private System.Threading.Timer _timer;
        private readonly IDisplay _display;
        private Timer _clocker;


        public TimeSpan AlarmBell { get; private set; }
        public TimeSpan Time { get; private set; }

        public Clock(IBell bell, DateTime now, IDisplay display)
        {
            _bell = bell;
            Time = now.TimeOfDay;
            _display = display;
        }


        public void SetAlarm(int h, int m, int s)
        {
            AlarmBell = new TimeSpan(h, m, s);
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = AlarmBell - current.TimeOfDay;
            this._timer = new System.Threading.Timer(x =>
            {
                _clocker.Dispose();
                _bell.Start();

            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }

        public void SetTime(int h, int m, int s)
        {
            Time = new TimeSpan(h, m, s);
        }

        public void TurnOff()
        {
            _timer.Dispose();
            _clocker.Dispose();
        }

        public void TurnOn()
        {
            _clocker = new Timer(x =>
            {
                Time = Time.Add(new TimeSpan(0, 0, 1));
                _display.Show(Time.Hours, Time.Minutes, Time.Seconds);

            }, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }
    }
}
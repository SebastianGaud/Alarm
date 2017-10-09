using Alarm.Interface;
using System;
using System.Threading;

namespace Alarm
{
    public class Bell : IBell
    {
        private Timer _timer;

        public void End()
        {
            Console.WriteLine("La Sveglia si è fermata");
            _timer.Dispose();
        }

        public void Start()
        {
            Console.WriteLine("DRIIIIIIIIIN");
            _timer = new System.Threading.Timer(x => this.End(), null, 5000, Timeout.Infinite);

        }
    }
}

using Alarm.Interface;
using System;

namespace Alarm
{
    public class Display : IDisplay
    {
        public void Show(int h, int m, int s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            System.Console.WriteLine(new TimeSpan(h, m, s));
            Console.ResetColor();
        }
    }
}

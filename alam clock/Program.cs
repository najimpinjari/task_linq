using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace alam_clock
{
    class AlarmClockApp
    {
        public void SetAlarm(DateTime alarmTime, string alarmMessage)
        {
            TimeSpan timeToWait = alarmTime - DateTime.Now;

            if (timeToWait.TotalSeconds > 0)
            {
                Console.WriteLine($"Alarm set for {alarmTime}.");
                Thread.Sleep(timeToWait);
                Console.WriteLine($"ALARM: {alarmMessage}");
            }
            else
            {
                Console.WriteLine("Invalid alarm time. Please set a future time.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            AlarmClockApp alarmClock = new AlarmClockApp();

            // Example usage
            alarmClock.SetAlarm(DateTime.Now.AddMinutes(1), "Wake up!");

            // You can add more features like recurring alarms, etc.
        }
    }
}

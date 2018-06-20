using System;

namespace AlarmClock
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ClockRadio clock1 = new ClockRadio();
            clock1.SetTime("5:00PM");
            clock1.DisplayTime();
            clock1.SetAlarmTime("6:00AM");
            clock1.DisplayAlarmTime();

            ClockRadio clock2 = new ClockRadio();
            clock2.SetTime("12:00PM");
            clock2.DisplayTime();
            clock2.SetAlarmTime("5:30");
            clock2.DisplayAlarmTime();



        }
    }
}

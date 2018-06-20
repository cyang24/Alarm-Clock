using System;

namespace AlarmClock
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ClockRadio clock1 = new ClockRadio();
            clock1.SetName("Bed Room");
            clock1.SetTime("5:00PM");
            clock1.DisplayTime();
            clock1.DisplayRadioStation();
            clock1.SetAlarmTime("6:00AM");
            clock1.DisplayAlarmTime();
            clock1.SetAlarmOff();


            ClockRadio clock2 = new ClockRadio();
            clock2.SetName("Living Room");
            clock2.SetTime("12:00PM");
            clock2.DisplayTime();
            clock2.SetRadioStation("POP");
            clock2.SetAlarmTime("5:30AM");
            clock2.DisplayAlarmTime();

            ClockRadio clock3 = new ClockRadio();
            clock3.SetName("Kitchen");
            clock3.DisplayTime();
            clock3.DisplayRadioStation();
            clock3.SetAlarmOff();


        }
    }
}

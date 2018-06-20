using System;
namespace AlarmClock
{
    public class ClockRadio
    {
        //method variables

        string clockName;
        string time;
        string radioStation;
        string alarmTime;
        bool alarmOn;


        //constructor

        public ClockRadio()
        {
            clockName = "Default";
            time = "12:00 AM";
            radioStation = "COUNTRY";
            alarmOn = false;
        }


        //method functions

        public void SetName(string clockName)
        {
            this.clockName = clockName;
            Console.WriteLine(clockName + " Clock's");
        }

        public void SetTime(string time)
        {
            this.time = time;
        }

        public void SetRadioStation(string radioStation)
        {
            this.radioStation = radioStation; 
        }

        public void SetAlarmTime(string alarmTime)
        {
            this.alarmTime = alarmTime;
            alarmOn = true;
            Console.WriteLine("Alarm is OFF");

        }

        public void SetAlarmOff()
        {
            this.alarmOn = false;

        }


        public void DisplayTime()
        {
            Console.WriteLine("current time is " + time);
        }

        public void DisplayRadioStation()
        {
            Console.WriteLine("now playing " + radioStation);
        }

        public void DisplayAlarmTime()
        {
            Console.WriteLine("alarm is set at " + alarmTime);

        }
    }
}

using System;
namespace AlarmClock
{
    public class ClockRadio
    {   
        //variables

        string time;
        string radioStation;
        string alarmTime;
        bool alarmOn;


        //constructor

        public ClockRadio()
        {
            time = "12:00 AM";
            radioStation = "COUNTRY";
            alarmOn = false;
        }


        //functions set values

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
        }

        //functions display value

        public void DisplayTime()
        {
            Console.WriteLine("the current time is " + time);
        }

        public void DisplayRadioStation()
        {
            Console.WriteLine("now playing " + radioStation);
        }

        public void DisplayAlarmTime()
        {
            Console.WriteLine("the alarm is set at " + alarmTime + " the alarm is on " + alarmOn);

        }
    }
}

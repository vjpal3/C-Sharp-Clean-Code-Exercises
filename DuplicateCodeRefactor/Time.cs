using System;

namespace CleanCodeExercises.DuplicateCodeRefactor
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public static Time Parse(string str)
        {
            int time;
            int hours = 0, minutes = 0;
            if (!string.IsNullOrEmpty(str) && int.TryParse(str.Replace(":", ""), out time))
            {                
                hours = time / 100;
                minutes = time % 100;
                if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59)                
                    throw new ArgumentException("Invalid Arguments");

                Console.WriteLine("Parsed Time: hours: {0}, Minutes: {1}", hours, minutes);
            }
            else
                throw new ArgumentNullException("str");
                               
            return new Time(hours, minutes);
        }
    }
}

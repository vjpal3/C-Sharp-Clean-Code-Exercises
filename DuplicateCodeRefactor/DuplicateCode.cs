using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExercises.DuplicateCodeRefactor
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public Time(int hours, int minutes)
        {
            this.Hours = hours;
            this.Minutes = minutes;
        }

        public static Time Parse(string str)
        {
            int time;
            int hours = 0, minutes = 0;
            if (!string.IsNullOrEmpty(str))
            {
                if (int.TryParse(str.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;

                    Console.WriteLine("Parsed Time: hours: {0}, Minutes: {1}", hours, minutes);
                }
                else
                {
                    throw new ArgumentNullException("str");
                }

            }
            else
                throw new ArgumentNullException("str");

            return new Time(hours, minutes);
        }
    }
    public class DuplicateCode
    {
        public void AdmitGuest(string name, string str)
        {
            // .....
            // Business Logic             
            var time = Time.Parse(str);
            var hours = time.Hours;
            var minutes = time.Minutes;

            // .....
            // More Business Logic 
        }

        

        public void UpdateAdmission(int admissionId, string name, string str)
        {
            // .....
            // Business Logic 
          
            var time = Time.Parse(str);
            var hours = time.Hours;
            var minutes = time.Minutes;

            // .....
            // More Business Logic 
        }
    }
}

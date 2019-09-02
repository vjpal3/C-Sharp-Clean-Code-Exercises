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
    }
    public class DuplicateCode
    {
        public void AdmitGuest(string name, string admissionDateTime)
        {
            // .....
            // Business Logic             
            var time = GetTime(admissionDateTime);
            var hours = time.Hours;
            var minutes = time.Minutes;

            // .....
            // More Business Logic 
        }

        private static Time GetTime(string admissionDateTime)
        {
            int time;
            int hours = 0, minutes = 0;
            if (!string.IsNullOrEmpty(admissionDateTime))
            {
                if (int.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;

                    Console.WriteLine("Parsed Time: hours: {0}, Minutes: {1}", hours, minutes);
                }
                else
                {
                    throw new ArgumentNullException("AdmissionDateTime");
                }

            }
            else 
                throw new ArgumentNullException("AdmissionDateTime");

            return new Time(hours, minutes);
        }

        public void UpdateAdmission(int admissionId, string name, string admissionDateTime)
        {
            // .....
            // Business Logic 
          
            var time = GetTime(admissionDateTime);
            var hours = time.Hours;
            var minutes = time.Minutes;

            // .....
            // More Business Logic 
        }
    }
}

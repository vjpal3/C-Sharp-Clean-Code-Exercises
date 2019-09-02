using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExercises.DuplicateCodeRefactor
{
    class DuplicateCode
    {
        public void AdmitGuest(string name, string admissionDateTime)
        {
            // .....
            // Business Logic 

            int time;
            int hours = 0, minutes = 0;
            if (!string.IsNullOrEmpty(admissionDateTime)) {
                if(int.TryParse(admissionDateTime.Replace(":", ""), out time))
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

            // .....
            // More Business Logic 
        }

        public void UpdateAdmission(int admissionId, string name, string admissionDateTime)
        {
            // .....
            // Business Logic 

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

            // .....
            // More Business Logic 
        }
    }
}

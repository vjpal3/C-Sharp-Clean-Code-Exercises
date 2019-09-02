using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExercises.DuplicateCodeRefactor
{

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

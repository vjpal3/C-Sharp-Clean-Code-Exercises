using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExercises.SwitchStatementRefacor
{
    public class MonthlyStatement
    {
        public float CallCost { get; set; }
        public float SmsCost { get; set; }
        public float TotalCost { get; set; }

        

        public void PrintStatement()
        {
            Console.WriteLine("CallCost: {0}, SmsCost: {1}, TotalCost: {2}", CallCost, SmsCost, TotalCost);           
        }
    }
}

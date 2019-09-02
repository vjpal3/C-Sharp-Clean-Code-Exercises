using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExercises.SwitchStatementRefacor
{
    class MonthlyStatement
    {
        public float CallCost { get; set; }
        public float SmsCost { get; set; }
        public float TotalCost { get; set; }

        public void Generate(MonthlyUsage usage)
        {
            switch (usage.Customer.Type)
            {
                case CustomerType.PayAsYouGo:
                    CallCost = 0.12f * usage.CallMinutes;
                    SmsCost = 0.12f * usage.SmsCount;
                    TotalCost = CallCost + SmsCost;
                    break;

                case CustomerType.Unlimited:
                    TotalCost = 54.90f;
                    break;

                default:
                    throw new NotSupportedException("The Current Customer Type is not supported");
            }
        }

        public void PrintStatement()
        {
            Console.WriteLine("CallCost: {0}, SmsCost: {1}, TotalCost: {2}", CallCost, SmsCost, TotalCost);           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExercises.SwitchStatementRefacor
{  
        public class MonthlyUsage
        {
            public int CallMinutes { get; set; }
            public int SmsCount { get; set; }

            public Customer Customer;

        public MonthlyStatement Generate()
        {
            var statement = new MonthlyStatement();
            switch (Customer.Type)
            {
                case CustomerType.PayAsYouGo:
                    statement.CallCost = 0.12f * CallMinutes;
                    statement.SmsCost = 0.12f * SmsCount;
                    statement.TotalCost = statement.CallCost + statement.SmsCost;
                    break;

                case CustomerType.Unlimited:
                    statement.TotalCost = 54.90f;
                    break;

                default:
                    throw new NotSupportedException("The Current Customer Type is not supported");
            }
            return statement;
        }
    }   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExercises.SwitchStatementRefacor
{
    public class Customer
    {
        public CustomerType Type { get; set; }

        public MonthlyStatement GenerateStatement(MonthlyUsage usage)
        {
            var statement = new MonthlyStatement();
            switch (Type)
            {
                case CustomerType.PayAsYouGo:
                    statement.CallCost = 0.12f * usage.CallMinutes;
                    statement.SmsCost = 0.12f * usage.SmsCount;
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

    public enum CustomerType
    {
        PayAsYouGo = 1,
        Unlimited = 2
    }
}

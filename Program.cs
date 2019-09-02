using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCodeExercises.SwitchStatementRefacor;

namespace CleanCodeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var usage = new MonthlyUsage { CallMinutes = 130, SmsCount = 213 };
            usage.Customer = new Customer { Type = CustomerType.PayAsYouGo };
            var statement1 = usage.Generate();
            statement1.PrintStatement();

            usage.Customer = new Customer { Type = CustomerType.Unlimited };
            var statement2 = usage.Generate();        
            statement2.PrintStatement();
        }
    }
}

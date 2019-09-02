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
            var customer1 = new PayAsYouGoCustomer();
            var usage1 = new MonthlyUsage { CallMinutes = 130, SmsCount = 213, Customer = customer1 };           
            var statement1 = usage1.Customer.GenerateStatement(usage1);
            statement1.PrintStatement();

            var customer2 = new UnlimitedCustomer();
            var usage2 = new MonthlyUsage { CallMinutes = 100, SmsCount = 100, Customer = customer2 };
            var statement2 = usage2.Customer.GenerateStatement(usage2);
            statement2.PrintStatement();
        }
    }
}

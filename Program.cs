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
            var statement = new MonthlyStatement();
            var usage = new MonthlyUsage();           
            usage.Customer = new Customer();
            usage.Customer.Type = (CustomerType)1;
            usage.CallMinutes = 150;
            usage.SmsCount = 98;
            statement.Generate(usage);
            statement.PrintStatement();

        }
    }
}

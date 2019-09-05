using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCodeExercises.DuplicateCodeRefactor;
using CleanCodeExercises.SwitchStatementRefacor;
using CleanCodeExercises.NestedConditionalsRefactor;


namespace CleanCodeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run NestedConditionalRefactor Code
            var goldCustomer1 = new CleanCodeExercises.NestedConditionalsRefactor.Customer() { LoyaltyPoints = 120 };
            var reservation1 = new Reservasion(goldCustomer1, DateTime.Now.AddHours(25));
            reservation1.Cancel();
            Console.WriteLine("Gold Customer, 25 Hrs before - Cancellation status: " + reservation1.IsCancelled);
            Console.WriteLine();
          
            reservation1 = new Reservasion(goldCustomer1, DateTime.Now.AddHours(23));
            reservation1.Cancel();
            Console.WriteLine("Gold Customer, less than 24 Hrs - Cancellation status: " + reservation1.IsCancelled);
            Console.WriteLine();

            reservation1 = new Reservasion(goldCustomer1, DateTime.Now.AddDays(-1));
            reservation1.Cancel();
            Console.WriteLine("Gold Customer, cancelling after start date - Cancellation status: " + reservation1.IsCancelled);
            Console.WriteLine();

            var regularCustomer1 = new CleanCodeExercises.NestedConditionalsRefactor.Customer() { LoyaltyPoints = 90 };
            var reservation2 = new Reservasion(regularCustomer1, DateTime.Now.AddHours(49));
            reservation2.Cancel();
            Console.WriteLine("Regular Customer, 49 Hrs before - Cancellation status: " + reservation2.IsCancelled);
            Console.WriteLine();

            reservation2 = new Reservasion(regularCustomer1, DateTime.Now.AddHours(47));
            reservation2.Cancel();
            Console.WriteLine("Regular Customer, less than 48 Hrs - Cancellation status: " + reservation2.IsCancelled);
            Console.WriteLine();

            reservation2 = new Reservasion(regularCustomer1, DateTime.Now.AddDays(-1));
            reservation2.Cancel();
            Console.WriteLine("Regular Customer, cancelling after start date - Cancellation status: " + reservation2.IsCancelled);


            //Run DuplicateCodeRefactor Code
            //new DuplicateCode().AdmitGuest("John Smith", "17:10");
            //new DuplicateCode().UpdateAdmission(10, "Jane Parera", "12:27");

            //Run SwitchStatementRefactor Code
            //var customer1 = new PayAsYouGoCustomer();
            //var usage1 = new MonthlyUsage { CallMinutes = 130, SmsCount = 213, Customer = customer1 };           
            //var statement1 = usage1.Customer.GenerateStatement(usage1);
            //statement1.PrintStatement();

            //var customer2 = new UnlimitedCustomer();
            //var usage2 = new MonthlyUsage { CallMinutes = 100, SmsCount = 100, Customer = customer2 };
            //var statement2 = usage2.Customer.GenerateStatement(usage2);
            //statement2.PrintStatement();
        }
    }
}

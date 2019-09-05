using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExercises.NestedConditionalsRefactor
{
    class Customer
    {
        public int LoyaltyPoints { get; set; }
    }

    class Reservasion
    {
        public DateTime From { get; set; }
        public Customer Customer { get; set; }
        public bool IsCancelled { get; set; }

        public Reservasion(Customer customer, DateTime datetime)
        {
            From = datetime;
            Customer = customer;
        }

        public void Cancel()
        {                     
            try
            {               
                if (IsGoldCustomer() && LessThan(24))
                    throw new InvalidOperationException("It's too late to cancel. ");

            }
            catch (InvalidOperationException e)
            {
                Console.Write(e.Message);
                IsCancelled = false;
                return;
            }           
           
            try
            {
                if (!IsGoldCustomer() && LessThan(48))
                    throw new InvalidOperationException("It's too late to cancel.");
            }
            catch (InvalidOperationException e)
            {
                Console.Write(e.Message);
                IsCancelled = false;
                return;
            }

            IsCancelled = true;   

        }

        private bool LessThan(int maxHrs)
        {
            return (From - DateTime.Now).TotalHours < maxHrs;
        }

        private bool IsGoldCustomer()
        {
            return Customer.LoyaltyPoints > 100;
        }
    }
}

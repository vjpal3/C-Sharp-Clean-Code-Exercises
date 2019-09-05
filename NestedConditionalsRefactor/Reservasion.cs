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

        public bool IsGoldCustomer()
        {
            return LoyaltyPoints > 100;
        }
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
                if (IsCancellationPeriodOver())
                    throw new InvalidOperationException("It's too late to cancel. ");
            }
            catch (InvalidOperationException e)
            {
                Console.Write(e.Message);
                IsCancelled = false;
                return;
            }                                
            IsCancelled = true;   
        }

        private bool IsCancellationPeriodOver()
        {
            return (Customer.IsGoldCustomer() && LessThan(24)) || (!Customer.IsGoldCustomer() && LessThan(48));
        }

        private bool LessThan(int maxHrs)
        {
            return (From - DateTime.Now).TotalHours < maxHrs;
        }        
    }
}

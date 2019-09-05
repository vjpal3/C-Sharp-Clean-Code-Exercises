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
            // Gold Customer can cancel upto 24 hrs before
            if(Customer.LoyaltyPoints > 100)
            {
                try
                {
                    if (DateTime.Now > From)
                        throw new InvalidOperationException("It's too late to cancel. ");

                    if ((From - DateTime.Now).TotalHours < 24)
                        throw new InvalidOperationException("It's too late to cancel. ");
                    
                }
                catch(InvalidOperationException e)
                {
                    Console.Write(e.Message);
                    IsCancelled = false;
                    return;
                }
                IsCancelled = true;

            }
            else
            {
                // Regular Customer can cancel upto 48 hrs before
                try
                {
                    if (DateTime.Now > From)
                        throw new InvalidOperationException("It's too late to cancel.");

                    if ((From - DateTime.Now).TotalHours < 48)
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

        }
    }
}

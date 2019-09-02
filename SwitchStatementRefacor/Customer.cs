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

    }

    public enum CustomerType
    {
        PayAsYouGo = 1,
        Unlimited = 2
    }
}

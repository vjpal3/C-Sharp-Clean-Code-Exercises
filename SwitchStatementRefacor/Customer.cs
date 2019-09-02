using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExercises.SwitchStatementRefacor
{
    public abstract class Customer
    {
        public abstract MonthlyStatement GenerateStatement(MonthlyUsage usage);
    }
}

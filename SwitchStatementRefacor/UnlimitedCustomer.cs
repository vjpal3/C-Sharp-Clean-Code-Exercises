using System;
using CleanCodeExercises.SwitchStatementRefacor;

namespace CleanCodeExercises.SwitchStatementRefacor
{
    public class UnlimitedCustomer : Customer
    {       
        public override MonthlyStatement GenerateStatement(MonthlyUsage usage)
        {
            var statement = new MonthlyStatement();
            statement.TotalCost = 54.90f;           
            return statement;
        }
    }
}

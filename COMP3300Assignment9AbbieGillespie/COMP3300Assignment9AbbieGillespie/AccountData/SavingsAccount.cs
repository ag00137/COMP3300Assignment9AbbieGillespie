using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9AbbieGillespie.AccountData
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string ownerName, decimal currentBalance, string monthOpened, string type, decimal monthlyInterestRate) : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {

        }

        public override decimal CalculateMinimumBalanceFee()
        {
            return CurrentBalance * 0.05m;
        }

        public override string ToString()
        {
            return $"Account Type: Savings - {base.ToString()}";
        }
    }
}

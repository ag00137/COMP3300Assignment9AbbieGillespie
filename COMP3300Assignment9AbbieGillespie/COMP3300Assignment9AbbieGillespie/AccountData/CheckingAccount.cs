using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9AbbieGillespie.AccountData
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string ownerName, decimal currentBalance, string monthOpened, string type, decimal monthlyInterestRate) : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {

        }

        public override decimal CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 1200)
            {
                return CurrentBalance * 0.08m;
            }
            return base.CalculateMinimumBalanceFee();
        }

        public override string ToString()
        {
            return $"Account Type: Checking - {base.ToString()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9AbbieGillespie.AccountData
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string OwnerName, decimal CurrentBalance, string MonthOpened, string Type, decimal MonthlyInterestRate) : base(OwnerName, CurrentBalance, MonthOpened, Type, MonthlyInterestRate)
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

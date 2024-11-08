using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9AbbieGillespie.AccountData
{
    public class BusinessAccount : BankAccount
    {
        public BusinessAccount(string ownerName, decimal currentBalance, string monthOpened, string type, decimal monthlyInterestRate) : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {

        }

        public override decimal CalculateMinimumBalanceFee()
        {
            decimal balance = base.CalculateMinimumBalanceFee();
            return balance + (CurrentBalance * 0.01m);
        }

        public override string ToString()
        {
            return $"Account Type: Business - {base.ToString()}";
        }
    }
}

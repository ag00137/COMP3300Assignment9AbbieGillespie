using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9AbbieGillespie.AccountData
{
    /// <summary>
    /// Holds the checking accounts and gets the minimum fee.
    /// </summary>
    /// <seealso cref="COMP3300Assignment9AbbieGillespie.AccountData.BankAccount" />
    public class CheckingAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the CheckingAccount class.
        /// </summary>
        /// <param name="ownerName">Name of the owner.</param>
        /// <param name="currentBalance">The current balance.</param>
        /// <param name="monthOpened">The month opened.</param>
        /// <param name="type">The type of bank account.</param>
        /// <param name="monthlyInterestRate">The monthly interest rate.</param>
        public CheckingAccount(string OwnerName, decimal CurrentBalance, string MonthOpened, string Type, decimal MonthlyInterestRate) : base(OwnerName, CurrentBalance, MonthOpened, Type, MonthlyInterestRate)
        {

        }

        /// <summary>
        /// Calculates the minimum balance fee.
        /// </summary>
        /// <returns>
        /// The result of the calculation.
        /// </returns>
        public override decimal CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 1200)
            {
                return CurrentBalance * 0.08m;
            }
            return base.CalculateMinimumBalanceFee();
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A string that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Account Type: Checking - {base.ToString()}";
        }
    }
}

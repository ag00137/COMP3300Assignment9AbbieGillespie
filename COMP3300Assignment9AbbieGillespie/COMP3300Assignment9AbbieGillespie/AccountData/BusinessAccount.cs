using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3300Assignment9AbbieGillespie.AccountData
{
    /// <summary>
    /// Gets and holds the business accounts and calculates the minimum fee.
    /// </summary>
    /// <seealso cref="COMP3300Assignment9AbbieGillespie.AccountData.BankAccount" />
    public class BusinessAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAccount"/> class.
        /// </summary>
        /// <param name="ownerName">Name of the owner.</param>
        /// <param name="currentBalance">The current balance.</param>
        /// <param name="monthOpened">The month opened.</param>
        /// <param name="type">The type of bank account.</param>
        /// <param name="monthlyInterestRate">The monthly interest rate.</param>
        public BusinessAccount(string ownerName, decimal currentBalance, string monthOpened, string type, decimal monthlyInterestRate) : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
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
            decimal balance = base.CalculateMinimumBalanceFee();
            return balance + (CurrentBalance * 0.01m);
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A string that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Account Type: Business - {base.ToString()}";
        }
    }
}

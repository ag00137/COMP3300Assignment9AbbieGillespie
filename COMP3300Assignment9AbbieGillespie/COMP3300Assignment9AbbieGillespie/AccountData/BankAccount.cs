using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COMP3300Assignment9AbbieGillespie.AccountData
{
    /// <summary>
    /// Holds an object from the json file.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Gets or sets the name of the owner.
        /// </summary>
        [JsonPropertyName("OwnerName")]
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the current balance.
        /// </summary>
        [JsonPropertyName("CurrentBalance")]
        public decimal CurrentBalance { get; set; }

        /// <summary>
        /// Gets or sets the month opened.
        /// </summary>
        [JsonPropertyName("MonthOpened")]
        public string MonthOpened { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the monthly interest rate.
        /// </summary>
        [JsonPropertyName("MonthlyInterestRate")]
        public decimal MonthlyInterestRate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class.
        /// </summary>
        /// <param name="ownerName">Name of the owner.</param>
        /// <param name="currentBalance">The current balance.</param>
        /// <param name="monthOpened">The month opened.</param>
        /// <param name="type">The type of bank account.</param>
        /// <param name="monthlyInterestRate">The monthly interest rate.</param>
        public BankAccount(string ownerName, decimal currentBalance, string monthOpened, string type, decimal monthlyInterestRate)
        {
            OwnerName = ownerName;
            CurrentBalance = currentBalance;
            MonthOpened = monthOpened;
            Type = type;
            MonthlyInterestRate = monthlyInterestRate;
        }

        /// <summary>
        /// Calculates the minimum balance fee.
        /// </summary>
        /// <returns>The result of the calculation.</returns>
        public virtual decimal CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 1200)
            {
                return CurrentBalance * 0.073m;
            }
            return 0;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>A string with the account information.</returns>
        public override string ToString()
        {
            return $"Name: {OwnerName}, Balance: {CurrentBalance:C}, Month Opened: {MonthOpened}, Monthly Intersent Rate: {MonthlyInterestRate:P}";
        }
    }
}

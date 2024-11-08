using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COMP3300Assignment9AbbieGillespie.AccountData
{
    public class BankAccount
    {
        [JsonPropertyName("OwnerName")]
        public required string OwnerName { get; set; }

        [JsonPropertyName("CurrentBalance")]
        public required decimal CurrentBalance { get; set; }

        [JsonPropertyName("MonthOpened")]
        public required string MonthOpened { get; set; }

        [JsonPropertyName("Type")]
        public required string Type { get; set; }

        [JsonPropertyName("MonthlyInterestRate")]
        public required decimal MonthlyInterestRate { get; set; }

        public BankAccount(string ownerName, decimal currentBalance, string monthOpened, string type, decimal monthlyInterestRate)
        {
            OwnerName = ownerName;
            CurrentBalance = currentBalance;
            MonthOpened = monthOpened;
            Type = type;
            MonthlyInterestRate = monthlyInterestRate;
        }

        public virtual decimal CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 1200)
            {
                return CurrentBalance * 0.073m;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"Name: {OwnerName}, Balance: {CurrentBalance:C}, Month Opened: {MonthOpened}, Monthly Intersent Rate: {MonthlyInterestRate:P}";
        }
    }
}

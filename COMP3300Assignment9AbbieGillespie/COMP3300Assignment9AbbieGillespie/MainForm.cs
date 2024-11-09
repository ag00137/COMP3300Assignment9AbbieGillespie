using COMP3300Assignment9AbbieGillespie.AccountData;
using System.Text.Json;

namespace COMP3300Assignment9AbbieGillespie
{
    public partial class MainForm : Form
    {
        private List<BankAccount>? accountsData;
        private List<CheckingAccount>? checkingAccounts = new List<CheckingAccount>();
        private List<SavingsAccount> savingsAccounts = new List<SavingsAccount>();
        private List<BusinessAccount> businessAccounts = new List<BusinessAccount>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                string jsonData = File.ReadAllText(file);
                accountsData = JsonSerializer.Deserialize<List<BankAccount>>(jsonData);

                if (accountsData != null)
                {
                    foreach (var account in accountsData)
                    {
                        AccountsDisplayTxtBox.Items.Add(account.ToString());
                    }

                    foreach (var account in accountsData)
                    {
                        if (account.Type == "checking")
                        {
                            CheckingAccount checkingAccount = new CheckingAccount(account.OwnerName, account.CurrentBalance, account.MonthOpened, account.Type, account.MonthlyInterestRate);

                            if (checkingAccounts != null)
                            {
                                checkingAccounts.Add(checkingAccount);
                            }
                        }

                        if (account.Type == "savings")
                        {
                            SavingsAccount savingsAccount = new SavingsAccount(account.OwnerName, account.CurrentBalance, account.MonthOpened, account.Type, account.MonthlyInterestRate);

                            if (savingsAccount != null)
                            {
                                savingsAccounts.Add(savingsAccount);
                            }
                        }

                        if (account.Type == "savings")
                        {
                            BusinessAccount businessAccount = new BusinessAccount(account.OwnerName, account.CurrentBalance, account.MonthOpened, account.Type, account.MonthlyInterestRate);

                            if (businessAccount != null)
                            {
                                businessAccounts.Add(businessAccount);
                            }
                        }
                    }
                }
            }


        }

        private void CheckingAccountBtn_Click(object sender, EventArgs e)
        {

            AccountsDisplayTxtBox.Items.Clear();

            if (checkingAccounts != null)
            {
                foreach (var account in checkingAccounts)
                {
                    AccountsDisplayTxtBox.Items.Add(account.ToString());
                }
            }
        }

        private void SavingsAccountBtn_Click(object sender, EventArgs e)
        {
            AccountsDisplayTxtBox.Items.Clear();

            if (savingsAccounts != null)
            {
                foreach (var account in savingsAccounts)
                {
                    AccountsDisplayTxtBox.Items.Add(account.ToString());
                }
            }
        }

        private void BusinessAcountsBtn_Click(object sender, EventArgs e)
        {
            AccountsDisplayTxtBox.Items.Clear();

            if (businessAccounts != null)
            {
                foreach (var account in businessAccounts)
                {
                    AccountsDisplayTxtBox.Items.Add(account.ToString());
                }
            }
        }
    }
}

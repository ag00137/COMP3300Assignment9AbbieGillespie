using COMP3300Assignment9AbbieGillespie.AccountData;
using System.Text.Json;

namespace COMP3300Assignment9AbbieGillespie
{
    public partial class MainForm : Form
    {
        private List<BankAccount>? accountsData;
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
            }
        }

        private void CheckingAccountBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

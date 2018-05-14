using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WestrenBank
{
    public partial class BuyStock : Form
    {
        public BuyStock()
        {
            InitializeComponent();
        }

        private void stocksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stocksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void BuyStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);
            // TODO: This line of code loads data into the 'bankDBDataSet.StocksAndAccounts' table. You can move, or remove it, as needed.
            this.stocksAndAccountsTableAdapter.Fill(this.bankDBDataSet.StocksAndAccounts);
            // TODO: This line of code loads data into the 'bankDBDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.bankDBDataSet.Stocks);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if((c < '0' || c > '9') && c != '\b')
            {
                MessageBox.Show("הינך חייב להכניס ספרות בלבד");
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stockID = comboBox1.SelectedValue.ToString();
            string accountID = comboBox2.SelectedValue.ToString();
            int amount = 0;
            try
            {
                amount = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("הינך חייב להכניס מספר מניות שברצונך לרכוש");
                return;
            }
            if(amount > int.Parse(stockAvaliableAmountTextBox.Text))
            {
                MessageBox.Show("אין מספיק מניות זמינות");
                return;
            }

            (tAccountsDataGridView.DataSource as BindingSource).Filter = "AccountID =" + accountID;
            int avaliable = int.Parse(currentTextBox.Text) + int.Parse(creditFrameTextBox.Text);
            int money = amount * int.Parse(valueTextBox.Text);
            if(money > avaliable)
            {
                MessageBox.Show("אין מספיק כסף כדי לבצע רכישה");
                return;
            }
            stockAvaliableAmountTextBox.Text = (int.Parse(stockAvaliableAmountTextBox.Text) - amount).ToString();
            stocksBindingSource.EndEdit();
            stocksTableAdapter.Update(bankDBDataSet.Stocks);

            (stocksAndAccountsDataGridView.DataSource as BindingSource).Filter = "AccountID =" + accountID + "And StockID =" + stockID;
            if(accountIDTextBox.Text == accountID)
            {
                // User already have such stockes
                stocksAmountTextBox.Text = (int.Parse(stocksAmountTextBox.Text) + amount).ToString();
                stocksAndAccountsBindingSource.EndEdit();
                stocksAndAccountsTableAdapter.Update(bankDBDataSet.StocksAndAccounts);
            }
            else
            {
                // User does not have such stockes
                stocksAndAccountsBindingSource.AddNew();
                stockIDTextBox.Text = stockID;
                accountIDTextBox.Text = accountID;
                stocksAmountTextBox.Text = amount.ToString();
                stocksAndAccountsBindingSource.EndEdit();
                stocksAndAccountsTableAdapter.Update(bankDBDataSet.StocksAndAccounts);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            (stocksDataGridView.DataSource as BindingSource).Filter = "StockID = " + comboBox1.SelectedValue.ToString();
        }
    }
}

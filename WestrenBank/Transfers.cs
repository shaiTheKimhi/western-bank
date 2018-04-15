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
    public partial class Transfers : Form
    {
        public Transfers()
        {
            InitializeComponent();
        }

        private void tAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void Transfers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reciverID = comboBox2.SelectedValue.ToString();
            string giverID = comboBox1.SelectedValue.ToString();
            (tAccountsDataGridView.DataSource as BindingSource).Filter = "Where AccountID = " + giverID;
            int diff = int.Parse(textBox1.Text);
            int money = int.Parse(currentTextBox.Text) - diff;
            if(-money > int.Parse(creditFrameTextBox.Text))
            {
                MessageBox.Show("account does not have enough money");
                return;
            }
            if(textBox2.Text != passwordTextBox.Text)
            {
                MessageBox.Show("password is not correct");
                return;
            }

            currentTextBox.Text = money.ToString();
            tAccountsBindingSource.EndEdit();
            tAccountsTableAdapter.Fill(bankDBDataSet.TAccounts);

            (tAccountsBindingSource.DataSource as BindingSource).Filter = "Where AccountID = " + reciverID;
            currentTextBox.Text = (int.Parse(currentTextBox.Text) + diff).ToString();
            tAccountsBindingSource.EndEdit();
            tAccountsTableAdapter.Fill(bankDBDataSet.TAccounts);
        }
    }
}

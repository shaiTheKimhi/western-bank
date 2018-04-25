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
    public partial class TakeCommision : Form
    {
        public string description = "";
        public string AccountID = null;
        public int money = 0;
        public TakeCommision()
        {
            InitializeComponent();
        }

        private void commissionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.commissionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void TakeCommision_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);
            // TODO: This line of code loads data into the 'bankDBDataSet.Commissions' table. You can move, or remove it, as needed.
            this.commissionsTableAdapter.Fill(this.bankDBDataSet.Commissions);

            AddCommision();
            TakeMoney();
            this.Close();
        }

        private void commissionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void AddCommision()
        {
            commissionsBindingSource.AddNew();

            clientIDTextBox.Text = AccountID;
            descriptionTextBox.Text = description;
            commissionSizeTextBox.Text = money.ToString();
            commissionDateDateTimePicker.Value = DateTime.Now;
            commissionsBindingSource.EndEdit();
            commissionsTableAdapter.Update(bankDBDataSet.Commissions);
        }
        public void TakeMoney()
        {
            (tAccountsDataGridView.DataSource as BindingSource).Filter = "AccountID = " + AccountID;
            int money = int.Parse(currentTextBox.Text);
            currentTextBox.Text = (money - this.money).ToString();
            tAccountsBindingSource.EndEdit();
            tAccountsTableAdapter.Update(bankDBDataSet.TAccounts);
        }
    }
}

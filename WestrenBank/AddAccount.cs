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
    public partial class AddAccount : Form
    {
        bool IsNew = false;
        public string accountID = "";
        public AddAccount()
        {
            InitializeComponent();
        }

        private void tAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button7.Visible = !button7.Visible;

            accountID = (int.Parse(tAccountsDataGridView.Rows[tAccountsDataGridView.Rows.Count - 2].Cells[0].FormattedValue.ToString())+1).ToString();
            

            tAccountsBindingSource.AddNew();
            accountIDTextBox.Text = accountID;
            button1.Enabled = false;
            button2.Enabled = true;

            this.IsNew = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<tAccountsDataGridView.RowCount-2;i++)
            {
                if(tAccountsDataGridView.Rows[i].Cells[0].FormattedValue.ToString() == accountIDTextBox.Text)
                {
                    MessageBox.Show("already exist");
                    return;
                }
            }
            accountIDTextBox.Text = accountID;
            tAccountsBindingSource.EndEdit();
            tAccountsTableAdapter.Update(this.bankDBDataSet.TAccounts);
            button2.Enabled = false;
            button1.Enabled = true;
            // Add checks to the account
            AddChecks f = new AddChecks();
            f.accountID = accountID;
            f.ShowDialog();
            // Add clients to the account
            AddClientsAccounts aca = new AddClientsAccounts();
            aca.Aid = accountID;
            this.Hide();
            aca.ShowDialog();
            //aca.Aid = accountIDTextBox.Text;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tAccountsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tAccountsBindingSource.MoveNext();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tAccountsBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tAccountsBindingSource.MoveLast();
        }

        private void currentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<'0'||e.KeyChar>'9')&&e.KeyChar!='\b')
            {
                e.Handled = true;
                MessageBox.Show("enter digits only");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tAccountsBindingSource.RemoveCurrent();
        }
    }
}

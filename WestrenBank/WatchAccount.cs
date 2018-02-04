using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WestrenBank.Helper;
namespace WestrenBank
{
    public partial class WatchAccount : Form
    {
        public WatchAccount()
        {
            InitializeComponent();
        }

        private void tAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void WatchAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);
            comboBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tAccountsBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tAccountsBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tAccountsBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tAccountsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string aID = textBox1.Text;
            string aID="";
            string username = textBox2.Text;
            if(checkBox1.Checked)
            {
                aID = tAccountsDataGridView.Rows[comboBox1.SelectedIndex].Cells[0].FormattedValue.ToString();
            }
            string sql = "";
            if(aID!="")
            {
                sql = "AccountID=" + aID;
            }
            else
            {
                sql = "username like '%"+username+"%'";
            }
            DataView dv = new DataView(bankDBDataSet.TAccounts);
            dv.RowFilter = sql;
            tAccountsDataGridView.DataSource = dv;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = ((CheckBox)sender).Checked;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddAccount ac = new AddAccount();
            this.Hide();
            ac.ShowDialog();
            this.Close();
            /*string username = textBox1.Text;
            string sql = "SELECT AccountID,username,password,current,creditFrame,income";
            sql += "FROM (TAccounts INNER JOIN ClientsAndAccounts ON TAccounts.AccountID=ClientsAndAccounts.AccountID)";
            sql += "INNER JOIN TClients ON ClientsAndAccounts.ClientID=TClients.ClientID";
            sql += "WHERE Tclients.ClientName like '%" + username + "%'";
            selectQuery(tAccountsDataGridView, sql);*/
        }
    }
}

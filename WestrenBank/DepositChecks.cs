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
    public partial class DepositChecks : Form
    {
        public DepositChecks()
        {
            InitializeComponent();
        }

        private void tAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void DepositChecks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.Checks' table. You can move, or remove it, as needed.
            this.checksTableAdapter.Fill(this.bankDBDataSet.Checks);
            
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);

            tAccountsDataGridView.Visible = false;
            checksDataGridView.Visible = false;
            isValidCheckBox.Visible = false;
            currentTextBox.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (checksDataGridView.DataSource as BindingSource).Filter = "CheckID=" + textBox1.Text;
            if(checksDataGridView.Rows.Count-2==0)
            {
                MessageBox.Show("no such check");
                return;
            }
            else if(isValidCheckBox.Checked==true)
            {
                MessageBox.Show("no such check");
                return;
            }
            string giverAccount = checksDataGridView.Rows[0].Cells[1].FormattedValue.ToString();
            string getterAccount = textBox3.Text;
            int money = int.Parse(textBox2.Text);
            (tAccountsDataGridView.DataSource as BindingSource).Filter = "AccountID=" + giverAccount;
            currentTextBox.Text = (int.Parse(currentTextBox.Text) - money).ToString();
            (tAccountsDataGridView.DataSource as BindingSource).Filter = "AccountID=" + getterAccount;
            currentTextBox.Text = (int.Parse(currentTextBox.Text) + money).ToString();
            isValidCheckBox.Checked = true;
        }
    }
}

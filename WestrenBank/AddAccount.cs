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
            tAccountsBindingSource.AddNew();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<tAccountsDataGridView.RowCount-1;i++)
            {
                if(tAccountsDataGridView.Rows[i].Cells[0].FormattedValue.ToString() == accountIDTextBox.Text)
                {
                    MessageBox.Show("already exist");
                    return;
                }
            }
            tAccountsBindingSource.EndEdit();
            tAccountsTableAdapter.Update(this.bankDBDataSet.TAccounts);
            button2.Enabled = false;
            button1.Enabled = true;
            AddClientsAccounts aca = new AddClientsAccounts();
            aca.Aid = accountIDTextBox.Text;
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
    }
}

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
    public partial class Deposits : Form
    {
        public Deposits()
        {
            InitializeComponent();
        }

        private void clientsAndAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void Deposits_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.ClientsAndAccounts' table. You can move, or remove it, as needed.
            this.clientsAndAccountsTableAdapter.Fill(this.bankDBDataSet.ClientsAndAccounts);
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);
            // TODO: This line of code loads data into the 'bankDBDataSet.ClientsAndAccounts' table. You can move, or remove it, as needed.
            // this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);
            clientsAndAccountsDataGridView.Visible = false;
            currentTextBox.Visible = false;
            creditFrameTextBox.Visible = false;
            accountIDTextBox.Visible = false;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> accounts = new List<string>();
            for(int i = 0; i < clientsAndAccountsDataGridView.Rows.Count - 2; i++)
            {
                if (clientsAndAccountsDataGridView.Rows[i].Cells[1].FormattedValue.ToString() == textBox1.Text)
                    accounts.Add(clientsAndAccountsDataGridView.Rows[i].Cells[0].FormattedValue.ToString());
            }
            if(accounts.Count!=0)
            {
                string filter = "AccountID=" + accounts[0];
                for (int i = 1; i < accounts.Count; i++)
                    filter = " or AccountID=" + accounts[i];
                (clientsAndAccountsDataGridView.DataSource as BindingSource).Filter = filter;
            }
        }
        public bool clientExist(string id)
        {
            for(int i=0;i<tAccountsDataGridView.Rows.Count-2;i++)
            {
                if (tAccountsDataGridView.Rows[i].Cells[1].FormattedValue.ToString() == id)
                    return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int sign = comboBox1.SelectedIndex == 0 ? -1 : 1;
            int frame = int.Parse(creditFrameTextBox.Text);
            if(sign == -1 && (frame + int.Parse(currentTextBox.Text) < 1.1 * int.Parse(textBox2.Text)))
            {
                MessageBox.Show("אין די כסף כדי לבצע משיכה");
                return;
            }
            currentTextBox.Text = (int.Parse(currentTextBox.Text) + sign * int.Parse(textBox2.Text)).ToString();
            tAccountsBindingSource.EndEdit();
            tAccountsTableAdapter.Update(bankDBDataSet.TAccounts);

            TakeCommision f = new TakeCommision();
            f.AccountID = accountIDTextBox.Text;
            f.money = (int)(int.Parse(textBox2.Text) * 0.1);
            f.form = this;
            MessageBox.Show("עמלה:" + f.money);
            f.ShowDialog();
        }

        private void clientsAndAccountsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            (tAccountsDataGridView.DataSource as BindingSource).Filter = "AccountID = " + textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }
        public void update()
        {
            tAccountsDataGridView.Refresh();
            tAccountsBindingSource.EndEdit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if((c < '0' || c > '9') && c != '\b')
            {
                MessageBox.Show("חייב ספרות בלבד");
                e.Handled = true;
            }
        }
    }
}

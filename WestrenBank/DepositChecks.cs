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
            // TODO: This line of code loads data into the 'bankDBDataSet.Checks' table. You can move, or remove it, as needed.
            this.checksTableAdapter.Fill(this.bankDBDataSet.Checks);
            
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);

            tAccountsDataGridView.Visible = false;
            checksDataGridView.Visible = false;
            isValidCheckBox.Visible = false;
            currentTextBox.Visible = false;
            creditFrameTextBox.Visible = false;
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

        private void tAccountsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string getterID = textBox2.Text;
            string giverID;
            int money = 0, current = 0, frame = 0;

            try
            {
                money = int.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("הכסף לא הוכנס בפורמט הנכון");
                return;
            }
            if(money <= 0)
            {
                MessageBox.Show("סכום הצ'ק חייב להיות חיובי");
                return;
            }

            (checksDataGridView.DataSource as BindingSource).Filter = "CheckID = " + textBox1.Text;
            if(checkIDTextBox.Text != textBox1.Text)
            {
                MessageBox.Show("מספר צ'ק אינו קיים");
                return;
            }
            if(!isValidCheckBox.Checked)
            {
                MessageBox.Show("צ'ק אינו תקף");
                return;
            }
            giverID = giverIDTextBox.Text;

            (tAccountsDataGridView.DataSource as BindingSource).Filter = "AccountID = " + textBox2.Text;
            if(accountIDTextBox.Text != textBox2.Text)
            {
                MessageBox.Show("לא קיים חשבון");
                return;
            }
            (tAccountsDataGridView.DataSource as BindingSource).Filter = "AccountID = " + giverID;
            current = int.Parse(currentTextBox.Text);
            frame = int.Parse(creditFrameTextBox.Text);
            if(current + frame < money)
            {
                MessageBox.Show("אין די כסף כדי לקיים את ההעברה בצ'ק");
                return;
            }
            isValidCheckBox.CheckState = CheckState.Unchecked;
            isValidCheckBox.Checked = false;
            checksBindingSource.EndEdit();
            checksTableAdapter.Update(bankDBDataSet.Checks);

            currentTextBox.Text = (current - money).ToString();
            tAccountsBindingSource.EndEdit();
            tAccountsTableAdapter.Update(bankDBDataSet.TAccounts);

            (tAccountsDataGridView.DataSource as BindingSource).Filter = "AccountID = " + getterID;
            current = int.Parse(currentTextBox.Text);
            currentTextBox.Text = (current + money).ToString();
            tAccountsBindingSource.EndEdit();
            tAccountsTableAdapter.Update(bankDBDataSet.TAccounts);

            

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if((c < '0' || c > '9') && c != '\b')
            {
                MessageBox.Show("חייב להיות ספרות בלבד");
                e.Handled = true;
            }
        }
    }
}

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
    public partial class AddLoan : Form
    {
        public AddLoan()
        {
            InitializeComponent();
        }

        private void loansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void AddLoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TClients' table. You can move, or remove it, as needed.
            this.tClientsTableAdapter.Fill(this.bankDBDataSet.TClients);
            // TODO: This line of code loads data into the 'bankDBDataSet.TClients' table. You can move, or remove it, as needed.
            this.tClientsTableAdapter.Fill(this.bankDBDataSet.TClients);
            // TODO: This line of code loads data into the 'bankDBDataSet.LoansToClients' table. You can move, or remove it, as needed.
            this.loansToClientsTableAdapter.Fill(this.bankDBDataSet.LoansToClients);
            // TODO: This line of code loads data into the 'bankDBDataSet.Loans' table. You can move, or remove it, as needed.
            this.loansTableAdapter.Fill(this.bankDBDataSet.Loans);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loansBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            //puts the next id of loan at the id variable
            try
            {
                id = int.Parse(loansDataGridView.Rows[0].Cells[0].FormattedValue.ToString()) + loansDataGridView.Rows.Count;
            }
            catch
            {
                id = 0;
            }
            DateTime start = loanStartDateDateTimePicker.Value;
            DateTime end = loanEndDateDateTimePicker.Value;
            if((start-end).TotalDays<=0)
            {
                MessageBox.Show("cannot give loan for less than one day");
                return;
            }
            if(int.Parse(loanSumTextBox.Text)<=0)
            {
                MessageBox.Show("loan sum must be positive");
                return;
            }
            if(int.Parse(loanSumTextBox.Text)<0)
            {
                MessageBox.Show("Interest must not be negative");
                return;
            }
            loanIDTextBox.Text = id.ToString();
            returnedCheckBox.Checked = false;

            while(clientsListBox.Items.Count>0)
            {
                loansToClientsBindingSource.AddNew();
                clientIDTextBox.Text = clientsListBox.Items[0].ToString();
                loanIDTextBox.Text = id.ToString();
                clientPartTextBox.Text = "0";
                clientsListBox.Items.RemoveAt(0);
            }

            loansBindingSource.EndEdit();
            loansTableAdapter.Fill(bankDBDataSet.Loans);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //TODO : check client ID existance
            clientsListBox.Items.Add(clientsComboBox.SelectedValue);
            

            /*loansToClientsBindingSource.EndEdit();
            loansToClientsTableAdapter.Fill(bankDBDataSet.LoansToClients);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loansBindingSource.AddNew();
        }
    }
}

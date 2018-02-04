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
    public partial class AddClientsAccounts : Form
    {
        public string Aid;
        DataView av;
        public AddClientsAccounts()
        {
            InitializeComponent();
        }

        private void clientsAndAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsAndAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void AddClientsAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TClients' table. You can move, or remove it, as needed.
            this.tClientsTableAdapter.Fill(this.bankDBDataSet.TClients);
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);
            // TODO: This line of code loads data into the 'bankDBDataSet.ClientsAndAccounts' table. You can move, or remove it, as needed.
            this.clientsAndAccountsTableAdapter.Fill(this.bankDBDataSet.ClientsAndAccounts);
            //timer1.Enabled = true;
            //timer1.Interval = 1000;
            clientIDTextBox.Visible = false;
            accountIDTextBox.Enabled = false;
            accountIDTextBox.Text = "1";
            DataView dv = new DataView(bankDBDataSet.ClientsAndAccounts);
            dv.RowFilter = "AccountID='" + Aid + "'";
            clientsAndAccountsDataGridView.DataSource = dv;
            /*av= new DataView(bankDBDataSet.TClients);
            comboBox1.DataSource = av;
            comboBox1.DisplayMember = "ClientID";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientsAndAccountsBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientsAndAccountsBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientsAndAccountsBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientsAndAccountsBindingSource.MoveLast();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            av = new DataView(bankDBDataSet.TClients);
            av.RowFilter = "ClientName='"+textBox1.Text+"'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clientsAndAccountsBindingSource.AddNew();
            accountIDTextBox.Text = Aid;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clientsAndAccountsBindingSource.EndEdit();
            clientsAndAccountsTableAdapter.Update(this.bankDBDataSet.ClientsAndAccounts);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("id selected: "+comboBox1.SelectedValue.ToString());
            clientIDTextBox.Text = comboBox1.SelectedValue.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainPage m = new MainPage();
            this.Hide();
            m.ShowDialog();
            this.Close();
        }
    }
}

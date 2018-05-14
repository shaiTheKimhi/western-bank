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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void stocksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stocksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.bankDBDataSet.Stocks);
            // TODO: This line of code loads data into the 'bankDBDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.bankDBDataSet.Stocks);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            stocksBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stocksBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stocksBindingSource.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stocksBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stocksBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stocksBindingSource.EndEdit();
            stocksTableAdapter.Update(bankDBDataSet.Stocks);
            stocksDataGridView.Refresh();

        }

        private void stocksBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.stocksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void stockIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if((c < '0' || c > '9') && c != '\b')
            {
                MessageBox.Show("הינך חייב להכניס ספרות בלבד");
                e.Handled = true;
            }
        }
    }
}

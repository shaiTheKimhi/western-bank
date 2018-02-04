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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void tClientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tClientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TClients' table. You can move, or remove it, as needed.
            this.tClientsTableAdapter.Fill(this.bankDBDataSet.TClients);
            button1.Visible = true;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tClientsBindingSource.AddNew();
            button2.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<tClientsDataGridView.Rows.Count-2;i++)
            {
                if(clientIDTextBox.Text==tClientsDataGridView.Rows[i].Cells[0].FormattedValue.ToString())
                {
                    MessageBox.Show("client already exists");
                    return;
                }
            }
            tClientsBindingSource.EndEdit();
            tClientsTableAdapter.Update(this.bankDBDataSet.TClients);
            button1.Visible = true;
            button2.Visible = false;
        }

        private void clientIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<'0'||e.KeyChar>'9'&&e.KeyChar!='\b')
            {
                e.Handled = true;
                MessageBox.Show("id must contain numbers only");
            }
        }

        private void clientNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 'a' && e.KeyChar <= 'z')||(e.KeyChar>='A'&&e.KeyChar<='Z')||e.KeyChar==' '||e.KeyChar=='\b')
            {
                
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("you must enter letters");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tClientsBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tClientsBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tClientsBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tClientsBindingSource.MoveLast();
        }
    }
}

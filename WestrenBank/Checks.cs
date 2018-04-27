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
    public partial class Checks : Form
    {
        public Checks()
        {
            InitializeComponent();
        }

        private void checksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.checksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void Checks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.Checks' table. You can move, or remove it, as needed.
            this.checksTableAdapter.Fill(this.bankDBDataSet.Checks);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checksBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checksBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checksBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checksBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checksBindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            button6.Visible = false;
            checksBindingSource.AddNew();
            isValidCheckBox.CheckState = CheckState.Checked;
            isValidCheckBox.Checked = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            button7.Visible = false;
            //TODO : check values that were entered
            checksBindingSource.EndEdit();
            checksTableAdapter.Update(bankDBDataSet.Checks);
        }

        private void isValidCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void giverIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void giverIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void getterIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void getterIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void isValidLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try {
                checksBindingSource.EndEdit();
                checksTableAdapter.Update(bankDBDataSet.Checks);
            }
            catch { ; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            (checksDataGridView.DataSource as BindingSource).Filter = "GiverID=" + textBox1.Text;
        }
    }
}

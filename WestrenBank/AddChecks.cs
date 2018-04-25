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
    public partial class AddChecks : Form
    {
        public int CHECKS_TO_ADD = 10;
        public string accountID = null;
        public AddChecks()
        {
            InitializeComponent();
        }

        private void AddChecks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.Checks' table. You can move, or remove it, as needed.
            this.checksTableAdapter.Fill(this.bankDBDataSet.Checks);

            if(accountID != null)
                for(int i = 0; i<CHECKS_TO_ADD; i++)
                {
                    AddCheck();
                }
            this.Close();
        }

        private void checksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.checksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }
        private void AddCheck()
        {
            checksBindingSource.AddNew();
            giverIDTextBox.Text = accountID;
            isValidCheckBox.Checked = true;
            checksBindingSource.EndEdit();
            checksTableAdapter.Update(bankDBDataSet.Checks);
        }
    }
}

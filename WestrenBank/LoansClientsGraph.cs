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
    public partial class LoansClientsGraph : Form
    {
        public LoansClientsGraph()
        {
            InitializeComponent();
        }

        private void LoansClientsGraph_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.client_loans1' table. You can move, or remove it, as needed.
            this.client_loans1TableAdapter.Fill(this.bankDBDataSet.client_loans1);

        }
    }
}

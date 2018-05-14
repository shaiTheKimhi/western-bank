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
    public partial class ComissionsGraph : Form
    {
        public ComissionsGraph()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Visible = !chart1.Visible;
            button1.Text = chart1.Visible ? "Hide" : "Show";
        }

        private void ComissionsGraph_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.commissions_sum' table. You can move, or remove it, as needed.
            this.commissions_sumTableAdapter.Fill(this.bankDBDataSet.commissions_sum);

        }
    }
}

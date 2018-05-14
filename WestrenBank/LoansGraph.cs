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
    public partial class LoansGraph : Form
    {
        public LoansGraph()
        {
            InitializeComponent();
        }

        private void LoansGraph_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.loans_sum' table. You can move, or remove it, as needed.
            this.loans_sumTableAdapter.Fill(this.bankDBDataSet.loans_sum);
            chart1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(chart1.Visible)
            {
                chart1.Visible = false;
                button1.Text = "Show";
            }
            else
            {
                chart1.Visible = true;
                button1.Text = "Hide";
            }
        }
    }
}

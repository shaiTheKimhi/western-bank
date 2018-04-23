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
    public partial class ReportsAndGraphs : Form
    {
        public ReportsAndGraphs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportsAccounts f = new ReportsAccounts();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportTransfer rt = new ReportTransfer();
            this.Hide();
            rt.ShowDialog();
            this.Close();
        }
    }
}

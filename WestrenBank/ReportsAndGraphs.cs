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

        private void button3_Click(object sender, EventArgs e)
        {
            AccountDebts f = new AccountDebts();
            this.Hide();
            f.ShowDialog();
            f.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoansGraph f = new LoansGraph();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoansClientsGraph f = new LoansClientsGraph();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ComissionsGraph f = new ComissionsGraph();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccountLoans f = new AccountLoans();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CommissionsReport f = new CommissionsReport();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}

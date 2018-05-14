using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WestrenBank
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddClientsAccounts aca = new AddClientsAccounts();
            aca.Aid = "1";
            aca.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleAccounts ha = new HandleAccounts();
            ha.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleChecks hc = new HandleChecks();
            hc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transfers t = new Transfers();
            t.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportsAndGraphs f = new ReportsAndGraphs();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddLoan2 l = new AddLoan2();
            l.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stocks f = new Stocks();
            f.ShowDialog();
        }
    }
}

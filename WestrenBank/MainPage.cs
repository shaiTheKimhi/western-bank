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
            this.Hide();
            aca.Aid = "1";
            aca.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleAccounts ha = new HandleAccounts();
            this.Hide();
            ha.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleChecks hc = new HandleChecks();
            this.Hide();
            hc.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transfers t = new Transfers();
            this.Hide();
            t.ShowDialog();
            this.Close();
        }
    }
}

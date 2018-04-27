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
    public partial class HandleChecks : Form
    {
        public HandleChecks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checks cf = new Checks();
            this.Hide();
            cf.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deposits d = new Deposits();
            this.Hide();
            d.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepositChecks f = new DepositChecks();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}

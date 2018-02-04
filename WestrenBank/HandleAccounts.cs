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
    public partial class HandleAccounts : Form
    {
        public HandleAccounts()
        {
            InitializeComponent();
        }

        private void HandleAccounts_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddAccount ad = new AddAccount();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WatchAccount wa = new WatchAccount();
            this.Hide();
            wa.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddClient ac = new AddClient();
            this.Hide();
            ac.ShowDialog();
            this.Close();
        }


    }
}

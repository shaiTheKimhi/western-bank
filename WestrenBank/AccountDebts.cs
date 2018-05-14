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
    public partial class AccountDebts : Form
    {
        const int LINE = 22;
        public AccountDebts()
        {
            InitializeComponent();
        }

        private void AccountDebts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.client_loans1' table. You can move, or remove it, as needed.
            this.client_loans1TableAdapter.Fill(this.bankDBDataSet.client_loans1);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int w = 100, h = 200;
            int i = 0, j = 0;
            int total = 0;
            Pen p = new Pen(Brushes.Black, 2.5f);
            //Printing title
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Blue, new Point(0, 0));
            e.Graphics.DrawString("דוח חשבונות - חובות", new Font("Ariel", 30, FontStyle.Bold), Brushes.Blue, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(500, 150));
            //printing columns titles
            for (i = 0; i < client_loans1DataGridView.Columns.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(w, h, client_loans1DataGridView.Columns[i].Width, client_loans1DataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(w, h, client_loans1DataGridView.Columns[0].Width, client_loans1DataGridView.Rows[0].Height));
                e.Graphics.DrawString(client_loans1DataGridView.Columns[i].HeaderText.ToString(), client_loans1DataGridView.Font, Brushes.Black, new Rectangle(w, h, client_loans1DataGridView.Columns[0].Width, client_loans1DataGridView.Rows[0].Height));
                w += 100;
            }
            //printing table content
            for (i = 0; i < client_loans1DataGridView.Rows.Count - 1; i++)
            {
                w = 100; h += LINE;
                int money = int.Parse(client_loans1DataGridView.Rows[i].Cells[1].FormattedValue.ToString());
                if (money > 0)
                    total += money;
                for (j = 0; j < client_loans1DataGridView.Columns.Count; j++)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(w, h, client_loans1DataGridView.Columns[0].Width, client_loans1DataGridView.Rows[0].Height));
                    e.Graphics.DrawString(client_loans1DataGridView.Rows[i].Cells[j].FormattedValue.ToString()
                        , client_loans1DataGridView.Font
                        , Brushes.Black
                        , new Rectangle(w, h, client_loans1DataGridView.Columns[0].Width, client_loans1DataGridView.Rows[0].Height));
                    w += 100;
                }
            }
            string str = "סך החובות לבנק:";
            str += total;
            e.Graphics.DrawString(str, new Font("Ariel", 15, FontStyle.Italic), Brushes.Black, new Point(100, h + 30));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            pageSetupDialog1.ShowDialog();
        }
    }
}

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
    public partial class ReportsAccounts : Form
    {
        const int LINE = 22;
        public ReportsAccounts()
        {
            InitializeComponent();
        }

        private void tAccountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAccountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void ReportsAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int debts = 0, money = 0;
            int i = 0, j;
            int w = 100, h = 200;
            Pen p = new Pen(Brushes.Black, 2.5f);
            //Printing title
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Blue, new Point(0, 0));
            e.Graphics.DrawString("דוח חשבונות", new Font("Ariel", 30, FontStyle.Bold), Brushes.Blue, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(500, 150));
            //printing columns titles
            for(i = 0; i < tAccountsDataGridView.Columns.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(w, h, tAccountsDataGridView.Columns[i].Width, tAccountsDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(w, h, tAccountsDataGridView.Columns[0].Width, tAccountsDataGridView.Rows[0].Height));
                e.Graphics.DrawString(tAccountsDataGridView.Columns[i].HeaderText.ToString(), tAccountsDataGridView.Font, Brushes.Black, new Rectangle(w, h, tAccountsDataGridView.Columns[0].Width, tAccountsDataGridView.Rows[0].Height));
                w += 100;
            }
            //printing table content
            for(i = 0; i < tAccountsDataGridView.Rows.Count - 1; i++)
            {
                w = 100; h += LINE;
                try
                {
                    int current = int.Parse(tAccountsDataGridView.Rows[i].Cells[3].FormattedValue.ToString());
                    money += current;
                    if (current < 0)
                        debts -= current;
                }
                catch {; }
                for(j = 0; j < tAccountsDataGridView.Columns.Count; j++)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(w, h, tAccountsDataGridView.Columns[0].Width, tAccountsDataGridView.Rows[0].Height));
                    e.Graphics.DrawString(tAccountsDataGridView.Rows[i].Cells[j].FormattedValue.ToString()
                        , tAccountsDataGridView.Font
                        , Brushes.Black
                        , new Rectangle(w, h, tAccountsDataGridView.Columns[0].Width, tAccountsDataGridView.Rows[0].Height));
                    w += 100;
                }
            }
            string str = "סך הכסף:";
            str += money;
            e.Graphics.DrawString(str, new Font("Ariel", 15, FontStyle.Italic), Brushes.Black, new Point(100, h + 30));
            str = "סך החובות לבנק:";
            str += debts;
            e.Graphics.DrawString(str, new Font("Ariel", 15, FontStyle.Italic), Brushes.Black, new Point(100, h + 30 + LINE));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }
    }
}

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
    public partial class StocksReport : Form
    {
        const int LINE = 22;
        public StocksReport()
        {
            InitializeComponent();
        }

        private void stocksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stocksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void StocksReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.bankDBDataSet.Stocks);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int w = 100, h = 200;
            int i = 0, j = 0;
            Pen p = new Pen(Brushes.Black, 2.5f);
            //Printing title
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Blue, new Point(0, 0));
            e.Graphics.DrawString("דוח חשבונות - חובות", new Font("Ariel", 30, FontStyle.Bold), Brushes.Blue, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(500, 150));
            //printing columns titles
            for (i = 0; i < stocksDataGridView.Columns.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(w, h, stocksDataGridView.Columns[i].Width, stocksDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(w, h, stocksDataGridView.Columns[0].Width, stocksDataGridView.Rows[0].Height));
                e.Graphics.DrawString(stocksDataGridView.Columns[i].HeaderText.ToString(), stocksDataGridView.Font, Brushes.Black, new Rectangle(w, h, stocksDataGridView.Columns[0].Width, stocksDataGridView.Rows[0].Height));
                w += 100;
            }
            //printing table content
            for (i = 0; i < stocksDataGridView.Rows.Count - 1; i++)
            {
                w = 100; h += LINE;
                for (j = 0; j < stocksDataGridView.Columns.Count; j++)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(w, h, stocksDataGridView.Columns[0].Width, stocksDataGridView.Rows[0].Height));
                    e.Graphics.DrawString(stocksDataGridView.Rows[i].Cells[j].FormattedValue.ToString()
                        , stocksDataGridView.Font
                        , Brushes.Black
                        , new Rectangle(w, h, stocksDataGridView.Columns[0].Width, stocksDataGridView.Rows[0].Height));
                    w += 100;
                }
            }
        }
    }
}

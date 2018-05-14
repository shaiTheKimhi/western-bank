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
    public partial class ReportTransfer : Form
    {
        const int LINE = 22;
        string username = "";
        string gr = "";
        public ReportTransfer()
        {
            InitializeComponent();
        }

        private void transfersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transfersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void ReportTransfer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);
            // TODO: This line of code loads data into the 'bankDBDataSet.Transfers' table. You can move, or remove it, as needed.
            this.transfersTableAdapter.Fill(this.bankDBDataSet.Transfers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gr = "";
            if (comboBox1.SelectedItem == null || comboBox2.SelectedValue == null)
            {
                MessageBox.Show("אתה חייב לבחור שם והאם הלקוח שהינך מחפש הוא נותן ההעברה או המקבל");
                return;
            }
            if (comboBox1.SelectedItem.ToString() == "נותן")
                gr = "SenderAccountID";
            else if (comboBox1.SelectedItem.ToString() == "מקבל")
                gr = "RecieverAccountID";
            
            (transfersDataGridView.DataSource as BindingSource).Filter = gr + " =" + comboBox2.SelectedValue.ToString();
            this.username = comboBox2.SelectedValue.ToString();
            this.gr = gr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(username == "")
            {
                MessageBox.Show("הינך חייב להכניס שם לקוח שתדפיס העברות עבורו");
                return;
            }
            username = comboBox2.SelectedText;
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int money = 0;
            int i = 0, j;
            int w = 100, h = 200;
            Pen p = new Pen(Brushes.Black, 2.5f);
            //Printing title
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Blue, new Point(0, 0));
            e.Graphics.DrawString("דוח העברות", new Font("Ariel", 30, FontStyle.Bold), Brushes.Blue, new Point(300, 100));
            e.Graphics.DrawLine(p, new Point(300, 150), new Point(500, 150));
            //printing columns titles
            for (i = 0; i < transfersDataGridView.Columns.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(w, h, transfersDataGridView.Columns[i].Width, transfersDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(w, h, transfersDataGridView.Columns[0].Width, transfersDataGridView.Rows[0].Height));
                e.Graphics.DrawString(transfersDataGridView.Columns[i].HeaderText.ToString(), transfersDataGridView.Font, Brushes.Black, new Rectangle(w, h, transfersDataGridView.Columns[0].Width, transfersDataGridView.Rows[0].Height));
                w += 100;
            }
            //printing table content
            for (i = 0; i < transfersDataGridView.Rows.Count - 1; i++)
            {
                w = 100; h += LINE;
                try
                {
                    money += int.Parse(transfersDataGridView.Rows[i].Cells[3].FormattedValue.ToString());
                }
                catch {; }
                for (j = 0; j < transfersDataGridView.Columns.Count; j++)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(w, h, transfersDataGridView.Columns[0].Width, transfersDataGridView.Rows[0].Height));
                    e.Graphics.DrawString(transfersDataGridView.Rows[i].Cells[j].FormattedValue.ToString()
                        , transfersDataGridView.Font
                        , Brushes.Black
                        , new Rectangle(w, h, transfersDataGridView.Columns[0].Width, transfersDataGridView.Rows[0].Height));
                    w += 100;
                }
            }
            string str = "שם הלקוח :" + this.username;
            e.Graphics.DrawString(str, new Font("Ariel", 15, FontStyle.Italic), Brushes.Black, new Point(100, h + 30));
            str = "העברות ";
            str += this.gr.Contains("ReciverAccountID") ? "נכנסות" : "יוצאות";
            str += ": ";
            str += money.ToString();
            e.Graphics.DrawString(str, new Font("Ariel", 15, FontStyle.Italic), Brushes.Black, new Point(100, h + 30 + LINE));

        }
    }
}

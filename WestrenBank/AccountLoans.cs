﻿using System;
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
    public partial class AccountLoans : Form
    {
        const int LINE = 22;
        public AccountLoans()
        {
            InitializeComponent();
        }

        private void loansToClientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loansToClientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void AccountLoans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);
            // TODO: This line of code loads data into the 'bankDBDataSet.LoansToClients' table. You can move, or remove it, as needed.
            this.loansToClientsTableAdapter.Fill(this.bankDBDataSet.LoansToClients);
            button1.Visible = false;

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
            for (i = 0; i < loansToClientsDataGridView.Columns.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(w, h, loansToClientsDataGridView.Columns[i].Width, loansToClientsDataGridView.Rows[0].Height));
                e.Graphics.DrawRectangle(p, new Rectangle(w, h, loansToClientsDataGridView.Columns[0].Width, loansToClientsDataGridView.Rows[0].Height));
                e.Graphics.DrawString(loansToClientsDataGridView.Columns[i].HeaderText.ToString(), loansToClientsDataGridView.Font, Brushes.Black, new Rectangle(w, h, loansToClientsDataGridView.Columns[0].Width, loansToClientsDataGridView.Rows[0].Height));
                w += 100;
            }
            //printing table content
            for (i = 0; i < loansToClientsDataGridView.Rows.Count - 1; i++)
            {
                w = 100; h += LINE;

                for (j = 0; j < loansToClientsDataGridView.Columns.Count; j++)
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(w, h, loansToClientsDataGridView.Columns[0].Width, loansToClientsDataGridView.Rows[0].Height));
                    e.Graphics.DrawString(loansToClientsDataGridView.Rows[i].Cells[j].FormattedValue.ToString()
                        , loansToClientsDataGridView.Font
                        , Brushes.Black
                        , new Rectangle(w, h, loansToClientsDataGridView.Columns[0].Width, loansToClientsDataGridView.Rows[0].Height));
                    w += 100;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (loansToClientsDataGridView.DataSource as BindingSource).Filter = "AccountID = " + comboBox1.SelectedValue.ToString();
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            pageSetupDialog1.ShowDialog();
        }
    }
}

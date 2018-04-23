﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WestrenBank
{
    public partial class AddLoan2 : Form
    {
        public AddLoan2()
        {
            InitializeComponent();
        }

        private void loansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bankDBDataSet);

        }

        private void AddLoan2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDBDataSet.TAccounts' table. You can move, or remove it, as needed.
            this.tAccountsTableAdapter.Fill(this.bankDBDataSet.TAccounts);
            // TODO: This line of code loads data into the 'bankDBDataSet.LoansToClients' table. You can move, or remove it, as needed.
            this.loansToClientsTableAdapter.Fill(this.bankDBDataSet.LoansToClients);
            // TODO: This line of code loads data into the 'bankDBDataSet.Loans' table. You can move, or remove it, as needed.
            this.loansTableAdapter.Fill(this.bankDBDataSet.Loans);

            button3.Visible = false;
            comboBox1.Visible = false;
            listBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loansBindingSource.AddNew();

            button3.Visible = true;
            comboBox1.Visible = true;
            listBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int money = 0;
            foreach(string id in listBox1.Items)
            {
                (tAccountsDataGridView.DataSource as BindingSource).Filter = "AccountID = " + id;
                //credit frame + current = avaliable money
                money += int.Parse(creditFrameTextBox.Text) + int.Parse(currentTextBox.Text);
            }
            if(money < int.Parse(loanSumTextBox.Text))
            {
                MessageBox.Show("אין ללקוחות די כסף בשביל ההלוואה");
                return;
            }
            loanStartDateDateTimePicker.Value = DateTime.Now;
            if((loanEndDateDateTimePicker.Value - loanStartDateDateTimePicker.Value).TotalDays < 1)
            {
                MessageBox.Show("תאריך סיום ההלוואה חייב להיות מאוחר מהיום");
                return;
            }

            loansBindingSource.EndEdit();
            loansTableAdapter.Update(bankDBDataSet.Loans);
            Thread.Sleep(100);

            foreach(string id in listBox1.Items)
            {
                loansToClientsBindingSource.AddNew();
                loanIDTextBox1.Text = (int.Parse(loansDataGridView.Rows[loansDataGridView.Rows.Count - 2].Cells[0].FormattedValue.ToString()) + 1).ToString();
                clientIDTextBox.Text = id;
                clientPartTextBox.Text = "0";
                loansToClientsBindingSource.EndEdit();
                loansToClientsTableAdapter.Update(bankDBDataSet.LoansToClients);
            }

            button3.Visible = false;
            comboBox1.Visible = false;
            listBox1.Visible = false;
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!listBox1.Items.Contains(comboBox1.SelectedValue.ToString()))
                listBox1.Items.Add(comboBox1.SelectedValue.ToString());
        }
    }
}

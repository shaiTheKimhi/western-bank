﻿namespace WestrenBank
{
    partial class Checks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label checkIDLabel;
            System.Windows.Forms.Label giverIDLabel;
            System.Windows.Forms.Label isValidLabel;
            this.checksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDBDataSet = new WestrenBank.BankDBDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checksTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.ChecksTableAdapter();
            this.tableAdapterManager = new WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.checkIDTextBox = new System.Windows.Forms.TextBox();
            this.giverIDTextBox = new System.Windows.Forms.TextBox();
            this.isValidCheckBox = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            checkIDLabel = new System.Windows.Forms.Label();
            giverIDLabel = new System.Windows.Forms.Label();
            isValidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // checksDataGridView
            // 
            this.checksDataGridView.AutoGenerateColumns = false;
            this.checksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.checksDataGridView.DataSource = this.checksBindingSource;
            this.checksDataGridView.Location = new System.Drawing.Point(0, 150);
            this.checksDataGridView.Name = "checksDataGridView";
            this.checksDataGridView.Size = new System.Drawing.Size(558, 220);
            this.checksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CheckID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CheckID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GiverID";
            this.dataGridViewTextBoxColumn2.HeaderText = "GiverID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsValid";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsValid";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // checksBindingSource
            // 
            this.checksBindingSource.DataMember = "Checks";
            this.checksBindingSource.DataSource = this.bankDBDataSet;
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "down";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "first";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checksTableAdapter
            // 
            this.checksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChecksTableAdapter = this.checksTableAdapter;
            this.tableAdapterManager.ClientsAndAccountsTableAdapter = null;
            this.tableAdapterManager.CommissionsTableAdapter = null;
            this.tableAdapterManager.DepositsTableAdapter = null;
            this.tableAdapterManager.ExecutionTableAdapter = null;
            this.tableAdapterManager.InterestCollectionTableAdapter = null;
            this.tableAdapterManager.LoansTableAdapter = null;
            this.tableAdapterManager.LoansToClientsTableAdapter = null;
            this.tableAdapterManager.StocksAndAccountsTableAdapter = null;
            this.tableAdapterManager.StocksTableAdapter = null;
            this.tableAdapterManager.TAccountsTableAdapter = null;
            this.tableAdapterManager.TClientsTableAdapter = null;
            this.tableAdapterManager.TransfersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WithrawalsTableAdapter = null;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(365, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(365, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(365, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(365, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "update";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // checkIDLabel
            // 
            checkIDLabel.AutoSize = true;
            checkIDLabel.Location = new System.Drawing.Point(15, 15);
            checkIDLabel.Name = "checkIDLabel";
            checkIDLabel.Size = new System.Drawing.Size(55, 13);
            checkIDLabel.TabIndex = 9;
            checkIDLabel.Text = "Check ID:";
            // 
            // checkIDTextBox
            // 
            this.checkIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checksBindingSource, "CheckID", true));
            this.checkIDTextBox.Location = new System.Drawing.Point(76, 12);
            this.checkIDTextBox.Name = "checkIDTextBox";
            this.checkIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.checkIDTextBox.TabIndex = 10;
            // 
            // giverIDLabel
            // 
            giverIDLabel.AutoSize = true;
            giverIDLabel.Location = new System.Drawing.Point(15, 41);
            giverIDLabel.Name = "giverIDLabel";
            giverIDLabel.Size = new System.Drawing.Size(49, 13);
            giverIDLabel.TabIndex = 11;
            giverIDLabel.Text = "Giver ID:";
            // 
            // giverIDTextBox
            // 
            this.giverIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checksBindingSource, "GiverID", true));
            this.giverIDTextBox.Location = new System.Drawing.Point(76, 38);
            this.giverIDTextBox.Name = "giverIDTextBox";
            this.giverIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.giverIDTextBox.TabIndex = 12;
            // 
            // isValidLabel
            // 
            isValidLabel.AutoSize = true;
            isValidLabel.Location = new System.Drawing.Point(15, 69);
            isValidLabel.Name = "isValidLabel";
            isValidLabel.Size = new System.Drawing.Size(44, 13);
            isValidLabel.TabIndex = 13;
            isValidLabel.Text = "Is Valid:";
            // 
            // isValidCheckBox
            // 
            this.isValidCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.checksBindingSource, "IsValid", true));
            this.isValidCheckBox.Location = new System.Drawing.Point(76, 64);
            this.isValidCheckBox.Name = "isValidCheckBox";
            this.isValidCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isValidCheckBox.TabIndex = 14;
            this.isValidCheckBox.Text = "checkBox1";
            this.isValidCheckBox.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(214, 40);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "search";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // Checks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 390);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(checkIDLabel);
            this.Controls.Add(this.checkIDTextBox);
            this.Controls.Add(giverIDLabel);
            this.Controls.Add(this.giverIDTextBox);
            this.Controls.Add(isValidLabel);
            this.Controls.Add(this.isValidCheckBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checksDataGridView);
            this.Name = "Checks";
            this.Text = "Checks";
            this.Load += new System.EventHandler(this.Checks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource checksBindingSource;
        private BankDBDataSetTableAdapters.ChecksTableAdapter checksTableAdapter;
        private BankDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView checksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox checkIDTextBox;
        private System.Windows.Forms.TextBox giverIDTextBox;
        private System.Windows.Forms.CheckBox isValidCheckBox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
    }
}
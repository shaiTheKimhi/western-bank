namespace WestrenBank
{
    partial class AccountLoans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountLoans));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.bankDBDataSet = new WestrenBank.BankDBDataSet();
            this.loansToClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loansToClientsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.LoansToClientsTableAdapter();
            this.tableAdapterManager = new WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager();
            this.tAccountsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.TAccountsTableAdapter();
            this.loansToClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansToClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansToClientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loansToClientsBindingSource
            // 
            this.loansToClientsBindingSource.DataMember = "LoansToClients";
            this.loansToClientsBindingSource.DataSource = this.bankDBDataSet;
            // 
            // loansToClientsTableAdapter
            // 
            this.loansToClientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChecksTableAdapter = null;
            this.tableAdapterManager.ClientsAndAccountsTableAdapter = null;
            this.tableAdapterManager.CommissionsTableAdapter = null;
            this.tableAdapterManager.DepositsTableAdapter = null;
            this.tableAdapterManager.ExecutionTableAdapter = null;
            this.tableAdapterManager.InterestCollectionTableAdapter = null;
            this.tableAdapterManager.LoansTableAdapter = null;
            this.tableAdapterManager.LoansToClientsTableAdapter = this.loansToClientsTableAdapter;
            this.tableAdapterManager.StocksAndAccountsTableAdapter = null;
            this.tableAdapterManager.StocksTableAdapter = null;
            this.tableAdapterManager.TAccountsTableAdapter = this.tAccountsTableAdapter;
            this.tableAdapterManager.TClientsTableAdapter = null;
            this.tableAdapterManager.TransfersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WithrawalsTableAdapter = null;
            // 
            // tAccountsTableAdapter
            // 
            this.tAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // loansToClientsDataGridView
            // 
            this.loansToClientsDataGridView.AutoGenerateColumns = false;
            this.loansToClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loansToClientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.loansToClientsDataGridView.DataSource = this.loansToClientsBindingSource;
            this.loansToClientsDataGridView.Location = new System.Drawing.Point(12, 52);
            this.loansToClientsDataGridView.Name = "loansToClientsDataGridView";
            this.loansToClientsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.loansToClientsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LoanID";
            this.dataGridViewTextBoxColumn1.HeaderText = "LoanID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AccountID";
            this.dataGridViewTextBoxColumn3.HeaderText = "AccountID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "תצוגה מוקדמת";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "חיפוש לפי חשבון";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tAccountsBindingSource;
            this.comboBox1.DisplayMember = "username";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "AccountID";
            // 
            // tAccountsBindingSource
            // 
            this.tAccountsBindingSource.DataMember = "TAccounts";
            this.tAccountsBindingSource.DataSource = this.bankDBDataSet;
            // 
            // AccountLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 316);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loansToClientsDataGridView);
            this.Name = "AccountLoans";
            this.Text = "AccountLoans";
            this.Load += new System.EventHandler(this.AccountLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansToClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansToClientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource loansToClientsBindingSource;
        private BankDBDataSetTableAdapters.LoansToClientsTableAdapter loansToClientsTableAdapter;
        private BankDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView loansToClientsDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BankDBDataSetTableAdapters.TAccountsTableAdapter tAccountsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tAccountsBindingSource;
    }
}
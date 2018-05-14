namespace WestrenBank
{
    partial class AccountDebts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDebts));
            this.client_loans1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_loans1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDBDataSet = new WestrenBank.BankDBDataSet();
            this.client_loans1TableAdapter = new WestrenBank.BankDBDataSetTableAdapters.client_loans1TableAdapter();
            this.tableAdapterManager = new WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.client_loans1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_loans1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // client_loans1DataGridView
            // 
            this.client_loans1DataGridView.AutoGenerateColumns = false;
            this.client_loans1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_loans1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.client_loans1DataGridView.DataSource = this.client_loans1BindingSource;
            this.client_loans1DataGridView.Location = new System.Drawing.Point(12, 71);
            this.client_loans1DataGridView.Name = "client_loans1DataGridView";
            this.client_loans1DataGridView.Size = new System.Drawing.Size(300, 220);
            this.client_loans1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AccountID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn2.HeaderText = "total";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // client_loans1BindingSource
            // 
            this.client_loans1BindingSource.DataMember = "client_loans1";
            this.client_loans1BindingSource.DataSource = this.bankDBDataSet;
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // client_loans1TableAdapter
            // 
            this.client_loans1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChecksTableAdapter = null;
            this.tableAdapterManager.ClientsAndAccountsTableAdapter = null;
            this.tableAdapterManager.CommissionsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "תצוגה מוקדמת";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.client_loans1DataGridView);
            this.Name = "AccountDebts";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AccountDebts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.client_loans1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_loans1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource client_loans1BindingSource;
        private BankDBDataSetTableAdapters.client_loans1TableAdapter client_loans1TableAdapter;
        private BankDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView client_loans1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
    }
}
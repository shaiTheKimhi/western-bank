namespace WestrenBank
{
    partial class BuyStock
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
            this.bankDBDataSet = new WestrenBank.BankDBDataSet();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.StocksTableAdapter();
            this.tableAdapterManager = new WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager();
            this.stocksAndAccountsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.StocksAndAccountsTableAdapter();
            this.stocksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocksAndAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksAndAccountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAccountsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.TAccountsTableAdapter();
            this.tAccountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.creditFrameTextBox = new System.Windows.Forms.TextBox();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.stockAvaliableAmountTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.accountIDTextBox = new System.Windows.Forms.TextBox();
            this.stockIDTextBox = new System.Windows.Forms.TextBox();
            this.stocksAmountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksAndAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksAndAccountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.bankDBDataSet;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LoansToClientsTableAdapter = null;
            this.tableAdapterManager.StocksAndAccountsTableAdapter = this.stocksAndAccountsTableAdapter;
            this.tableAdapterManager.StocksTableAdapter = this.stocksTableAdapter;
            this.tableAdapterManager.TAccountsTableAdapter = null;
            this.tableAdapterManager.TClientsTableAdapter = null;
            this.tableAdapterManager.TransfersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WithrawalsTableAdapter = null;
            // 
            // stocksAndAccountsTableAdapter
            // 
            this.stocksAndAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // stocksDataGridView
            // 
            this.stocksDataGridView.AutoGenerateColumns = false;
            this.stocksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.stocksDataGridView.DataSource = this.stocksBindingSource;
            this.stocksDataGridView.Location = new System.Drawing.Point(12, 114);
            this.stocksDataGridView.Name = "stocksDataGridView";
            this.stocksDataGridView.Size = new System.Drawing.Size(447, 220);
            this.stocksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StockID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StockID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StockName";
            this.dataGridViewTextBoxColumn2.HeaderText = "StockName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StockAvaliableAmount";
            this.dataGridViewTextBoxColumn3.HeaderText = "StockAvaliableAmount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // stocksAndAccountsBindingSource
            // 
            this.stocksAndAccountsBindingSource.DataMember = "StocksAndAccounts";
            this.stocksAndAccountsBindingSource.DataSource = this.bankDBDataSet;
            // 
            // stocksAndAccountsDataGridView
            // 
            this.stocksAndAccountsDataGridView.AutoGenerateColumns = false;
            this.stocksAndAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocksAndAccountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.stocksAndAccountsDataGridView.DataSource = this.stocksAndAccountsBindingSource;
            this.stocksAndAccountsDataGridView.Location = new System.Drawing.Point(517, 114);
            this.stocksAndAccountsDataGridView.Name = "stocksAndAccountsDataGridView";
            this.stocksAndAccountsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.stocksAndAccountsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AccountID";
            this.dataGridViewTextBoxColumn5.HeaderText = "AccountID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StockID";
            this.dataGridViewTextBoxColumn6.HeaderText = "StockID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StocksAmount";
            this.dataGridViewTextBoxColumn7.HeaderText = "StocksAmount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.stocksBindingSource;
            this.comboBox1.DisplayMember = "StockName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(327, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "StockID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Amount";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tAccountsBindingSource
            // 
            this.tAccountsBindingSource.DataMember = "TAccounts";
            this.tAccountsBindingSource.DataSource = this.bankDBDataSet;
            // 
            // tAccountsTableAdapter
            // 
            this.tAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // tAccountsDataGridView
            // 
            this.tAccountsDataGridView.AutoGenerateColumns = false;
            this.tAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAccountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.tAccountsDataGridView.DataSource = this.tAccountsBindingSource;
            this.tAccountsDataGridView.Location = new System.Drawing.Point(12, 353);
            this.tAccountsDataGridView.Name = "tAccountsDataGridView";
            this.tAccountsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tAccountsDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AccountID";
            this.dataGridViewTextBoxColumn8.HeaderText = "AccountID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn9.HeaderText = "username";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn10.HeaderText = "password";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "current";
            this.dataGridViewTextBoxColumn11.HeaderText = "current";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "creditFrame";
            this.dataGridViewTextBoxColumn12.HeaderText = "creditFrame";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "income";
            this.dataGridViewTextBoxColumn13.HeaderText = "income";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tAccountsBindingSource;
            this.comboBox2.DisplayMember = "username";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(327, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "AccountID";
            // 
            // creditFrameTextBox
            // 
            this.creditFrameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "creditFrame", true));
            this.creditFrameTextBox.Location = new System.Drawing.Point(327, 399);
            this.creditFrameTextBox.Name = "creditFrameTextBox";
            this.creditFrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditFrameTextBox.TabIndex = 8;
            // 
            // currentTextBox
            // 
            this.currentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "current", true));
            this.currentTextBox.Location = new System.Drawing.Point(327, 373);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentTextBox.TabIndex = 10;
            // 
            // stockAvaliableAmountTextBox
            // 
            this.stockAvaliableAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksBindingSource, "StockAvaliableAmount", true));
            this.stockAvaliableAmountTextBox.Location = new System.Drawing.Point(134, 51);
            this.stockAvaliableAmountTextBox.Name = "stockAvaliableAmountTextBox";
            this.stockAvaliableAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockAvaliableAmountTextBox.TabIndex = 11;
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksBindingSource, "Value", true));
            this.valueTextBox.Location = new System.Drawing.Point(134, 77);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 12;
            // 
            // accountIDTextBox
            // 
            this.accountIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksAndAccountsBindingSource, "AccountID", true));
            this.accountIDTextBox.Location = new System.Drawing.Point(690, 26);
            this.accountIDTextBox.Name = "accountIDTextBox";
            this.accountIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountIDTextBox.TabIndex = 13;
            // 
            // stockIDTextBox
            // 
            this.stockIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksAndAccountsBindingSource, "StockID", true));
            this.stockIDTextBox.Location = new System.Drawing.Point(690, 52);
            this.stockIDTextBox.Name = "stockIDTextBox";
            this.stockIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockIDTextBox.TabIndex = 15;
            // 
            // stocksAmountTextBox
            // 
            this.stocksAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksAndAccountsBindingSource, "StocksAmount", true));
            this.stocksAmountTextBox.Location = new System.Drawing.Point(690, 78);
            this.stocksAmountTextBox.Name = "stocksAmountTextBox";
            this.stocksAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.stocksAmountTextBox.TabIndex = 17;
            // 
            // BuyStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 652);
            this.Controls.Add(this.accountIDTextBox);
            this.Controls.Add(this.stockIDTextBox);
            this.Controls.Add(this.stocksAmountTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.stockAvaliableAmountTextBox);
            this.Controls.Add(this.currentTextBox);
            this.Controls.Add(this.creditFrameTextBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tAccountsDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stocksAndAccountsDataGridView);
            this.Controls.Add(this.stocksDataGridView);
            this.Name = "BuyStock";
            this.Text = "BuyStock";
            this.Load += new System.EventHandler(this.BuyStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksAndAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksAndAccountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private BankDBDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        private BankDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView stocksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BankDBDataSetTableAdapters.StocksAndAccountsTableAdapter stocksAndAccountsTableAdapter;
        private System.Windows.Forms.BindingSource stocksAndAccountsBindingSource;
        private System.Windows.Forms.DataGridView stocksAndAccountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tAccountsBindingSource;
        private BankDBDataSetTableAdapters.TAccountsTableAdapter tAccountsTableAdapter;
        private System.Windows.Forms.DataGridView tAccountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox creditFrameTextBox;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.TextBox stockAvaliableAmountTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox accountIDTextBox;
        private System.Windows.Forms.TextBox stockIDTextBox;
        private System.Windows.Forms.TextBox stocksAmountTextBox;
    }
}
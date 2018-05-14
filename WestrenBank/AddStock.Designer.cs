namespace WestrenBank
{
    partial class AddStock
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
            System.Windows.Forms.Label stockIDLabel;
            System.Windows.Forms.Label stockNameLabel;
            System.Windows.Forms.Label stockAvaliableAmountLabel;
            System.Windows.Forms.Label valueLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bankDBDataSet = new WestrenBank.BankDBDataSet();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.StocksTableAdapter();
            this.tableAdapterManager = new WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager();
            this.stocksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIDTextBox = new System.Windows.Forms.TextBox();
            this.stockNameTextBox = new System.Windows.Forms.TextBox();
            this.stockAvaliableAmountTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            stockIDLabel = new System.Windows.Forms.Label();
            stockNameLabel = new System.Windows.Forms.Label();
            stockAvaliableAmountLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Up";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(584, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "First";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(462, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Last";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(523, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Down";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            this.tableAdapterManager.StocksAndAccountsTableAdapter = null;
            this.tableAdapterManager.StocksTableAdapter = this.stocksTableAdapter;
            this.tableAdapterManager.TAccountsTableAdapter = null;
            this.tableAdapterManager.TClientsTableAdapter = null;
            this.tableAdapterManager.TransfersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WithrawalsTableAdapter = null;
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
            this.stocksDataGridView.Location = new System.Drawing.Point(12, 139);
            this.stocksDataGridView.Name = "stocksDataGridView";
            this.stocksDataGridView.Size = new System.Drawing.Size(444, 220);
            this.stocksDataGridView.TabIndex = 8;
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
            // stockIDLabel
            // 
            stockIDLabel.AutoSize = true;
            stockIDLabel.Location = new System.Drawing.Point(28, 18);
            stockIDLabel.Name = "stockIDLabel";
            stockIDLabel.Size = new System.Drawing.Size(52, 13);
            stockIDLabel.TabIndex = 8;
            stockIDLabel.Text = "Stock ID:";
            // 
            // stockIDTextBox
            // 
            this.stockIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksBindingSource, "StockID", true));
            this.stockIDTextBox.Location = new System.Drawing.Point(157, 15);
            this.stockIDTextBox.Name = "stockIDTextBox";
            this.stockIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockIDTextBox.TabIndex = 9;
            this.stockIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockIDTextBox_KeyPress);
            // 
            // stockNameLabel
            // 
            stockNameLabel.AutoSize = true;
            stockNameLabel.Location = new System.Drawing.Point(28, 44);
            stockNameLabel.Name = "stockNameLabel";
            stockNameLabel.Size = new System.Drawing.Size(69, 13);
            stockNameLabel.TabIndex = 10;
            stockNameLabel.Text = "Stock Name:";
            // 
            // stockNameTextBox
            // 
            this.stockNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksBindingSource, "StockName", true));
            this.stockNameTextBox.Location = new System.Drawing.Point(157, 41);
            this.stockNameTextBox.Name = "stockNameTextBox";
            this.stockNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockNameTextBox.TabIndex = 11;
            // 
            // stockAvaliableAmountLabel
            // 
            stockAvaliableAmountLabel.AutoSize = true;
            stockAvaliableAmountLabel.Location = new System.Drawing.Point(28, 70);
            stockAvaliableAmountLabel.Name = "stockAvaliableAmountLabel";
            stockAvaliableAmountLabel.Size = new System.Drawing.Size(123, 13);
            stockAvaliableAmountLabel.TabIndex = 12;
            stockAvaliableAmountLabel.Text = "Stock Avaliable Amount:";
            // 
            // stockAvaliableAmountTextBox
            // 
            this.stockAvaliableAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksBindingSource, "StockAvaliableAmount", true));
            this.stockAvaliableAmountTextBox.Location = new System.Drawing.Point(157, 67);
            this.stockAvaliableAmountTextBox.Name = "stockAvaliableAmountTextBox";
            this.stockAvaliableAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockAvaliableAmountTextBox.TabIndex = 13;
            this.stockAvaliableAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockIDTextBox_KeyPress);
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(28, 96);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(37, 13);
            valueLabel.TabIndex = 14;
            valueLabel.Text = "Value:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stocksBindingSource, "Value", true));
            this.valueTextBox.Location = new System.Drawing.Point(157, 93);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 15;
            this.valueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockIDTextBox_KeyPress);
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 418);
            this.Controls.Add(stockIDLabel);
            this.Controls.Add(this.stockIDTextBox);
            this.Controls.Add(stockNameLabel);
            this.Controls.Add(this.stockNameTextBox);
            this.Controls.Add(stockAvaliableAmountLabel);
            this.Controls.Add(this.stockAvaliableAmountTextBox);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.stocksDataGridView);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private BankDBDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        private BankDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView stocksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox stockIDTextBox;
        private System.Windows.Forms.TextBox stockNameTextBox;
        private System.Windows.Forms.TextBox stockAvaliableAmountTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
    }
}
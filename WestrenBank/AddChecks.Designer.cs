namespace WestrenBank
{
    partial class AddChecks
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
            this.bankDBDataSet = new WestrenBank.BankDBDataSet();
            this.checksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checksTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.ChecksTableAdapter();
            this.tableAdapterManager = new WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager();
            this.checksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkIDTextBox = new System.Windows.Forms.TextBox();
            this.giverIDTextBox = new System.Windows.Forms.TextBox();
            this.isValidCheckBox = new System.Windows.Forms.CheckBox();
            checkIDLabel = new System.Windows.Forms.Label();
            giverIDLabel = new System.Windows.Forms.Label();
            isValidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // checkIDLabel
            // 
            checkIDLabel.AutoSize = true;
            checkIDLabel.Location = new System.Drawing.Point(94, 11);
            checkIDLabel.Name = "checkIDLabel";
            checkIDLabel.Size = new System.Drawing.Size(55, 13);
            checkIDLabel.TabIndex = 1;
            checkIDLabel.Text = "Check ID:";
            // 
            // giverIDLabel
            // 
            giverIDLabel.AutoSize = true;
            giverIDLabel.Location = new System.Drawing.Point(94, 37);
            giverIDLabel.Name = "giverIDLabel";
            giverIDLabel.Size = new System.Drawing.Size(49, 13);
            giverIDLabel.TabIndex = 3;
            giverIDLabel.Text = "Giver ID:";
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checksBindingSource
            // 
            this.checksBindingSource.DataMember = "Checks";
            this.checksBindingSource.DataSource = this.bankDBDataSet;
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
            // checksDataGridView
            // 
            this.checksDataGridView.AutoGenerateColumns = false;
            this.checksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.checksDataGridView.DataSource = this.checksBindingSource;
            this.checksDataGridView.Location = new System.Drawing.Point(12, 93);
            this.checksDataGridView.Name = "checksDataGridView";
            this.checksDataGridView.Size = new System.Drawing.Size(368, 220);
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
            // checkIDTextBox
            // 
            this.checkIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checksBindingSource, "CheckID", true));
            this.checkIDTextBox.Location = new System.Drawing.Point(155, 8);
            this.checkIDTextBox.Name = "checkIDTextBox";
            this.checkIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.checkIDTextBox.TabIndex = 2;
            // 
            // giverIDTextBox
            // 
            this.giverIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checksBindingSource, "GiverID", true));
            this.giverIDTextBox.Location = new System.Drawing.Point(155, 34);
            this.giverIDTextBox.Name = "giverIDTextBox";
            this.giverIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.giverIDTextBox.TabIndex = 4;
            // 
            // isValidCheckBox
            // 
            this.isValidCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.checksBindingSource, "IsValid", true));
            this.isValidCheckBox.Location = new System.Drawing.Point(155, 60);
            this.isValidCheckBox.Name = "isValidCheckBox";
            this.isValidCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isValidCheckBox.TabIndex = 6;
            this.isValidCheckBox.Text = "checkBox1";
            this.isValidCheckBox.UseVisualStyleBackColor = true;
            // 
            // isValidLabel
            // 
            isValidLabel.AutoSize = true;
            isValidLabel.Location = new System.Drawing.Point(94, 65);
            isValidLabel.Name = "isValidLabel";
            isValidLabel.Size = new System.Drawing.Size(44, 13);
            isValidLabel.TabIndex = 5;
            isValidLabel.Text = "Is Valid:";
            // 
            // AddChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 333);
            this.Controls.Add(checkIDLabel);
            this.Controls.Add(this.checkIDTextBox);
            this.Controls.Add(giverIDLabel);
            this.Controls.Add(this.giverIDTextBox);
            this.Controls.Add(isValidLabel);
            this.Controls.Add(this.isValidCheckBox);
            this.Controls.Add(this.checksDataGridView);
            this.Name = "AddChecks";
            this.Text = "AddChecks";
            this.Load += new System.EventHandler(this.AddChecks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox checkIDTextBox;
        private System.Windows.Forms.TextBox giverIDTextBox;
        private System.Windows.Forms.CheckBox isValidCheckBox;
    }
}
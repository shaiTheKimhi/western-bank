namespace WestrenBank
{
    partial class DepositChecks
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
            this.tAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAccountsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.TAccountsTableAdapter();
            this.tableAdapterManager = new WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager();
            this.checksTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.ChecksTableAdapter();
            this.tAccountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.accountIDTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.creditFrameTextBox = new System.Windows.Forms.TextBox();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.checkIDTextBox = new System.Windows.Forms.TextBox();
            this.giverIDTextBox = new System.Windows.Forms.TextBox();
            this.isValidCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.TAccountsTableAdapter = this.tAccountsTableAdapter;
            this.tableAdapterManager.TClientsTableAdapter = null;
            this.tableAdapterManager.TransfersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WithrawalsTableAdapter = null;
            // 
            // checksTableAdapter
            // 
            this.checksTableAdapter.ClearBeforeFill = true;
            // 
            // tAccountsDataGridView
            // 
            this.tAccountsDataGridView.AutoGenerateColumns = false;
            this.tAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAccountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tAccountsDataGridView.DataSource = this.tAccountsBindingSource;
            this.tAccountsDataGridView.Location = new System.Drawing.Point(12, 141);
            this.tAccountsDataGridView.Name = "tAccountsDataGridView";
            this.tAccountsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tAccountsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AccountID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn2.HeaderText = "username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn3.HeaderText = "password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "current";
            this.dataGridViewTextBoxColumn4.HeaderText = "current";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "creditFrame";
            this.dataGridViewTextBoxColumn5.HeaderText = "creditFrame";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "income";
            this.dataGridViewTextBoxColumn6.HeaderText = "income";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // checksBindingSource
            // 
            this.checksBindingSource.DataMember = "Checks";
            this.checksBindingSource.DataSource = this.bankDBDataSet;
            // 
            // checksDataGridView
            // 
            this.checksDataGridView.AutoGenerateColumns = false;
            this.checksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.checksDataGridView.DataSource = this.checksBindingSource;
            this.checksDataGridView.Location = new System.Drawing.Point(456, 141);
            this.checksDataGridView.Name = "checksDataGridView";
            this.checksDataGridView.Size = new System.Drawing.Size(300, 220);
            this.checksDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CheckID";
            this.dataGridViewTextBoxColumn7.HeaderText = "CheckID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GiverID";
            this.dataGridViewTextBoxColumn8.HeaderText = "GiverID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsValid";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsValid";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // accountIDTextBox
            // 
            this.accountIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "AccountID", true));
            this.accountIDTextBox.Location = new System.Drawing.Point(252, 2);
            this.accountIDTextBox.Name = "accountIDTextBox";
            this.accountIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountIDTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(252, 28);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(252, 54);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // currentTextBox
            // 
            this.currentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "current", true));
            this.currentTextBox.Location = new System.Drawing.Point(252, 80);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentTextBox.TabIndex = 9;
            // 
            // creditFrameTextBox
            // 
            this.creditFrameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "creditFrame", true));
            this.creditFrameTextBox.Location = new System.Drawing.Point(252, 106);
            this.creditFrameTextBox.Name = "creditFrameTextBox";
            this.creditFrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditFrameTextBox.TabIndex = 11;
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "income", true));
            this.incomeTextBox.Location = new System.Drawing.Point(146, 107);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.incomeTextBox.TabIndex = 13;
            // 
            // checkIDTextBox
            // 
            this.checkIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checksBindingSource, "CheckID", true));
            this.checkIDTextBox.Location = new System.Drawing.Point(566, 50);
            this.checkIDTextBox.Name = "checkIDTextBox";
            this.checkIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.checkIDTextBox.TabIndex = 15;
            // 
            // giverIDTextBox
            // 
            this.giverIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checksBindingSource, "GiverID", true));
            this.giverIDTextBox.Location = new System.Drawing.Point(566, 76);
            this.giverIDTextBox.Name = "giverIDTextBox";
            this.giverIDTextBox.Size = new System.Drawing.Size(104, 20);
            this.giverIDTextBox.TabIndex = 17;
            // 
            // isValidCheckBox
            // 
            this.isValidCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.checksBindingSource, "IsValid", true));
            this.isValidCheckBox.Location = new System.Drawing.Point(566, 102);
            this.isValidCheckBox.Name = "isValidCheckBox";
            this.isValidCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isValidCheckBox.TabIndex = 19;
            this.isValidCheckBox.Text = "checkBox1";
            this.isValidCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "checkID";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(575, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "RecieverID";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(691, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "money";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DepositChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkIDTextBox);
            this.Controls.Add(this.giverIDTextBox);
            this.Controls.Add(this.isValidCheckBox);
            this.Controls.Add(this.accountIDTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.currentTextBox);
            this.Controls.Add(this.creditFrameTextBox);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.checksDataGridView);
            this.Controls.Add(this.tAccountsDataGridView);
            this.Name = "DepositChecks";
            this.Text = "DepositChecks";
            this.Load += new System.EventHandler(this.DepositChecks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource tAccountsBindingSource;
        private BankDBDataSetTableAdapters.TAccountsTableAdapter tAccountsTableAdapter;
        private BankDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BankDBDataSetTableAdapters.ChecksTableAdapter checksTableAdapter;
        private System.Windows.Forms.DataGridView tAccountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource checksBindingSource;
        private System.Windows.Forms.DataGridView checksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox accountIDTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.TextBox creditFrameTextBox;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.TextBox checkIDTextBox;
        private System.Windows.Forms.TextBox giverIDTextBox;
        private System.Windows.Forms.CheckBox isValidCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}
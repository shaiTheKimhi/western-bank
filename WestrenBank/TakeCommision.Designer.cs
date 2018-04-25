namespace WestrenBank
{
    partial class TakeCommision
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
            System.Windows.Forms.Label commissionIDLabel;
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label commissionSizeLabel;
            System.Windows.Forms.Label commissionDateLabel;
            System.Windows.Forms.Label accountIDLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label currentLabel;
            System.Windows.Forms.Label creditFrameLabel;
            System.Windows.Forms.Label incomeLabel;
            this.bankDBDataSet = new WestrenBank.BankDBDataSet();
            this.commissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commissionsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.CommissionsTableAdapter();
            this.tableAdapterManager = new WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager();
            this.commissionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAccountsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.TAccountsTableAdapter();
            this.tAccountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionIDTextBox = new System.Windows.Forms.TextBox();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.commissionSizeTextBox = new System.Windows.Forms.TextBox();
            this.commissionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.accountIDTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.creditFrameTextBox = new System.Windows.Forms.TextBox();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            commissionIDLabel = new System.Windows.Forms.Label();
            clientIDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            commissionSizeLabel = new System.Windows.Forms.Label();
            commissionDateLabel = new System.Windows.Forms.Label();
            accountIDLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            currentLabel = new System.Windows.Forms.Label();
            creditFrameLabel = new System.Windows.Forms.Label();
            incomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commissionsBindingSource
            // 
            this.commissionsBindingSource.DataMember = "Commissions";
            this.commissionsBindingSource.DataSource = this.bankDBDataSet;
            // 
            // commissionsTableAdapter
            // 
            this.commissionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChecksTableAdapter = null;
            this.tableAdapterManager.ClientsAndAccountsTableAdapter = null;
            this.tableAdapterManager.CommissionsTableAdapter = this.commissionsTableAdapter;
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
            // commissionsDataGridView
            // 
            this.commissionsDataGridView.AutoGenerateColumns = false;
            this.commissionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commissionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.commissionsDataGridView.DataSource = this.commissionsBindingSource;
            this.commissionsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.commissionsDataGridView.Name = "commissionsDataGridView";
            this.commissionsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.commissionsDataGridView.TabIndex = 1;
            this.commissionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commissionsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CommissionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CommissionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CommissionSize";
            this.dataGridViewTextBoxColumn4.HeaderText = "CommissionSize";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CommissionDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "CommissionDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.tAccountsDataGridView.DataSource = this.tAccountsBindingSource;
            this.tAccountsDataGridView.Location = new System.Drawing.Point(12, 238);
            this.tAccountsDataGridView.Name = "tAccountsDataGridView";
            this.tAccountsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tAccountsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AccountID";
            this.dataGridViewTextBoxColumn6.HeaderText = "AccountID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn7.HeaderText = "username";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn8.HeaderText = "password";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "current";
            this.dataGridViewTextBoxColumn9.HeaderText = "current";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "creditFrame";
            this.dataGridViewTextBoxColumn10.HeaderText = "creditFrame";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "income";
            this.dataGridViewTextBoxColumn11.HeaderText = "income";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // commissionIDLabel
            // 
            commissionIDLabel.AutoSize = true;
            commissionIDLabel.Location = new System.Drawing.Point(361, 71);
            commissionIDLabel.Name = "commissionIDLabel";
            commissionIDLabel.Size = new System.Drawing.Size(79, 13);
            commissionIDLabel.TabIndex = 2;
            commissionIDLabel.Text = "Commission ID:";
            // 
            // commissionIDTextBox
            // 
            this.commissionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionsBindingSource, "CommissionID", true));
            this.commissionIDTextBox.Location = new System.Drawing.Point(458, 68);
            this.commissionIDTextBox.Name = "commissionIDTextBox";
            this.commissionIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.commissionIDTextBox.TabIndex = 3;
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(361, 97);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(50, 13);
            clientIDLabel.TabIndex = 4;
            clientIDLabel.Text = "Client ID:";
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionsBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(458, 94);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.clientIDTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(361, 123);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionsBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(458, 120);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // commissionSizeLabel
            // 
            commissionSizeLabel.AutoSize = true;
            commissionSizeLabel.Location = new System.Drawing.Point(361, 149);
            commissionSizeLabel.Name = "commissionSizeLabel";
            commissionSizeLabel.Size = new System.Drawing.Size(88, 13);
            commissionSizeLabel.TabIndex = 8;
            commissionSizeLabel.Text = "Commission Size:";
            // 
            // commissionSizeTextBox
            // 
            this.commissionSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commissionsBindingSource, "CommissionSize", true));
            this.commissionSizeTextBox.Location = new System.Drawing.Point(458, 146);
            this.commissionSizeTextBox.Name = "commissionSizeTextBox";
            this.commissionSizeTextBox.Size = new System.Drawing.Size(200, 20);
            this.commissionSizeTextBox.TabIndex = 9;
            // 
            // commissionDateLabel
            // 
            commissionDateLabel.AutoSize = true;
            commissionDateLabel.Location = new System.Drawing.Point(361, 176);
            commissionDateLabel.Name = "commissionDateLabel";
            commissionDateLabel.Size = new System.Drawing.Size(91, 13);
            commissionDateLabel.TabIndex = 10;
            commissionDateLabel.Text = "Commission Date:";
            // 
            // commissionDateDateTimePicker
            // 
            this.commissionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.commissionsBindingSource, "CommissionDate", true));
            this.commissionDateDateTimePicker.Location = new System.Drawing.Point(458, 172);
            this.commissionDateDateTimePicker.Name = "commissionDateDateTimePicker";
            this.commissionDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.commissionDateDateTimePicker.TabIndex = 11;
            // 
            // accountIDLabel
            // 
            accountIDLabel.AutoSize = true;
            accountIDLabel.Location = new System.Drawing.Point(342, 241);
            accountIDLabel.Name = "accountIDLabel";
            accountIDLabel.Size = new System.Drawing.Size(64, 13);
            accountIDLabel.TabIndex = 12;
            accountIDLabel.Text = "Account ID:";
            // 
            // accountIDTextBox
            // 
            this.accountIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "AccountID", true));
            this.accountIDTextBox.Location = new System.Drawing.Point(416, 238);
            this.accountIDTextBox.Name = "accountIDTextBox";
            this.accountIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountIDTextBox.TabIndex = 13;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(342, 267);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(56, 13);
            usernameLabel.TabIndex = 14;
            usernameLabel.Text = "username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(416, 264);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 15;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(342, 293);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 16;
            passwordLabel.Text = "password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(416, 290);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 17;
            // 
            // currentLabel
            // 
            currentLabel.AutoSize = true;
            currentLabel.Location = new System.Drawing.Point(342, 319);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new System.Drawing.Size(43, 13);
            currentLabel.TabIndex = 18;
            currentLabel.Text = "current:";
            // 
            // currentTextBox
            // 
            this.currentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "current", true));
            this.currentTextBox.Location = new System.Drawing.Point(416, 316);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentTextBox.TabIndex = 19;
            // 
            // creditFrameLabel
            // 
            creditFrameLabel.AutoSize = true;
            creditFrameLabel.Location = new System.Drawing.Point(342, 345);
            creditFrameLabel.Name = "creditFrameLabel";
            creditFrameLabel.Size = new System.Drawing.Size(68, 13);
            creditFrameLabel.TabIndex = 20;
            creditFrameLabel.Text = "credit Frame:";
            // 
            // creditFrameTextBox
            // 
            this.creditFrameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "creditFrame", true));
            this.creditFrameTextBox.Location = new System.Drawing.Point(416, 342);
            this.creditFrameTextBox.Name = "creditFrameTextBox";
            this.creditFrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditFrameTextBox.TabIndex = 21;
            // 
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Location = new System.Drawing.Point(342, 371);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new System.Drawing.Size(44, 13);
            incomeLabel.TabIndex = 22;
            incomeLabel.Text = "income:";
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "income", true));
            this.incomeTextBox.Location = new System.Drawing.Point(416, 368);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.incomeTextBox.TabIndex = 23;
            // 
            // TakeCommision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 478);
            this.Controls.Add(accountIDLabel);
            this.Controls.Add(this.accountIDTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(currentLabel);
            this.Controls.Add(this.currentTextBox);
            this.Controls.Add(creditFrameLabel);
            this.Controls.Add(this.creditFrameTextBox);
            this.Controls.Add(incomeLabel);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(commissionIDLabel);
            this.Controls.Add(this.commissionIDTextBox);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(commissionSizeLabel);
            this.Controls.Add(this.commissionSizeTextBox);
            this.Controls.Add(commissionDateLabel);
            this.Controls.Add(this.commissionDateDateTimePicker);
            this.Controls.Add(this.tAccountsDataGridView);
            this.Controls.Add(this.commissionsDataGridView);
            this.Name = "TakeCommision";
            this.Text = "TakeCommision";
            this.Load += new System.EventHandler(this.TakeCommision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource commissionsBindingSource;
        private BankDBDataSetTableAdapters.CommissionsTableAdapter commissionsTableAdapter;
        private BankDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView commissionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BankDBDataSetTableAdapters.TAccountsTableAdapter tAccountsTableAdapter;
        private System.Windows.Forms.BindingSource tAccountsBindingSource;
        private System.Windows.Forms.DataGridView tAccountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox commissionIDTextBox;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox commissionSizeTextBox;
        private System.Windows.Forms.DateTimePicker commissionDateDateTimePicker;
        private System.Windows.Forms.TextBox accountIDTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.TextBox creditFrameTextBox;
        private System.Windows.Forms.TextBox incomeTextBox;
    }
}
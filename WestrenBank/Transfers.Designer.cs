namespace WestrenBank
{
    partial class Transfers
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
            System.Windows.Forms.Label accountIDLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label currentLabel;
            System.Windows.Forms.Label creditFrameLabel;
            System.Windows.Forms.Label incomeLabel;
            System.Windows.Forms.Label transferIDLabel;
            System.Windows.Forms.Label recieverAccountIDLabel;
            System.Windows.Forms.Label senderAccountIDLabel;
            System.Windows.Forms.Label transferAmountLabel;
            System.Windows.Forms.Label transferDateLabel;
            this.bankDBDataSet = new WestrenBank.BankDBDataSet();
            this.tAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAccountsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.TAccountsTableAdapter();
            this.tableAdapterManager = new WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager();
            this.tAccountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.creditFrameTextBox = new System.Windows.Forms.TextBox();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transfersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transfersTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.TransfersTableAdapter();
            this.transfersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferIDTextBox = new System.Windows.Forms.TextBox();
            this.recieverAccountIDTextBox = new System.Windows.Forms.TextBox();
            this.senderAccountIDTextBox = new System.Windows.Forms.TextBox();
            this.transferAmountTextBox = new System.Windows.Forms.TextBox();
            this.transferDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tAccountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            accountIDLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            currentLabel = new System.Windows.Forms.Label();
            creditFrameLabel = new System.Windows.Forms.Label();
            incomeLabel = new System.Windows.Forms.Label();
            transferIDLabel = new System.Windows.Forms.Label();
            recieverAccountIDLabel = new System.Windows.Forms.Label();
            senderAccountIDLabel = new System.Windows.Forms.Label();
            transferAmountLabel = new System.Windows.Forms.Label();
            transferDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountIDLabel
            // 
            accountIDLabel.AutoSize = true;
            accountIDLabel.Location = new System.Drawing.Point(691, 19);
            accountIDLabel.Name = "accountIDLabel";
            accountIDLabel.Size = new System.Drawing.Size(64, 13);
            accountIDLabel.TabIndex = 1;
            accountIDLabel.Text = "Account ID:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(691, 45);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(56, 13);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(691, 71);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "password:";
            // 
            // currentLabel
            // 
            currentLabel.AutoSize = true;
            currentLabel.Location = new System.Drawing.Point(691, 97);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new System.Drawing.Size(43, 13);
            currentLabel.TabIndex = 7;
            currentLabel.Text = "current:";
            // 
            // creditFrameLabel
            // 
            creditFrameLabel.AutoSize = true;
            creditFrameLabel.Location = new System.Drawing.Point(691, 123);
            creditFrameLabel.Name = "creditFrameLabel";
            creditFrameLabel.Size = new System.Drawing.Size(68, 13);
            creditFrameLabel.TabIndex = 9;
            creditFrameLabel.Text = "credit Frame:";
            // 
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Location = new System.Drawing.Point(691, 149);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new System.Drawing.Size(44, 13);
            incomeLabel.TabIndex = 11;
            incomeLabel.Text = "income:";
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
            this.tableAdapterManager.ChecksTableAdapter = null;
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
            this.tAccountsDataGridView.Location = new System.Drawing.Point(12, 0);
            this.tAccountsDataGridView.Name = "tAccountsDataGridView";
            this.tAccountsDataGridView.Size = new System.Drawing.Size(648, 220);
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
            // accountIDTextBox
            // 
            this.accountIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "AccountID", true));
            this.accountIDTextBox.Location = new System.Drawing.Point(765, 16);
            this.accountIDTextBox.Name = "accountIDTextBox";
            this.accountIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountIDTextBox.TabIndex = 2;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(765, 42);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(765, 68);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // currentTextBox
            // 
            this.currentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "current", true));
            this.currentTextBox.Location = new System.Drawing.Point(765, 94);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentTextBox.TabIndex = 8;
            // 
            // creditFrameTextBox
            // 
            this.creditFrameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "creditFrame", true));
            this.creditFrameTextBox.Location = new System.Drawing.Point(765, 120);
            this.creditFrameTextBox.Name = "creditFrameTextBox";
            this.creditFrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditFrameTextBox.TabIndex = 10;
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "income", true));
            this.incomeTextBox.Location = new System.Drawing.Point(765, 146);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.incomeTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Make Transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tAccountsBindingSource;
            this.comboBox1.DisplayMember = "username";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(596, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "AccountID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tAccountsBindingSource1;
            this.comboBox2.DisplayMember = "username";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(744, 257);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "AccountID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(694, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "transfer amount";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(462, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "giver id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "reciever id";
            // 
            // transfersBindingSource
            // 
            this.transfersBindingSource.DataMember = "Transfers";
            this.transfersBindingSource.DataSource = this.bankDBDataSet;
            // 
            // transfersTableAdapter
            // 
            this.transfersTableAdapter.ClearBeforeFill = true;
            // 
            // transfersDataGridView
            // 
            this.transfersDataGridView.AutoGenerateColumns = false;
            this.transfersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transfersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.transfersDataGridView.DataSource = this.transfersBindingSource;
            this.transfersDataGridView.Location = new System.Drawing.Point(12, 226);
            this.transfersDataGridView.Name = "transfersDataGridView";
            this.transfersDataGridView.Size = new System.Drawing.Size(300, 220);
            this.transfersDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TransferID";
            this.dataGridViewTextBoxColumn7.HeaderText = "TransferID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RecieverAccountID";
            this.dataGridViewTextBoxColumn8.HeaderText = "RecieverAccountID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SenderAccountID";
            this.dataGridViewTextBoxColumn9.HeaderText = "SenderAccountID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TransferAmount";
            this.dataGridViewTextBoxColumn10.HeaderText = "TransferAmount";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TransferDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "TransferDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // transferIDLabel
            // 
            transferIDLabel.AutoSize = true;
            transferIDLabel.Location = new System.Drawing.Point(373, 343);
            transferIDLabel.Name = "transferIDLabel";
            transferIDLabel.Size = new System.Drawing.Size(63, 13);
            transferIDLabel.TabIndex = 21;
            transferIDLabel.Text = "Transfer ID:";
            // 
            // transferIDTextBox
            // 
            this.transferIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transfersBindingSource, "TransferID", true));
            this.transferIDTextBox.Location = new System.Drawing.Point(489, 340);
            this.transferIDTextBox.Name = "transferIDTextBox";
            this.transferIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.transferIDTextBox.TabIndex = 22;
            // 
            // recieverAccountIDLabel
            // 
            recieverAccountIDLabel.AutoSize = true;
            recieverAccountIDLabel.Location = new System.Drawing.Point(373, 369);
            recieverAccountIDLabel.Name = "recieverAccountIDLabel";
            recieverAccountIDLabel.Size = new System.Drawing.Size(110, 13);
            recieverAccountIDLabel.TabIndex = 23;
            recieverAccountIDLabel.Text = "Reciever Account ID:";
            // 
            // recieverAccountIDTextBox
            // 
            this.recieverAccountIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transfersBindingSource, "RecieverAccountID", true));
            this.recieverAccountIDTextBox.Location = new System.Drawing.Point(489, 366);
            this.recieverAccountIDTextBox.Name = "recieverAccountIDTextBox";
            this.recieverAccountIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.recieverAccountIDTextBox.TabIndex = 24;
            // 
            // senderAccountIDLabel
            // 
            senderAccountIDLabel.AutoSize = true;
            senderAccountIDLabel.Location = new System.Drawing.Point(373, 395);
            senderAccountIDLabel.Name = "senderAccountIDLabel";
            senderAccountIDLabel.Size = new System.Drawing.Size(101, 13);
            senderAccountIDLabel.TabIndex = 25;
            senderAccountIDLabel.Text = "Sender Account ID:";
            // 
            // senderAccountIDTextBox
            // 
            this.senderAccountIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transfersBindingSource, "SenderAccountID", true));
            this.senderAccountIDTextBox.Location = new System.Drawing.Point(489, 392);
            this.senderAccountIDTextBox.Name = "senderAccountIDTextBox";
            this.senderAccountIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.senderAccountIDTextBox.TabIndex = 26;
            // 
            // transferAmountLabel
            // 
            transferAmountLabel.AutoSize = true;
            transferAmountLabel.Location = new System.Drawing.Point(373, 421);
            transferAmountLabel.Name = "transferAmountLabel";
            transferAmountLabel.Size = new System.Drawing.Size(88, 13);
            transferAmountLabel.TabIndex = 27;
            transferAmountLabel.Text = "Transfer Amount:";
            // 
            // transferAmountTextBox
            // 
            this.transferAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transfersBindingSource, "TransferAmount", true));
            this.transferAmountTextBox.Location = new System.Drawing.Point(489, 418);
            this.transferAmountTextBox.Name = "transferAmountTextBox";
            this.transferAmountTextBox.Size = new System.Drawing.Size(200, 20);
            this.transferAmountTextBox.TabIndex = 28;
            // 
            // transferDateLabel
            // 
            transferDateLabel.AutoSize = true;
            transferDateLabel.Location = new System.Drawing.Point(373, 448);
            transferDateLabel.Name = "transferDateLabel";
            transferDateLabel.Size = new System.Drawing.Size(75, 13);
            transferDateLabel.TabIndex = 29;
            transferDateLabel.Text = "Transfer Date:";
            // 
            // transferDateDateTimePicker
            // 
            this.transferDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transfersBindingSource, "TransferDate", true));
            this.transferDateDateTimePicker.Location = new System.Drawing.Point(489, 444);
            this.transferDateDateTimePicker.Name = "transferDateDateTimePicker";
            this.transferDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.transferDateDateTimePicker.TabIndex = 30;
            // 
            // tAccountsBindingSource1
            // 
            this.tAccountsBindingSource1.DataMember = "TAccounts";
            this.tAccountsBindingSource1.DataSource = this.bankDBDataSet;
            // 
            // Transfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 497);
            this.Controls.Add(transferIDLabel);
            this.Controls.Add(this.transferIDTextBox);
            this.Controls.Add(recieverAccountIDLabel);
            this.Controls.Add(this.recieverAccountIDTextBox);
            this.Controls.Add(senderAccountIDLabel);
            this.Controls.Add(this.senderAccountIDTextBox);
            this.Controls.Add(transferAmountLabel);
            this.Controls.Add(this.transferAmountTextBox);
            this.Controls.Add(transferDateLabel);
            this.Controls.Add(this.transferDateDateTimePicker);
            this.Controls.Add(this.transfersDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.tAccountsDataGridView);
            this.Name = "Transfers";
            this.Text = "Transfers";
            this.Load += new System.EventHandler(this.Transfers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transfersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource tAccountsBindingSource;
        private BankDBDataSetTableAdapters.TAccountsTableAdapter tAccountsTableAdapter;
        private BankDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tAccountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox accountIDTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.TextBox creditFrameTextBox;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource transfersBindingSource;
        private BankDBDataSetTableAdapters.TransfersTableAdapter transfersTableAdapter;
        private System.Windows.Forms.DataGridView transfersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox transferIDTextBox;
        private System.Windows.Forms.TextBox recieverAccountIDTextBox;
        private System.Windows.Forms.TextBox senderAccountIDTextBox;
        private System.Windows.Forms.TextBox transferAmountTextBox;
        private System.Windows.Forms.DateTimePicker transferDateDateTimePicker;
        private System.Windows.Forms.BindingSource tAccountsBindingSource1;
    }
}
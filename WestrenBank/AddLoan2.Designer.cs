namespace WestrenBank
{
    partial class AddLoan2
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
            System.Windows.Forms.Label loanIDLabel;
            System.Windows.Forms.Label loanSumLabel;
            System.Windows.Forms.Label loanStartDateLabel;
            System.Windows.Forms.Label loanEndDateLabel;
            System.Windows.Forms.Label guarenteeIDLabel;
            System.Windows.Forms.Label returnedLabel;
            System.Windows.Forms.Label interestLabel;
            System.Windows.Forms.Label loanIDLabel1;
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label clientPartLabel;
            this.bankDBDataSet = new WestrenBank.BankDBDataSet();
            this.loansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loansTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.LoansTableAdapter();
            this.tableAdapterManager = new WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager();
            this.loansDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loansToClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loansToClientsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.LoansToClientsTableAdapter();
            this.loansToClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanIDTextBox = new System.Windows.Forms.TextBox();
            this.loanSumTextBox = new System.Windows.Forms.TextBox();
            this.loanStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loanEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.guarenteeIDTextBox = new System.Windows.Forms.TextBox();
            this.returnedCheckBox = new System.Windows.Forms.CheckBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.loanIDTextBox1 = new System.Windows.Forms.TextBox();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.clientPartTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAccountsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.TAccountsTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tAccountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.creditFrameTextBox = new System.Windows.Forms.TextBox();
            loanIDLabel = new System.Windows.Forms.Label();
            loanSumLabel = new System.Windows.Forms.Label();
            loanStartDateLabel = new System.Windows.Forms.Label();
            loanEndDateLabel = new System.Windows.Forms.Label();
            guarenteeIDLabel = new System.Windows.Forms.Label();
            returnedLabel = new System.Windows.Forms.Label();
            interestLabel = new System.Windows.Forms.Label();
            loanIDLabel1 = new System.Windows.Forms.Label();
            clientIDLabel = new System.Windows.Forms.Label();
            clientPartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansToClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansToClientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loansBindingSource
            // 
            this.loansBindingSource.DataMember = "Loans";
            this.loansBindingSource.DataSource = this.bankDBDataSet;
            // 
            // loansTableAdapter
            // 
            this.loansTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LoansTableAdapter = this.loansTableAdapter;
            this.tableAdapterManager.LoansToClientsTableAdapter = this.loansToClientsTableAdapter;
            this.tableAdapterManager.StocksAndAccountsTableAdapter = null;
            this.tableAdapterManager.StocksTableAdapter = null;
            this.tableAdapterManager.TAccountsTableAdapter = this.tAccountsTableAdapter;
            this.tableAdapterManager.TClientsTableAdapter = null;
            this.tableAdapterManager.TransfersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WestrenBank.BankDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WithrawalsTableAdapter = null;
            // 
            // loansDataGridView
            // 
            this.loansDataGridView.AutoGenerateColumns = false;
            this.loansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loansDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6});
            this.loansDataGridView.DataSource = this.loansBindingSource;
            this.loansDataGridView.Location = new System.Drawing.Point(12, 12);
            this.loansDataGridView.Name = "loansDataGridView";
            this.loansDataGridView.Size = new System.Drawing.Size(335, 220);
            this.loansDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LoanID";
            this.dataGridViewTextBoxColumn1.HeaderText = "LoanID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LoanSum";
            this.dataGridViewTextBoxColumn2.HeaderText = "LoanSum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LoanStartDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "LoanStartDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LoanEndDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "LoanEndDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GuarenteeID";
            this.dataGridViewTextBoxColumn5.HeaderText = "GuarenteeID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Returned";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Returned";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Interest";
            this.dataGridViewTextBoxColumn6.HeaderText = "Interest";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // loansToClientsDataGridView
            // 
            this.loansToClientsDataGridView.AutoGenerateColumns = false;
            this.loansToClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loansToClientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.loansToClientsDataGridView.DataSource = this.loansToClientsBindingSource;
            this.loansToClientsDataGridView.Location = new System.Drawing.Point(12, 238);
            this.loansToClientsDataGridView.Name = "loansToClientsDataGridView";
            this.loansToClientsDataGridView.Size = new System.Drawing.Size(277, 220);
            this.loansToClientsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LoanID";
            this.dataGridViewTextBoxColumn7.HeaderText = "LoanID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ClientPart";
            this.dataGridViewTextBoxColumn9.HeaderText = "ClientPart";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // loanIDLabel
            // 
            loanIDLabel.AutoSize = true;
            loanIDLabel.Location = new System.Drawing.Point(353, 36);
            loanIDLabel.Name = "loanIDLabel";
            loanIDLabel.Size = new System.Drawing.Size(48, 13);
            loanIDLabel.TabIndex = 2;
            loanIDLabel.Text = "Loan ID:";
            // 
            // loanIDTextBox
            // 
            this.loanIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "LoanID", true));
            this.loanIDTextBox.Location = new System.Drawing.Point(444, 33);
            this.loanIDTextBox.Name = "loanIDTextBox";
            this.loanIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.loanIDTextBox.TabIndex = 3;
            // 
            // loanSumLabel
            // 
            loanSumLabel.AutoSize = true;
            loanSumLabel.Location = new System.Drawing.Point(353, 62);
            loanSumLabel.Name = "loanSumLabel";
            loanSumLabel.Size = new System.Drawing.Size(58, 13);
            loanSumLabel.TabIndex = 4;
            loanSumLabel.Text = "Loan Sum:";
            // 
            // loanSumTextBox
            // 
            this.loanSumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "LoanSum", true));
            this.loanSumTextBox.Location = new System.Drawing.Point(444, 59);
            this.loanSumTextBox.Name = "loanSumTextBox";
            this.loanSumTextBox.Size = new System.Drawing.Size(200, 20);
            this.loanSumTextBox.TabIndex = 5;
            // 
            // loanStartDateLabel
            // 
            loanStartDateLabel.AutoSize = true;
            loanStartDateLabel.Location = new System.Drawing.Point(353, 89);
            loanStartDateLabel.Name = "loanStartDateLabel";
            loanStartDateLabel.Size = new System.Drawing.Size(85, 13);
            loanStartDateLabel.TabIndex = 6;
            loanStartDateLabel.Text = "Loan Start Date:";
            // 
            // loanStartDateDateTimePicker
            // 
            this.loanStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loansBindingSource, "LoanStartDate", true));
            this.loanStartDateDateTimePicker.Location = new System.Drawing.Point(444, 85);
            this.loanStartDateDateTimePicker.Name = "loanStartDateDateTimePicker";
            this.loanStartDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.loanStartDateDateTimePicker.TabIndex = 7;
            // 
            // loanEndDateLabel
            // 
            loanEndDateLabel.AutoSize = true;
            loanEndDateLabel.Location = new System.Drawing.Point(353, 115);
            loanEndDateLabel.Name = "loanEndDateLabel";
            loanEndDateLabel.Size = new System.Drawing.Size(82, 13);
            loanEndDateLabel.TabIndex = 8;
            loanEndDateLabel.Text = "Loan End Date:";
            // 
            // loanEndDateDateTimePicker
            // 
            this.loanEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loansBindingSource, "LoanEndDate", true));
            this.loanEndDateDateTimePicker.Location = new System.Drawing.Point(444, 111);
            this.loanEndDateDateTimePicker.Name = "loanEndDateDateTimePicker";
            this.loanEndDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.loanEndDateDateTimePicker.TabIndex = 9;
            // 
            // guarenteeIDLabel
            // 
            guarenteeIDLabel.AutoSize = true;
            guarenteeIDLabel.Location = new System.Drawing.Point(353, 140);
            guarenteeIDLabel.Name = "guarenteeIDLabel";
            guarenteeIDLabel.Size = new System.Drawing.Size(74, 13);
            guarenteeIDLabel.TabIndex = 10;
            guarenteeIDLabel.Text = "Guarentee ID:";
            // 
            // guarenteeIDTextBox
            // 
            this.guarenteeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "GuarenteeID", true));
            this.guarenteeIDTextBox.Location = new System.Drawing.Point(444, 137);
            this.guarenteeIDTextBox.Name = "guarenteeIDTextBox";
            this.guarenteeIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.guarenteeIDTextBox.TabIndex = 11;
            // 
            // returnedLabel
            // 
            returnedLabel.AutoSize = true;
            returnedLabel.Location = new System.Drawing.Point(353, 168);
            returnedLabel.Name = "returnedLabel";
            returnedLabel.Size = new System.Drawing.Size(54, 13);
            returnedLabel.TabIndex = 12;
            returnedLabel.Text = "Returned:";
            // 
            // returnedCheckBox
            // 
            this.returnedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.loansBindingSource, "Returned", true));
            this.returnedCheckBox.Location = new System.Drawing.Point(444, 163);
            this.returnedCheckBox.Name = "returnedCheckBox";
            this.returnedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.returnedCheckBox.TabIndex = 13;
            this.returnedCheckBox.Text = "checkBox1";
            this.returnedCheckBox.UseVisualStyleBackColor = true;
            // 
            // interestLabel
            // 
            interestLabel.AutoSize = true;
            interestLabel.Location = new System.Drawing.Point(353, 196);
            interestLabel.Name = "interestLabel";
            interestLabel.Size = new System.Drawing.Size(45, 13);
            interestLabel.TabIndex = 14;
            interestLabel.Text = "Interest:";
            // 
            // interestTextBox
            // 
            this.interestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "Interest", true));
            this.interestTextBox.Location = new System.Drawing.Point(444, 193);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(200, 20);
            this.interestTextBox.TabIndex = 15;
            // 
            // loanIDLabel1
            // 
            loanIDLabel1.AutoSize = true;
            loanIDLabel1.Location = new System.Drawing.Point(501, 320);
            loanIDLabel1.Name = "loanIDLabel1";
            loanIDLabel1.Size = new System.Drawing.Size(48, 13);
            loanIDLabel1.TabIndex = 16;
            loanIDLabel1.Text = "Loan ID:";
            // 
            // loanIDTextBox1
            // 
            this.loanIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansToClientsBindingSource, "LoanID", true));
            this.loanIDTextBox1.Location = new System.Drawing.Point(565, 317);
            this.loanIDTextBox1.Name = "loanIDTextBox1";
            this.loanIDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.loanIDTextBox1.TabIndex = 17;
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(501, 346);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(50, 13);
            clientIDLabel.TabIndex = 18;
            clientIDLabel.Text = "Client ID:";
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansToClientsBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(565, 343);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientIDTextBox.TabIndex = 19;
            // 
            // clientPartLabel
            // 
            clientPartLabel.AutoSize = true;
            clientPartLabel.Location = new System.Drawing.Point(501, 372);
            clientPartLabel.Name = "clientPartLabel";
            clientPartLabel.Size = new System.Drawing.Size(58, 13);
            clientPartLabel.TabIndex = 20;
            clientPartLabel.Text = "Client Part:";
            // 
            // clientPartTextBox
            // 
            this.clientPartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansToClientsBindingSource, "ClientPart", true));
            this.clientPartTextBox.Location = new System.Drawing.Point(565, 369);
            this.clientPartTextBox.Name = "clientPartTextBox";
            this.clientPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientPartTextBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tAccountsBindingSource;
            this.comboBox1.DisplayMember = "username";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(339, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "AccountID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Client";
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(340, 303);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Add Client";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tAccountsDataGridView
            // 
            this.tAccountsDataGridView.AutoGenerateColumns = false;
            this.tAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAccountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.tAccountsDataGridView.DataSource = this.tAccountsBindingSource;
            this.tAccountsDataGridView.Location = new System.Drawing.Point(12, 464);
            this.tAccountsDataGridView.Name = "tAccountsDataGridView";
            this.tAccountsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tAccountsDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AccountID";
            this.dataGridViewTextBoxColumn10.HeaderText = "AccountID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn11.HeaderText = "username";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn12.HeaderText = "password";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "current";
            this.dataGridViewTextBoxColumn13.HeaderText = "current";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "creditFrame";
            this.dataGridViewTextBoxColumn14.HeaderText = "creditFrame";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "income";
            this.dataGridViewTextBoxColumn15.HeaderText = "income";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // currentTextBox
            // 
            this.currentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "current", true));
            this.currentTextBox.Location = new System.Drawing.Point(423, 552);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentTextBox.TabIndex = 30;
            // 
            // creditFrameTextBox
            // 
            this.creditFrameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAccountsBindingSource, "creditFrame", true));
            this.creditFrameTextBox.Location = new System.Drawing.Point(423, 578);
            this.creditFrameTextBox.Name = "creditFrameTextBox";
            this.creditFrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditFrameTextBox.TabIndex = 32;
            // 
            // AddLoan2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(721, 741);
            this.Controls.Add(this.creditFrameTextBox);
            this.Controls.Add(this.currentTextBox);
            this.Controls.Add(this.tAccountsDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(loanIDLabel1);
            this.Controls.Add(this.loanIDTextBox1);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(clientPartLabel);
            this.Controls.Add(this.clientPartTextBox);
            this.Controls.Add(loanIDLabel);
            this.Controls.Add(this.loanIDTextBox);
            this.Controls.Add(loanSumLabel);
            this.Controls.Add(this.loanSumTextBox);
            this.Controls.Add(loanStartDateLabel);
            this.Controls.Add(this.loanStartDateDateTimePicker);
            this.Controls.Add(loanEndDateLabel);
            this.Controls.Add(this.loanEndDateDateTimePicker);
            this.Controls.Add(guarenteeIDLabel);
            this.Controls.Add(this.guarenteeIDTextBox);
            this.Controls.Add(returnedLabel);
            this.Controls.Add(this.returnedCheckBox);
            this.Controls.Add(interestLabel);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.loansToClientsDataGridView);
            this.Controls.Add(this.loansDataGridView);
            this.Name = "AddLoan2";
            this.Text = "AddLoan2";
            this.Load += new System.EventHandler(this.AddLoan2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansToClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansToClientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAccountsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDBDataSet bankDBDataSet;
        private System.Windows.Forms.BindingSource loansBindingSource;
        private BankDBDataSetTableAdapters.LoansTableAdapter loansTableAdapter;
        private BankDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView loansDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BankDBDataSetTableAdapters.LoansToClientsTableAdapter loansToClientsTableAdapter;
        private System.Windows.Forms.BindingSource loansToClientsBindingSource;
        private System.Windows.Forms.DataGridView loansToClientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox loanIDTextBox;
        private System.Windows.Forms.TextBox loanSumTextBox;
        private System.Windows.Forms.DateTimePicker loanStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker loanEndDateDateTimePicker;
        private System.Windows.Forms.TextBox guarenteeIDTextBox;
        private System.Windows.Forms.CheckBox returnedCheckBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.TextBox loanIDTextBox1;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox clientPartTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private BankDBDataSetTableAdapters.TAccountsTableAdapter tAccountsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tAccountsBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView tAccountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.TextBox creditFrameTextBox;
    }
}
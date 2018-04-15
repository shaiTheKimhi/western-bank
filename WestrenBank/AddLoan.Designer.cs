namespace WestrenBank
{
    partial class AddLoan
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
            this.loanIDTextBox = new System.Windows.Forms.TextBox();
            this.loanSumTextBox = new System.Windows.Forms.TextBox();
            this.loanStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loanEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.guarenteeIDTextBox = new System.Windows.Forms.TextBox();
            this.returnedCheckBox = new System.Windows.Forms.CheckBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.loansToClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loansToClientsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.LoansToClientsTableAdapter();
            this.loansToClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.loanIDTextBox1 = new System.Windows.Forms.TextBox();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.clientPartTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsComboBox = new System.Windows.Forms.ComboBox();
            this.tClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tClientsTableAdapter = new WestrenBank.BankDBDataSetTableAdapters.TClientsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.tClientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loanIDLabel
            // 
            loanIDLabel.AutoSize = true;
            loanIDLabel.Location = new System.Drawing.Point(542, 273);
            loanIDLabel.Name = "loanIDLabel";
            loanIDLabel.Size = new System.Drawing.Size(48, 13);
            loanIDLabel.TabIndex = 2;
            loanIDLabel.Text = "Loan ID:";
            // 
            // loanSumLabel
            // 
            loanSumLabel.AutoSize = true;
            loanSumLabel.Location = new System.Drawing.Point(542, 299);
            loanSumLabel.Name = "loanSumLabel";
            loanSumLabel.Size = new System.Drawing.Size(58, 13);
            loanSumLabel.TabIndex = 4;
            loanSumLabel.Text = "Loan Sum:";
            // 
            // loanStartDateLabel
            // 
            loanStartDateLabel.AutoSize = true;
            loanStartDateLabel.Location = new System.Drawing.Point(542, 326);
            loanStartDateLabel.Name = "loanStartDateLabel";
            loanStartDateLabel.Size = new System.Drawing.Size(85, 13);
            loanStartDateLabel.TabIndex = 6;
            loanStartDateLabel.Text = "Loan Start Date:";
            // 
            // loanEndDateLabel
            // 
            loanEndDateLabel.AutoSize = true;
            loanEndDateLabel.Location = new System.Drawing.Point(542, 352);
            loanEndDateLabel.Name = "loanEndDateLabel";
            loanEndDateLabel.Size = new System.Drawing.Size(82, 13);
            loanEndDateLabel.TabIndex = 8;
            loanEndDateLabel.Text = "Loan End Date:";
            // 
            // guarenteeIDLabel
            // 
            guarenteeIDLabel.AutoSize = true;
            guarenteeIDLabel.Location = new System.Drawing.Point(542, 377);
            guarenteeIDLabel.Name = "guarenteeIDLabel";
            guarenteeIDLabel.Size = new System.Drawing.Size(74, 13);
            guarenteeIDLabel.TabIndex = 10;
            guarenteeIDLabel.Text = "Guarentee ID:";
            // 
            // returnedLabel
            // 
            returnedLabel.AutoSize = true;
            returnedLabel.Location = new System.Drawing.Point(542, 405);
            returnedLabel.Name = "returnedLabel";
            returnedLabel.Size = new System.Drawing.Size(54, 13);
            returnedLabel.TabIndex = 12;
            returnedLabel.Text = "Returned:";
            // 
            // interestLabel
            // 
            interestLabel.AutoSize = true;
            interestLabel.Location = new System.Drawing.Point(542, 433);
            interestLabel.Name = "interestLabel";
            interestLabel.Size = new System.Drawing.Size(45, 13);
            interestLabel.TabIndex = 14;
            interestLabel.Text = "Interest:";
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
            this.tableAdapterManager.LoansToClientsTableAdapter = null;
            this.tableAdapterManager.StocksAndAccountsTableAdapter = null;
            this.tableAdapterManager.StocksTableAdapter = null;
            this.tableAdapterManager.TAccountsTableAdapter = null;
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
            this.loansDataGridView.Location = new System.Drawing.Point(12, 22);
            this.loansDataGridView.Name = "loansDataGridView";
            this.loansDataGridView.Size = new System.Drawing.Size(634, 220);
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
            // loanIDTextBox
            // 
            this.loanIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "LoanID", true));
            this.loanIDTextBox.Location = new System.Drawing.Point(633, 266);
            this.loanIDTextBox.Name = "loanIDTextBox";
            this.loanIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.loanIDTextBox.TabIndex = 3;
            // 
            // loanSumTextBox
            // 
            this.loanSumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "LoanSum", true));
            this.loanSumTextBox.Location = new System.Drawing.Point(633, 296);
            this.loanSumTextBox.Name = "loanSumTextBox";
            this.loanSumTextBox.Size = new System.Drawing.Size(200, 20);
            this.loanSumTextBox.TabIndex = 5;
            // 
            // loanStartDateDateTimePicker
            // 
            this.loanStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loansBindingSource, "LoanStartDate", true));
            this.loanStartDateDateTimePicker.Location = new System.Drawing.Point(633, 322);
            this.loanStartDateDateTimePicker.Name = "loanStartDateDateTimePicker";
            this.loanStartDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.loanStartDateDateTimePicker.TabIndex = 7;
            // 
            // loanEndDateDateTimePicker
            // 
            this.loanEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loansBindingSource, "LoanEndDate", true));
            this.loanEndDateDateTimePicker.Location = new System.Drawing.Point(633, 348);
            this.loanEndDateDateTimePicker.Name = "loanEndDateDateTimePicker";
            this.loanEndDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.loanEndDateDateTimePicker.TabIndex = 9;
            // 
            // guarenteeIDTextBox
            // 
            this.guarenteeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "GuarenteeID", true));
            this.guarenteeIDTextBox.Location = new System.Drawing.Point(633, 374);
            this.guarenteeIDTextBox.Name = "guarenteeIDTextBox";
            this.guarenteeIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.guarenteeIDTextBox.TabIndex = 11;
            // 
            // returnedCheckBox
            // 
            this.returnedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.loansBindingSource, "Returned", true));
            this.returnedCheckBox.Location = new System.Drawing.Point(633, 400);
            this.returnedCheckBox.Name = "returnedCheckBox";
            this.returnedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.returnedCheckBox.TabIndex = 13;
            this.returnedCheckBox.Text = "checkBox1";
            this.returnedCheckBox.UseVisualStyleBackColor = true;
            // 
            // interestTextBox
            // 
            this.interestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "Interest", true));
            this.interestTextBox.Location = new System.Drawing.Point(633, 430);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(200, 20);
            this.interestTextBox.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Add Loan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.loansToClientsDataGridView.Location = new System.Drawing.Point(12, 266);
            this.loansToClientsDataGridView.Name = "loansToClientsDataGridView";
            this.loansToClientsDataGridView.Size = new System.Drawing.Size(354, 220);
            this.loansToClientsDataGridView.TabIndex = 18;
            // 
            // loanIDLabel1
            // 
            loanIDLabel1.AutoSize = true;
            loanIDLabel1.Location = new System.Drawing.Point(372, 373);
            loanIDLabel1.Name = "loanIDLabel1";
            loanIDLabel1.Size = new System.Drawing.Size(48, 13);
            loanIDLabel1.TabIndex = 18;
            loanIDLabel1.Text = "Loan ID:";
            // 
            // loanIDTextBox1
            // 
            this.loanIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansToClientsBindingSource, "LoanID", true));
            this.loanIDTextBox1.Location = new System.Drawing.Point(436, 370);
            this.loanIDTextBox1.Name = "loanIDTextBox1";
            this.loanIDTextBox1.Size = new System.Drawing.Size(100, 20);
            this.loanIDTextBox1.TabIndex = 19;
            // 
            // clientIDLabel
            // 
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(372, 399);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(50, 13);
            clientIDLabel.TabIndex = 20;
            clientIDLabel.Text = "Client ID:";
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansToClientsBindingSource, "ClientID", true));
            this.clientIDTextBox.Location = new System.Drawing.Point(436, 396);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientIDTextBox.TabIndex = 21;
            // 
            // clientPartLabel
            // 
            clientPartLabel.AutoSize = true;
            clientPartLabel.Location = new System.Drawing.Point(372, 425);
            clientPartLabel.Name = "clientPartLabel";
            clientPartLabel.Size = new System.Drawing.Size(58, 13);
            clientPartLabel.TabIndex = 22;
            clientPartLabel.Text = "Client Part:";
            // 
            // clientPartTextBox
            // 
            this.clientPartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansToClientsBindingSource, "ClientPart", true));
            this.clientPartTextBox.Location = new System.Drawing.Point(436, 422);
            this.clientPartTextBox.Name = "clientPartTextBox";
            this.clientPartTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientPartTextBox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clientsListBox
            // 
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.Location = new System.Drawing.Point(389, 244);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(120, 95);
            this.clientsListBox.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ClientPart";
            this.dataGridViewTextBoxColumn9.HeaderText = "ClientPart";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ClientID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LoanID";
            this.dataGridViewTextBoxColumn7.HeaderText = "LoanID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // clientsComboBox
            // 
            this.clientsComboBox.DataSource = this.tClientsBindingSource;
            this.clientsComboBox.DisplayMember = "ClientName";
            this.clientsComboBox.FormattingEnabled = true;
            this.clientsComboBox.Location = new System.Drawing.Point(415, 448);
            this.clientsComboBox.Name = "clientsComboBox";
            this.clientsComboBox.Size = new System.Drawing.Size(121, 21);
            this.clientsComboBox.TabIndex = 26;
            this.clientsComboBox.ValueMember = "ClientID";
            // 
            // tClientsBindingSource
            // 
            this.tClientsBindingSource.DataMember = "TClients";
            this.tClientsBindingSource.DataSource = this.bankDBDataSet;
            // 
            // tClientsTableAdapter
            // 
            this.tClientsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(702, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 512);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clientsComboBox);
            this.Controls.Add(this.clientsListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(loanIDLabel1);
            this.Controls.Add(this.loanIDTextBox1);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(clientPartLabel);
            this.Controls.Add(this.clientPartTextBox);
            this.Controls.Add(this.loansToClientsDataGridView);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.loansDataGridView);
            this.Name = "AddLoan";
            this.Text = "AddLoan";
            this.Load += new System.EventHandler(this.AddLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansToClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loansToClientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tClientsBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox loanIDTextBox;
        private System.Windows.Forms.TextBox loanSumTextBox;
        private System.Windows.Forms.DateTimePicker loanStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker loanEndDateDateTimePicker;
        private System.Windows.Forms.TextBox guarenteeIDTextBox;
        private System.Windows.Forms.CheckBox returnedCheckBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource loansToClientsBindingSource;
        private BankDBDataSetTableAdapters.LoansToClientsTableAdapter loansToClientsTableAdapter;
        private System.Windows.Forms.DataGridView loansToClientsDataGridView;
        private System.Windows.Forms.TextBox loanIDTextBox1;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox clientPartTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox clientsListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox clientsComboBox;
        private System.Windows.Forms.BindingSource tClientsBindingSource;
        private BankDBDataSetTableAdapters.TClientsTableAdapter tClientsTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}
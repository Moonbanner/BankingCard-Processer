
namespace BankingCard_Processer
{
    partial class formPOSPayment
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbxConfirm = new System.Windows.Forms.TextBox();
            this.tbxTransactionID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbThanks = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.lbVAT = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbWithdraw = new System.Windows.Forms.Label();
            this.txtCardHolder = new System.Windows.Forms.TextBox();
            this.lbCardHolder = new System.Windows.Forms.Label();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.lbCardID = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.column_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_holder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTransactionID = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn10000k = new System.Windows.Forms.Button();
            this.btn100k = new System.Windows.Forms.Button();
            this.btn1000k = new System.Windows.Forms.Button();
            this.btn200k = new System.Windows.Forms.Button();
            this.btn500k = new System.Windows.Forms.Button();
            this.btn50k = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "POS Payment Information";
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxConfirm.Location = new System.Drawing.Point(222, 598);
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.PasswordChar = '*';
            this.tbxConfirm.Size = new System.Drawing.Size(170, 29);
            this.tbxConfirm.TabIndex = 59;
            // 
            // tbxTransactionID
            // 
            this.tbxTransactionID.Location = new System.Drawing.Point(247, 102);
            this.tbxTransactionID.Name = "tbxTransactionID";
            this.tbxTransactionID.Size = new System.Drawing.Size(194, 29);
            this.tbxTransactionID.TabIndex = 57;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(46, 643);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(348, 47);
            this.btnConfirm.TabIndex = 56;
            this.btnConfirm.Text = "Confirm Payment";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(44, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "Confirm PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(42, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Transaction ID";
            // 
            // tbxBalance
            // 
            this.tbxBalance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBalance.ForeColor = System.Drawing.Color.White;
            this.tbxBalance.Location = new System.Drawing.Point(247, 59);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.Size = new System.Drawing.Size(311, 22);
            this.tbxBalance.TabIndex = 46;
            this.tbxBalance.Text = "tien con lai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Available Balance";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(893, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 44);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox1.Location = new System.Drawing.Point(673, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(49, 22);
            this.textBox1.TabIndex = 133;
            this.textBox1.Text = ":";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(728, 189);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(264, 22);
            this.txtDate.TabIndex = 132;
            this.txtDate.Text = "15/5/2021";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbDate.Location = new System.Drawing.Point(508, 189);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(42, 21);
            this.lbDate.TabIndex = 131;
            this.lbDate.Text = "Date";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox7.Location = new System.Drawing.Point(673, 509);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(49, 22);
            this.textBox7.TabIndex = 130;
            this.textBox7.Text = ":";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox6.Location = new System.Drawing.Point(673, 467);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(49, 22);
            this.textBox6.TabIndex = 129;
            this.textBox6.Text = ":";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox5.Location = new System.Drawing.Point(673, 422);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(49, 22);
            this.textBox5.TabIndex = 128;
            this.textBox5.Text = ":";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox3.Location = new System.Drawing.Point(673, 276);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(49, 22);
            this.textBox3.TabIndex = 127;
            this.textBox3.Text = ":";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox2.Location = new System.Drawing.Point(673, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(49, 22);
            this.textBox2.TabIndex = 126;
            this.textBox2.Text = ":";
            // 
            // lbThanks
            // 
            this.lbThanks.AutoSize = true;
            this.lbThanks.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbThanks.Location = new System.Drawing.Point(588, 565);
            this.lbThanks.Name = "lbThanks";
            this.lbThanks.Size = new System.Drawing.Size(132, 21);
            this.lbThanks.TabIndex = 125;
            this.lbThanks.Text = "*** Thank you ***";
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVAT.ForeColor = System.Drawing.Color.White;
            this.txtVAT.Location = new System.Drawing.Point(728, 509);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(264, 22);
            this.txtVAT.TabIndex = 124;
            this.txtVAT.Text = "0.00 VND";
            // 
            // lbVAT
            // 
            this.lbVAT.AutoSize = true;
            this.lbVAT.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbVAT.Location = new System.Drawing.Point(508, 509);
            this.lbVAT.Name = "lbVAT";
            this.lbVAT.Size = new System.Drawing.Size(36, 21);
            this.lbVAT.TabIndex = 123;
            this.lbVAT.Text = "VAT";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.ForeColor = System.Drawing.Color.White;
            this.txtBalance.Location = new System.Drawing.Point(728, 467);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(264, 22);
            this.txtBalance.TabIndex = 122;
            this.txtBalance.Text = "9,000,000";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbBalance.Location = new System.Drawing.Point(508, 467);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(63, 21);
            this.lbBalance.TabIndex = 121;
            this.lbBalance.Text = "Balance";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(728, 422);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(264, 22);
            this.txtAmount.TabIndex = 120;
            this.txtAmount.Text = "900,000";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbAmount.Location = new System.Drawing.Point(508, 422);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(66, 21);
            this.lbAmount.TabIndex = 119;
            this.lbAmount.Text = "Amount";
            // 
            // lbWithdraw
            // 
            this.lbWithdraw.AutoSize = true;
            this.lbWithdraw.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbWithdraw.Location = new System.Drawing.Point(587, 333);
            this.lbWithdraw.Name = "lbWithdraw";
            this.lbWithdraw.Size = new System.Drawing.Size(104, 21);
            this.lbWithdraw.TabIndex = 118;
            this.lbWithdraw.Text = "POS Payment";
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtCardHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardHolder.ForeColor = System.Drawing.Color.White;
            this.txtCardHolder.Location = new System.Drawing.Point(728, 276);
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.ReadOnly = true;
            this.txtCardHolder.Size = new System.Drawing.Size(264, 22);
            this.txtCardHolder.TabIndex = 117;
            this.txtCardHolder.Text = "Nguyen Quoc Trung";
            // 
            // lbCardHolder
            // 
            this.lbCardHolder.AutoSize = true;
            this.lbCardHolder.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbCardHolder.Location = new System.Drawing.Point(508, 276);
            this.lbCardHolder.Name = "lbCardHolder";
            this.lbCardHolder.Size = new System.Drawing.Size(94, 21);
            this.lbCardHolder.TabIndex = 116;
            this.lbCardHolder.Text = "Card Holder";
            // 
            // txtCardID
            // 
            this.txtCardID.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtCardID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardID.ForeColor = System.Drawing.Color.White;
            this.txtCardID.Location = new System.Drawing.Point(728, 234);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.ReadOnly = true;
            this.txtCardID.Size = new System.Drawing.Size(264, 22);
            this.txtCardID.TabIndex = 115;
            this.txtCardID.Text = "4815123";
            // 
            // lbCardID
            // 
            this.lbCardID.AutoSize = true;
            this.lbCardID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbCardID.Location = new System.Drawing.Point(508, 234);
            this.lbCardID.Name = "lbCardID";
            this.lbCardID.Size = new System.Drawing.Size(89, 21);
            this.lbCardID.TabIndex = 114;
            this.lbCardID.Text = "Credit Card";
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInvoice.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Location = new System.Drawing.Point(728, 643);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(264, 47);
            this.btnInvoice.TabIndex = 134;
            this.btnInvoice.Text = "Invoice ";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_balance,
            this.column_holder});
            this.dataGridView.Location = new System.Drawing.Point(564, 9);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(300, 106);
            this.dataGridView.TabIndex = 135;
            this.dataGridView.Visible = false;
            // 
            // column_balance
            // 
            this.column_balance.DataPropertyName = "SoDu";
            this.column_balance.HeaderText = "Column1";
            this.column_balance.MinimumWidth = 8;
            this.column_balance.Name = "column_balance";
            this.column_balance.Width = 150;
            // 
            // column_holder
            // 
            this.column_holder.DataPropertyName = "HoTenKH";
            this.column_holder.HeaderText = "Column2";
            this.column_holder.MinimumWidth = 8;
            this.column_holder.Name = "column_holder";
            this.column_holder.Width = 150;
            // 
            // lbTransactionID
            // 
            this.lbTransactionID.AutoSize = true;
            this.lbTransactionID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTransactionID.Location = new System.Drawing.Point(508, 379);
            this.lbTransactionID.Name = "lbTransactionID";
            this.lbTransactionID.Size = new System.Drawing.Size(108, 21);
            this.lbTransactionID.TabIndex = 136;
            this.lbTransactionID.Text = "Transaction ID";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox4.Location = new System.Drawing.Point(673, 379);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(49, 22);
            this.textBox4.TabIndex = 137;
            this.textBox4.Text = ":";
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtTransactionID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransactionID.ForeColor = System.Drawing.Color.White;
            this.txtTransactionID.Location = new System.Drawing.Point(728, 379);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.ReadOnly = true;
            this.txtTransactionID.Size = new System.Drawing.Size(264, 22);
            this.txtTransactionID.TabIndex = 138;
            this.txtTransactionID.Text = "68295";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(287, 424);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 39);
            this.btnClear.TabIndex = 147;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(150, 379);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(244, 29);
            this.tbxAmount.TabIndex = 146;
            this.tbxAmount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(44, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 145;
            this.label6.Text = "Amount";
            // 
            // btn10000k
            // 
            this.btn10000k.BackColor = System.Drawing.Color.SeaGreen;
            this.btn10000k.FlatAppearance.BorderSize = 0;
            this.btn10000k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10000k.ForeColor = System.Drawing.Color.White;
            this.btn10000k.Location = new System.Drawing.Point(229, 306);
            this.btn10000k.Name = "btn10000k";
            this.btn10000k.Size = new System.Drawing.Size(165, 41);
            this.btn10000k.TabIndex = 144;
            this.btn10000k.Text = "10,000,000";
            this.btn10000k.UseVisualStyleBackColor = false;
            this.btn10000k.Click += new System.EventHandler(this.btn10000k_Click);
            // 
            // btn100k
            // 
            this.btn100k.BackColor = System.Drawing.Color.SeaGreen;
            this.btn100k.FlatAppearance.BorderSize = 0;
            this.btn100k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100k.ForeColor = System.Drawing.Color.White;
            this.btn100k.Location = new System.Drawing.Point(229, 189);
            this.btn100k.Name = "btn100k";
            this.btn100k.Size = new System.Drawing.Size(165, 41);
            this.btn100k.TabIndex = 143;
            this.btn100k.Text = "100,000";
            this.btn100k.UseVisualStyleBackColor = false;
            this.btn100k.Click += new System.EventHandler(this.btn100k_Click);
            // 
            // btn1000k
            // 
            this.btn1000k.BackColor = System.Drawing.Color.SeaGreen;
            this.btn1000k.FlatAppearance.BorderSize = 0;
            this.btn1000k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1000k.ForeColor = System.Drawing.Color.White;
            this.btn1000k.Location = new System.Drawing.Point(44, 306);
            this.btn1000k.Name = "btn1000k";
            this.btn1000k.Size = new System.Drawing.Size(165, 41);
            this.btn1000k.TabIndex = 142;
            this.btn1000k.Text = "1,000,000";
            this.btn1000k.UseVisualStyleBackColor = false;
            this.btn1000k.Click += new System.EventHandler(this.btn1000k_Click);
            // 
            // btn200k
            // 
            this.btn200k.BackColor = System.Drawing.Color.SeaGreen;
            this.btn200k.FlatAppearance.BorderSize = 0;
            this.btn200k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn200k.ForeColor = System.Drawing.Color.White;
            this.btn200k.Location = new System.Drawing.Point(46, 248);
            this.btn200k.Name = "btn200k";
            this.btn200k.Size = new System.Drawing.Size(165, 41);
            this.btn200k.TabIndex = 141;
            this.btn200k.Text = "200,000";
            this.btn200k.UseVisualStyleBackColor = false;
            this.btn200k.Click += new System.EventHandler(this.btn200k_Click);
            // 
            // btn500k
            // 
            this.btn500k.BackColor = System.Drawing.Color.SeaGreen;
            this.btn500k.FlatAppearance.BorderSize = 0;
            this.btn500k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn500k.ForeColor = System.Drawing.Color.White;
            this.btn500k.Location = new System.Drawing.Point(229, 248);
            this.btn500k.Name = "btn500k";
            this.btn500k.Size = new System.Drawing.Size(165, 41);
            this.btn500k.TabIndex = 140;
            this.btn500k.Text = "500,000";
            this.btn500k.UseVisualStyleBackColor = false;
            this.btn500k.Click += new System.EventHandler(this.btn500k_Click);
            // 
            // btn50k
            // 
            this.btn50k.BackColor = System.Drawing.Color.SeaGreen;
            this.btn50k.FlatAppearance.BorderSize = 0;
            this.btn50k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50k.ForeColor = System.Drawing.Color.White;
            this.btn50k.Location = new System.Drawing.Point(46, 189);
            this.btn50k.Name = "btn50k";
            this.btn50k.Size = new System.Drawing.Size(165, 41);
            this.btn50k.TabIndex = 139;
            this.btn50k.Text = "50,000";
            this.btn50k.UseVisualStyleBackColor = false;
            this.btn50k.Click += new System.EventHandler(this.btn50k_Click);
            // 
            // formPOSPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1032, 722);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn10000k);
            this.Controls.Add(this.btn100k);
            this.Controls.Add(this.btn1000k);
            this.Controls.Add(this.btn200k);
            this.Controls.Add(this.btn500k);
            this.Controls.Add(this.btn50k);
            this.Controls.Add(this.txtTransactionID);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbTransactionID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbThanks);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.lbVAT);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbWithdraw);
            this.Controls.Add(this.txtCardHolder);
            this.Controls.Add(this.lbCardHolder);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.lbCardID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxConfirm);
            this.Controls.Add(this.tbxTransactionID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formPOSPayment";
            this.Text = "formPOSPayment";
            this.Load += new System.EventHandler(this.formPOSPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxConfirm;
        private System.Windows.Forms.TextBox tbxTransactionID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbThanks;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label lbVAT;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbWithdraw;
        private System.Windows.Forms.TextBox txtCardHolder;
        private System.Windows.Forms.Label lbCardHolder;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label lbCardID;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_holder;
        private System.Windows.Forms.Label lbTransactionID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn10000k;
        private System.Windows.Forms.Button btn100k;
        private System.Windows.Forms.Button btn1000k;
        private System.Windows.Forms.Button btn200k;
        private System.Windows.Forms.Button btn500k;
        private System.Windows.Forms.Button btn50k;
    }
}
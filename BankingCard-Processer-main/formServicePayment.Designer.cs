
namespace BankingCard_Processer
{
    partial class formServicePayment
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnElectricity = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnInternet = new System.Windows.Forms.Button();
            this.tbxConfirm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.column_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_holder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column_sotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbThanks = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.lbVAT = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbTransaction = new System.Windows.Forms.Label();
            this.txtCardHolder = new System.Windows.Forms.TextBox();
            this.lbCardHolder = new System.Windows.Forms.Label();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.lbCardID = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.lbProvider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(950, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 45);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxBalance
            // 
            this.tbxBalance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBalance.ForeColor = System.Drawing.Color.White;
            this.tbxBalance.Location = new System.Drawing.Point(269, 52);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.ReadOnly = true;
            this.tbxBalance.Size = new System.Drawing.Size(272, 32);
            this.tbxBalance.TabIndex = 26;
            this.tbxBalance.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Available Balance";
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Location = new System.Drawing.Point(269, 92);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.ReadOnly = true;
            this.tbxCustomerID.Size = new System.Drawing.Size(196, 39);
            this.tbxCustomerID.TabIndex = 39;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(46, 647);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(350, 47);
            this.btnConfirm.TabIndex = 37;
            this.btnConfirm.Text = "Confirm Payment";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "Service Payment Information";
            // 
            // btnElectricity
            // 
            this.btnElectricity.BackColor = System.Drawing.Color.SeaGreen;
            this.btnElectricity.FlatAppearance.BorderSize = 0;
            this.btnElectricity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElectricity.ForeColor = System.Drawing.Color.White;
            this.btnElectricity.Location = new System.Drawing.Point(46, 150);
            this.btnElectricity.Name = "btnElectricity";
            this.btnElectricity.Size = new System.Drawing.Size(271, 129);
            this.btnElectricity.TabIndex = 44;
            this.btnElectricity.Text = "Electricity bill";
            this.btnElectricity.UseVisualStyleBackColor = false;
            this.btnElectricity.Click += new System.EventHandler(this.btnElectricity_Click);
            // 
            // btnWater
            // 
            this.btnWater.BackColor = System.Drawing.Color.SeaGreen;
            this.btnWater.FlatAppearance.BorderSize = 0;
            this.btnWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWater.ForeColor = System.Drawing.Color.White;
            this.btnWater.Location = new System.Drawing.Point(386, 150);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(271, 129);
            this.btnWater.TabIndex = 45;
            this.btnWater.Text = "Water bill";
            this.btnWater.UseVisualStyleBackColor = false;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnInternet
            // 
            this.btnInternet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInternet.FlatAppearance.BorderSize = 0;
            this.btnInternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternet.ForeColor = System.Drawing.Color.White;
            this.btnInternet.Location = new System.Drawing.Point(728, 150);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(271, 129);
            this.btnInternet.TabIndex = 46;
            this.btnInternet.Text = "Internet bill";
            this.btnInternet.UseVisualStyleBackColor = false;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxConfirm.Location = new System.Drawing.Point(226, 602);
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.PasswordChar = '*';
            this.tbxConfirm.Size = new System.Drawing.Size(170, 39);
            this.tbxConfirm.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 602);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 32);
            this.label6.TabIndex = 47;
            this.label6.Text = "Confirm PIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 32);
            this.label5.TabIndex = 50;
            this.label5.Text = "Provider";
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(192, 308);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(318, 40);
            this.cboKhuVuc.TabIndex = 52;
            this.cboKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cboKhuVuc_SelectedIndexChanged);
            // 
            // tbxAmount
            // 
            this.tbxAmount.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAmount.ForeColor = System.Drawing.Color.White;
            this.tbxAmount.Location = new System.Drawing.Point(192, 375);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.ReadOnly = true;
            this.tbxAmount.Size = new System.Drawing.Size(209, 32);
            this.tbxAmount.TabIndex = 53;
            this.tbxAmount.Text = "0.00";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_balance,
            this.column_holder});
            this.dataGridView.Location = new System.Drawing.Point(597, 9);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(300, 106);
            this.dataGridView.TabIndex = 93;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_sotien,
            this.column_trangThai,
            this.column_loai});
            this.dataGridView1.Location = new System.Drawing.Point(597, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(300, 106);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.Visible = false;
            // 
            // column_sotien
            // 
            this.column_sotien.DataPropertyName = "SoTien";
            this.column_sotien.HeaderText = "Column1";
            this.column_sotien.MinimumWidth = 8;
            this.column_sotien.Name = "column_sotien";
            this.column_sotien.Width = 150;
            // 
            // column_trangThai
            // 
            this.column_trangThai.DataPropertyName = "TrangThai";
            this.column_trangThai.HeaderText = "Column1";
            this.column_trangThai.MinimumWidth = 8;
            this.column_trangThai.Name = "column_trangThai";
            this.column_trangThai.Width = 150;
            // 
            // column_loai
            // 
            this.column_loai.DataPropertyName = "LoaiService";
            this.column_loai.HeaderText = "Column1";
            this.column_loai.MinimumWidth = 8;
            this.column_loai.Name = "column_loai";
            this.column_loai.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 32);
            this.label7.TabIndex = 95;
            this.label7.Text = "Status";
            // 
            // tbxStatus
            // 
            this.tbxStatus.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxStatus.ForeColor = System.Drawing.Color.White;
            this.tbxStatus.Location = new System.Drawing.Point(192, 423);
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.ReadOnly = true;
            this.tbxStatus.Size = new System.Drawing.Size(209, 32);
            this.tbxStatus.TabIndex = 96;
            this.tbxStatus.Text = "Paid";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(733, 308);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(49, 32);
            this.textBox6.TabIndex = 133;
            this.textBox6.Text = ":";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(788, 308);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(264, 32);
            this.txtDate.TabIndex = 132;
            this.txtDate.Text = "15/5/2021";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(579, 308);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(64, 32);
            this.lbDate.TabIndex = 131;
            this.lbDate.Text = "Date";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(731, 556);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(49, 32);
            this.textBox1.TabIndex = 130;
            this.textBox1.Text = ":";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(731, 524);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(49, 32);
            this.textBox5.TabIndex = 129;
            this.textBox5.Text = ":";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(731, 492);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(49, 32);
            this.textBox4.TabIndex = 128;
            this.textBox4.Text = ":";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(733, 378);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(49, 32);
            this.textBox3.TabIndex = 127;
            this.textBox3.Text = ":";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(733, 343);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(49, 32);
            this.textBox2.TabIndex = 126;
            this.textBox2.Text = ":";
            // 
            // lbThanks
            // 
            this.lbThanks.AutoSize = true;
            this.lbThanks.ForeColor = System.Drawing.Color.White;
            this.lbThanks.Location = new System.Drawing.Point(629, 596);
            this.lbThanks.Name = "lbThanks";
            this.lbThanks.Size = new System.Drawing.Size(200, 32);
            this.lbThanks.TabIndex = 125;
            this.lbThanks.Text = "*** Thank you ***";
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVAT.ForeColor = System.Drawing.Color.White;
            this.txtVAT.Location = new System.Drawing.Point(786, 556);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(264, 32);
            this.txtVAT.TabIndex = 124;
            this.txtVAT.Text = "0.00 VND";
            // 
            // lbVAT
            // 
            this.lbVAT.AutoSize = true;
            this.lbVAT.ForeColor = System.Drawing.Color.White;
            this.lbVAT.Location = new System.Drawing.Point(577, 556);
            this.lbVAT.Name = "lbVAT";
            this.lbVAT.Size = new System.Drawing.Size(54, 32);
            this.lbVAT.TabIndex = 123;
            this.lbVAT.Text = "VAT";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.ForeColor = System.Drawing.Color.White;
            this.txtBalance.Location = new System.Drawing.Point(786, 524);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(264, 32);
            this.txtBalance.TabIndex = 122;
            this.txtBalance.Text = "9,000,000";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.ForeColor = System.Drawing.Color.White;
            this.lbBalance.Location = new System.Drawing.Point(577, 524);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(96, 32);
            this.lbBalance.TabIndex = 121;
            this.lbBalance.Text = "Balance";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(786, 492);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(264, 32);
            this.txtAmount.TabIndex = 120;
            this.txtAmount.Text = "900,000";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.ForeColor = System.Drawing.Color.White;
            this.lbAmount.Location = new System.Drawing.Point(577, 492);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(100, 32);
            this.lbAmount.TabIndex = 119;
            this.lbAmount.Text = "Amount";
            // 
            // lbTransaction
            // 
            this.lbTransaction.AutoSize = true;
            this.lbTransaction.ForeColor = System.Drawing.Color.White;
            this.lbTransaction.Location = new System.Drawing.Point(658, 423);
            this.lbTransaction.Name = "lbTransaction";
            this.lbTransaction.Size = new System.Drawing.Size(134, 32);
            this.lbTransaction.TabIndex = 118;
            this.lbTransaction.Text = "Transaction";
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtCardHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardHolder.ForeColor = System.Drawing.Color.White;
            this.txtCardHolder.Location = new System.Drawing.Point(788, 378);
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.ReadOnly = true;
            this.txtCardHolder.Size = new System.Drawing.Size(264, 32);
            this.txtCardHolder.TabIndex = 117;
            this.txtCardHolder.Text = "Nguyen Quoc Trung";
            // 
            // lbCardHolder
            // 
            this.lbCardHolder.AutoSize = true;
            this.lbCardHolder.ForeColor = System.Drawing.Color.White;
            this.lbCardHolder.Location = new System.Drawing.Point(579, 378);
            this.lbCardHolder.Name = "lbCardHolder";
            this.lbCardHolder.Size = new System.Drawing.Size(142, 32);
            this.lbCardHolder.TabIndex = 116;
            this.lbCardHolder.Text = "Card Holder";
            // 
            // txtCardID
            // 
            this.txtCardID.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtCardID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardID.ForeColor = System.Drawing.Color.White;
            this.txtCardID.Location = new System.Drawing.Point(788, 343);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.ReadOnly = true;
            this.txtCardID.Size = new System.Drawing.Size(264, 32);
            this.txtCardID.TabIndex = 115;
            this.txtCardID.Text = "4815123";
            // 
            // lbCardID
            // 
            this.lbCardID.AutoSize = true;
            this.lbCardID.ForeColor = System.Drawing.Color.White;
            this.lbCardID.Location = new System.Drawing.Point(579, 343);
            this.lbCardID.Name = "lbCardID";
            this.lbCardID.Size = new System.Drawing.Size(134, 32);
            this.lbCardID.TabIndex = 114;
            this.lbCardID.Text = "Credit Card";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(731, 460);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(49, 32);
            this.textBox7.TabIndex = 136;
            this.textBox7.Text = ":";
            // 
            // txtProvider
            // 
            this.txtProvider.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProvider.ForeColor = System.Drawing.Color.White;
            this.txtProvider.Location = new System.Drawing.Point(786, 460);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.ReadOnly = true;
            this.txtProvider.Size = new System.Drawing.Size(264, 32);
            this.txtProvider.TabIndex = 135;
            this.txtProvider.Text = "900,000";
            // 
            // lbProvider
            // 
            this.lbProvider.AutoSize = true;
            this.lbProvider.ForeColor = System.Drawing.Color.White;
            this.lbProvider.Location = new System.Drawing.Point(577, 460);
            this.lbProvider.Name = "lbProvider";
            this.lbProvider.Size = new System.Drawing.Size(102, 32);
            this.lbProvider.TabIndex = 134;
            this.lbProvider.Text = "Provider";
            // 
            // formServicePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1097, 732);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtProvider);
            this.Controls.Add(this.lbProvider);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbThanks);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.lbVAT);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbTransaction);
            this.Controls.Add(this.txtCardHolder);
            this.Controls.Add(this.lbCardHolder);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.lbCardID);
            this.Controls.Add(this.tbxStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.cboKhuVuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInternet);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.btnElectricity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCustomerID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formServicePayment";
            this.Text = "formServicePayment";
            this.Load += new System.EventHandler(this.formServicePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnElectricity;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.TextBox tbxConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_holder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbThanks;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label lbVAT;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbTransaction;
        private System.Windows.Forms.TextBox txtCardHolder;
        private System.Windows.Forms.Label lbCardHolder;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label lbCardID;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label lbProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_sotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_loai;
    }
}
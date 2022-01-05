
namespace BankingCard_Processer
{
    partial class formDeposit
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
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.column_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_holder = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lbWithdraw = new System.Windows.Forms.Label();
            this.txtCardHolder = new System.Windows.Forms.TextBox();
            this.lbCardHolder = new System.Windows.Forms.Label();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.lbCardID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
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
            this.label4.Size = new System.Drawing.Size(188, 28);
            this.label4.TabIndex = 95;
            this.label4.Text = "Deposit Information";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(153, 138);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(210, 39);
            this.tbxAmount.TabIndex = 92;
            this.tbxAmount.Text = "0";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(46, 228);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(329, 47);
            this.btnConfirm.TabIndex = 91;
            this.btnConfirm.Text = "Confirm Payment";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 89;
            this.label3.Text = "Amount";
            // 
            // tbxBalance
            // 
            this.tbxBalance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBalance.ForeColor = System.Drawing.Color.White;
            this.tbxBalance.Location = new System.Drawing.Point(244, 61);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.Size = new System.Drawing.Size(281, 32);
            this.tbxBalance.TabIndex = 82;
            this.tbxBalance.Text = "so tien hien tai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 81;
            this.label1.Text = "Current Balance";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_balance,
            this.column_holder});
            this.dataGridView.Location = new System.Drawing.Point(458, 31);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(300, 106);
            this.dataGridView.TabIndex = 96;
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
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(658, 156);
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
            this.txtDate.Location = new System.Drawing.Point(713, 156);
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
            this.lbDate.Location = new System.Drawing.Point(504, 156);
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
            this.textBox1.Location = new System.Drawing.Point(658, 453);
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
            this.textBox5.Location = new System.Drawing.Point(658, 406);
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
            this.textBox4.Location = new System.Drawing.Point(658, 361);
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
            this.textBox3.Location = new System.Drawing.Point(658, 243);
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
            this.textBox2.Location = new System.Drawing.Point(658, 194);
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
            this.lbThanks.Location = new System.Drawing.Point(573, 509);
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
            this.txtVAT.Location = new System.Drawing.Point(713, 453);
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
            this.lbVAT.Location = new System.Drawing.Point(504, 453);
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
            this.txtBalance.Location = new System.Drawing.Point(713, 406);
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
            this.lbBalance.Location = new System.Drawing.Point(504, 406);
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
            this.txtAmount.Location = new System.Drawing.Point(713, 361);
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
            this.lbAmount.Location = new System.Drawing.Point(504, 361);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(100, 32);
            this.lbAmount.TabIndex = 119;
            this.lbAmount.Text = "Amount";
            // 
            // lbWithdraw
            // 
            this.lbWithdraw.AutoSize = true;
            this.lbWithdraw.ForeColor = System.Drawing.Color.White;
            this.lbWithdraw.Location = new System.Drawing.Point(555, 300);
            this.lbWithdraw.Name = "lbWithdraw";
            this.lbWithdraw.Size = new System.Drawing.Size(223, 32);
            this.lbWithdraw.TabIndex = 118;
            this.lbWithdraw.Text = "Deposit Transaction";
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtCardHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardHolder.ForeColor = System.Drawing.Color.White;
            this.txtCardHolder.Location = new System.Drawing.Point(713, 243);
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.ReadOnly = true;
            this.txtCardHolder.Size = new System.Drawing.Size(264, 32);
            this.txtCardHolder.TabIndex = 117;
            this.txtCardHolder.Text = "Nguyen Quoc ";
            // 
            // lbCardHolder
            // 
            this.lbCardHolder.AutoSize = true;
            this.lbCardHolder.ForeColor = System.Drawing.Color.White;
            this.lbCardHolder.Location = new System.Drawing.Point(504, 243);
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
            this.txtCardID.Location = new System.Drawing.Point(713, 194);
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
            this.lbCardID.Location = new System.Drawing.Point(504, 194);
            this.lbCardID.Name = "lbCardID";
            this.lbCardID.Size = new System.Drawing.Size(134, 32);
            this.lbCardID.TabIndex = 114;
            this.lbCardID.Text = "Credit Card";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(924, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 44);
            this.btnClose.TabIndex = 80;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInvoice.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Location = new System.Drawing.Point(762, 607);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(264, 47);
            this.btnInvoice.TabIndex = 134;
            this.btnInvoice.Text = "Invoice ";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // formDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1086, 691);
            this.Controls.Add(this.btnInvoice);
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
            this.Controls.Add(this.lbWithdraw);
            this.Controls.Add(this.txtCardHolder);
            this.Controls.Add(this.lbCardHolder);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.lbCardID);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDeposit";
            this.Text = "formDeposit";
            this.Load += new System.EventHandler(this.formDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_holder;
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
        private System.Windows.Forms.Label lbWithdraw;
        private System.Windows.Forms.TextBox txtCardHolder;
        private System.Windows.Forms.Label lbCardHolder;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label lbCardID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInvoice;
    }
}
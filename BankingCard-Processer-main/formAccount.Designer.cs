
namespace BankingCard_Processer
{
    partial class formAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCardID = new System.Windows.Forms.TextBox();
            this.tbxCardHolder = new System.Windows.Forms.TextBox();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTTGD = new System.Windows.Forms.DataGridView();
            this.gdColumn_ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdColumn_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdColumn_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdColumn_sotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTTKH = new System.Windows.Forms.DataGridView();
            this.infoColumn_cardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoColumn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoColumn_SoDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChangePIN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.txtRetype = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grbChangPIN = new System.Windows.Forms.GroupBox();
            this.btnSavePIN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTKH)).BeginInit();
            this.grbChangPIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit Card";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(45, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card Holder";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(45, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            // 
            // tbxCardID
            // 
            this.tbxCardID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCardID.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxCardID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCardID.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCardID.ForeColor = System.Drawing.Color.White;
            this.tbxCardID.Location = new System.Drawing.Point(231, 47);
            this.tbxCardID.Name = "tbxCardID";
            this.tbxCardID.ReadOnly = true;
            this.tbxCardID.Size = new System.Drawing.Size(570, 34);
            this.tbxCardID.TabIndex = 3;
            this.tbxCardID.Text = "4815093857461";
            // 
            // tbxCardHolder
            // 
            this.tbxCardHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCardHolder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxCardHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCardHolder.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCardHolder.ForeColor = System.Drawing.Color.White;
            this.tbxCardHolder.Location = new System.Drawing.Point(231, 100);
            this.tbxCardHolder.Name = "tbxCardHolder";
            this.tbxCardHolder.ReadOnly = true;
            this.tbxCardHolder.Size = new System.Drawing.Size(570, 34);
            this.tbxCardHolder.TabIndex = 4;
            this.tbxCardHolder.Text = "Nguyễn Quốc Trung";
            // 
            // tbxBalance
            // 
            this.tbxBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBalance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBalance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBalance.ForeColor = System.Drawing.Color.White;
            this.tbxBalance.Location = new System.Drawing.Point(231, 154);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.ReadOnly = true;
            this.tbxBalance.Size = new System.Drawing.Size(570, 34);
            this.tbxBalance.TabIndex = 5;
            this.tbxBalance.Text = "10,000,000";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(45, 210);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(260, 43);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Show Card Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(826, 31);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 41);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Account Information";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(435, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(86, 32);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "VNĐ";
            // 
            // MaGD
            // 
            this.MaGD.HeaderText = "MaGD";
            this.MaGD.MinimumWidth = 8;
            this.MaGD.Name = "MaGD";
            this.MaGD.Width = 150;
            // 
            // LoaiGD
            // 
            this.LoaiGD.HeaderText = "LoaiGD";
            this.LoaiGD.MinimumWidth = 8;
            this.LoaiGD.Name = "LoaiGD";
            this.LoaiGD.Width = 150;
            // 
            // ThoiGianGD
            // 
            this.ThoiGianGD.HeaderText = "ThoiGianGD";
            this.ThoiGianGD.MinimumWidth = 8;
            this.ThoiGianGD.Name = "ThoiGianGD";
            this.ThoiGianGD.Width = 150;
            // 
            // SoTienGD
            // 
            this.SoTienGD.HeaderText = "SoTienGD";
            this.SoTienGD.MinimumWidth = 8;
            this.SoTienGD.Name = "SoTienGD";
            this.SoTienGD.Width = 150;
            // 
            // dataGridViewTTGD
            // 
            this.dataGridViewTTGD.AllowUserToAddRows = false;
            this.dataGridViewTTGD.AllowUserToDeleteRows = false;
            this.dataGridViewTTGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTTGD.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewTTGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTTGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gdColumn_ngay,
            this.gdColumn_ma,
            this.gdColumn_loai,
            this.gdColumn_sotien});
            this.dataGridViewTTGD.Location = new System.Drawing.Point(45, 330);
            this.dataGridViewTTGD.Name = "dataGridViewTTGD";
            this.dataGridViewTTGD.ReadOnly = true;
            this.dataGridViewTTGD.RowHeadersVisible = false;
            this.dataGridViewTTGD.RowHeadersWidth = 62;
            this.dataGridViewTTGD.RowTemplate.Height = 33;
            this.dataGridViewTTGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTTGD.Size = new System.Drawing.Size(616, 259);
            this.dataGridViewTTGD.TabIndex = 11;
            // 
            // gdColumn_ngay
            // 
            this.gdColumn_ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gdColumn_ngay.DataPropertyName = "ThoiGianGD";
            this.gdColumn_ngay.HeaderText = "Ngày giao dịch";
            this.gdColumn_ngay.MinimumWidth = 8;
            this.gdColumn_ngay.Name = "gdColumn_ngay";
            this.gdColumn_ngay.ReadOnly = true;
            this.gdColumn_ngay.Width = 211;
            // 
            // gdColumn_ma
            // 
            this.gdColumn_ma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gdColumn_ma.DataPropertyName = "MaGD";
            this.gdColumn_ma.HeaderText = "Mã";
            this.gdColumn_ma.MinimumWidth = 8;
            this.gdColumn_ma.Name = "gdColumn_ma";
            this.gdColumn_ma.ReadOnly = true;
            this.gdColumn_ma.Visible = false;
            this.gdColumn_ma.Width = 150;
            // 
            // gdColumn_loai
            // 
            this.gdColumn_loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gdColumn_loai.DataPropertyName = "LoaiGD";
            this.gdColumn_loai.HeaderText = "Loại";
            this.gdColumn_loai.MinimumWidth = 8;
            this.gdColumn_loai.Name = "gdColumn_loai";
            this.gdColumn_loai.ReadOnly = true;
            this.gdColumn_loai.Width = 93;
            // 
            // gdColumn_sotien
            // 
            this.gdColumn_sotien.DataPropertyName = "SoTienGD";
            this.gdColumn_sotien.HeaderText = "SoTienGD";
            this.gdColumn_sotien.MinimumWidth = 8;
            this.gdColumn_sotien.Name = "gdColumn_sotien";
            this.gdColumn_sotien.ReadOnly = true;
            // 
            // dataGridViewTTKH
            // 
            this.dataGridViewTTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTTKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.infoColumn_cardid,
            this.infoColumn_name,
            this.infoColumn_SoDu});
            this.dataGridViewTTKH.Location = new System.Drawing.Point(541, 31);
            this.dataGridViewTTKH.Name = "dataGridViewTTKH";
            this.dataGridViewTTKH.RowHeadersWidth = 62;
            this.dataGridViewTTKH.RowTemplate.Height = 33;
            this.dataGridViewTTKH.Size = new System.Drawing.Size(220, 139);
            this.dataGridViewTTKH.TabIndex = 12;
            this.dataGridViewTTKH.Visible = false;
            // 
            // infoColumn_cardid
            // 
            this.infoColumn_cardid.DataPropertyName = "CardID";
            this.infoColumn_cardid.HeaderText = "Column1";
            this.infoColumn_cardid.MinimumWidth = 8;
            this.infoColumn_cardid.Name = "infoColumn_cardid";
            this.infoColumn_cardid.Width = 150;
            // 
            // infoColumn_name
            // 
            this.infoColumn_name.DataPropertyName = "HoTenKH";
            this.infoColumn_name.HeaderText = "Column2";
            this.infoColumn_name.MinimumWidth = 8;
            this.infoColumn_name.Name = "infoColumn_name";
            this.infoColumn_name.Width = 150;
            // 
            // infoColumn_SoDu
            // 
            this.infoColumn_SoDu.DataPropertyName = "SoDu";
            this.infoColumn_SoDu.HeaderText = "Column3";
            this.infoColumn_SoDu.MinimumWidth = 8;
            this.infoColumn_SoDu.Name = "infoColumn_SoDu";
            this.infoColumn_SoDu.Width = 150;
            // 
            // btnChangePIN
            // 
            this.btnChangePIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePIN.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChangePIN.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnChangePIN.FlatAppearance.BorderSize = 0;
            this.btnChangePIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePIN.ForeColor = System.Drawing.Color.White;
            this.btnChangePIN.Location = new System.Drawing.Point(705, 210);
            this.btnChangePIN.Name = "btnChangePIN";
            this.btnChangePIN.Size = new System.Drawing.Size(207, 43);
            this.btnChangePIN.TabIndex = 13;
            this.btnChangePIN.Text = "Change PIN";
            this.btnChangePIN.UseVisualStyleBackColor = false;
            this.btnChangePIN.Click += new System.EventHandler(this.btnChangePIN_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(77, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Current";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(190, 56);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.PasswordChar = '*';
            this.txtCurrent.Size = new System.Drawing.Size(264, 39);
            this.txtCurrent.TabIndex = 15;
            // 
            // txtRetype
            // 
            this.txtRetype.Location = new System.Drawing.Point(190, 154);
            this.txtRetype.Name = "txtRetype";
            this.txtRetype.PasswordChar = '*';
            this.txtRetype.Size = new System.Drawing.Size(264, 39);
            this.txtRetype.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(19, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "Re-type new";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(190, 104);
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '*';
            this.txtNew.Size = new System.Drawing.Size(264, 39);
            this.txtNew.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(112, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 36);
            this.label7.TabIndex = 18;
            this.label7.Text = "New";
            // 
            // grbChangPIN
            // 
            this.grbChangPIN.Controls.Add(this.btnSavePIN);
            this.grbChangPIN.Controls.Add(this.label5);
            this.grbChangPIN.Controls.Add(this.txtNew);
            this.grbChangPIN.Controls.Add(this.txtCurrent);
            this.grbChangPIN.Controls.Add(this.label7);
            this.grbChangPIN.Controls.Add(this.label6);
            this.grbChangPIN.Controls.Add(this.txtRetype);
            this.grbChangPIN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbChangPIN.Location = new System.Drawing.Point(45, 330);
            this.grbChangPIN.Name = "grbChangPIN";
            this.grbChangPIN.Size = new System.Drawing.Size(616, 278);
            this.grbChangPIN.TabIndex = 20;
            this.grbChangPIN.TabStop = false;
            this.grbChangPIN.Text = "Change PIN";
            this.grbChangPIN.Visible = false;
            // 
            // btnSavePIN
            // 
            this.btnSavePIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSavePIN.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSavePIN.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnSavePIN.FlatAppearance.BorderSize = 0;
            this.btnSavePIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePIN.ForeColor = System.Drawing.Color.White;
            this.btnSavePIN.Location = new System.Drawing.Point(190, 229);
            this.btnSavePIN.Name = "btnSavePIN";
            this.btnSavePIN.Size = new System.Drawing.Size(207, 43);
            this.btnSavePIN.TabIndex = 21;
            this.btnSavePIN.Text = "Save changes";
            this.btnSavePIN.UseVisualStyleBackColor = false;
            this.btnSavePIN.Click += new System.EventHandler(this.btnSavePIN_Click);
            // 
            // formAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(962, 673);
            this.Controls.Add(this.grbChangPIN);
            this.Controls.Add(this.btnChangePIN);
            this.Controls.Add(this.dataGridViewTTKH);
            this.Controls.Add(this.dataGridViewTTGD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.tbxBalance);
            this.Controls.Add(this.tbxCardHolder);
            this.Controls.Add(this.tbxCardID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formAccount";
            this.Text = "formAccount";
            this.Load += new System.EventHandler(this.formAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTKH)).EndInit();
            this.grbChangPIN.ResumeLayout(false);
            this.grbChangPIN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCardID;
        private System.Windows.Forms.TextBox tbxCardHolder;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienGD;
        private System.Windows.Forms.DataGridView dataGridViewTTGD;
        private System.Windows.Forms.DataGridView dataGridViewTTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoColumn_cardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoColumn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoColumn_SoDu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdColumn_ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdColumn_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdColumn_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdColumn_sotien;
        private System.Windows.Forms.Button btnChangePIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.TextBox txtRetype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbChangPIN;
        private System.Windows.Forms.Button btnSavePIN;
    }
}
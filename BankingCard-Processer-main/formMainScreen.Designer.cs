
namespace BankingCard_Processer
{
    partial class formMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainScreen));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelWitDepSubmenu = new System.Windows.Forms.Panel();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnWitdrwDepst = new System.Windows.Forms.Button();
            this.panelTransactionsSubmenu = new System.Windows.Forms.Panel();
            this.btnPOSPayment = new System.Windows.Forms.Button();
            this.btnServicePayment = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panelTopPadding = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelWitDepSubmenu.SuspendLayout();
            this.panelTransactionsSubmenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.panelWitDepSubmenu);
            this.panelSideMenu.Controls.Add(this.btnWitdrwDepst);
            this.panelSideMenu.Controls.Add(this.panelTransactionsSubmenu);
            this.panelSideMenu.Controls.Add(this.btnTransactions);
            this.panelSideMenu.Controls.Add(this.btnAccount);
            this.panelSideMenu.Controls.Add(this.panelTopPadding);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 730);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 685);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 45);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelWitDepSubmenu
            // 
            this.panelWitDepSubmenu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelWitDepSubmenu.Controls.Add(this.btnDeposit);
            this.panelWitDepSubmenu.Controls.Add(this.btnWithdraw);
            this.panelWitDepSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWitDepSubmenu.Location = new System.Drawing.Point(0, 360);
            this.panelWitDepSubmenu.Name = "panelWitDepSubmenu";
            this.panelWitDepSubmenu.Size = new System.Drawing.Size(250, 85);
            this.panelWitDepSubmenu.TabIndex = 8;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(0, 40);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeposit.Size = new System.Drawing.Size(250, 40);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(0, 0);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(250, 40);
            this.btnWithdraw.TabIndex = 0;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnWitdrwDepst
            // 
            this.btnWitdrwDepst.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWitdrwDepst.FlatAppearance.BorderSize = 0;
            this.btnWitdrwDepst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWitdrwDepst.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWitdrwDepst.ForeColor = System.Drawing.Color.White;
            this.btnWitdrwDepst.Location = new System.Drawing.Point(0, 315);
            this.btnWitdrwDepst.Name = "btnWitdrwDepst";
            this.btnWitdrwDepst.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnWitdrwDepst.Size = new System.Drawing.Size(250, 45);
            this.btnWitdrwDepst.TabIndex = 7;
            this.btnWitdrwDepst.Text = "Withdraw / Depost";
            this.btnWitdrwDepst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWitdrwDepst.UseVisualStyleBackColor = true;
            this.btnWitdrwDepst.Click += new System.EventHandler(this.btnWitdrwDepst_Click);
            // 
            // panelTransactionsSubmenu
            // 
            this.panelTransactionsSubmenu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelTransactionsSubmenu.Controls.Add(this.btnPOSPayment);
            this.panelTransactionsSubmenu.Controls.Add(this.btnServicePayment);
            this.panelTransactionsSubmenu.Controls.Add(this.btnTransfer);
            this.panelTransactionsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransactionsSubmenu.Location = new System.Drawing.Point(0, 190);
            this.panelTransactionsSubmenu.Name = "panelTransactionsSubmenu";
            this.panelTransactionsSubmenu.Size = new System.Drawing.Size(250, 125);
            this.panelTransactionsSubmenu.TabIndex = 6;
            // 
            // btnPOSPayment
            // 
            this.btnPOSPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOSPayment.FlatAppearance.BorderSize = 0;
            this.btnPOSPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOSPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPOSPayment.ForeColor = System.Drawing.Color.White;
            this.btnPOSPayment.Location = new System.Drawing.Point(0, 80);
            this.btnPOSPayment.Name = "btnPOSPayment";
            this.btnPOSPayment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPOSPayment.Size = new System.Drawing.Size(250, 40);
            this.btnPOSPayment.TabIndex = 2;
            this.btnPOSPayment.Text = "POS payment";
            this.btnPOSPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOSPayment.UseVisualStyleBackColor = true;
            this.btnPOSPayment.Click += new System.EventHandler(this.btnPOSPayment_Click);
            // 
            // btnServicePayment
            // 
            this.btnServicePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicePayment.FlatAppearance.BorderSize = 0;
            this.btnServicePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicePayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnServicePayment.ForeColor = System.Drawing.Color.White;
            this.btnServicePayment.Location = new System.Drawing.Point(0, 40);
            this.btnServicePayment.Name = "btnServicePayment";
            this.btnServicePayment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnServicePayment.Size = new System.Drawing.Size(250, 40);
            this.btnServicePayment.TabIndex = 1;
            this.btnServicePayment.Text = "Service payment";
            this.btnServicePayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicePayment.UseVisualStyleBackColor = true;
            this.btnServicePayment.Click += new System.EventHandler(this.btnServicePayment_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(0, 0);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTransfer.Size = new System.Drawing.Size(250, 40);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Location = new System.Drawing.Point(0, 145);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransactions.Size = new System.Drawing.Size(250, 45);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(0, 100);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(250, 45);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panelTopPadding
            // 
            this.panelTopPadding.BackColor = System.Drawing.Color.SeaGreen;
            this.panelTopPadding.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopPadding.Location = new System.Drawing.Point(0, 0);
            this.panelTopPadding.Name = "panelTopPadding";
            this.panelTopPadding.Size = new System.Drawing.Size(250, 100);
            this.panelTopPadding.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1044, 730);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // formMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1294, 730);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1294, 730);
            this.Name = "formMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMainScreen_FormClosed);
            this.panelSideMenu.ResumeLayout(false);
            this.panelWitDepSubmenu.ResumeLayout(false);
            this.panelTransactionsSubmenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelTopPadding;
        private System.Windows.Forms.Panel panelTransactionsSubmenu;
        private System.Windows.Forms.Button btnPOSPayment;
        private System.Windows.Forms.Button btnServicePayment;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel panelWitDepSubmenu;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnWitdrwDepst;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
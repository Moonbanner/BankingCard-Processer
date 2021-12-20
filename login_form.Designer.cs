
namespace BankingCard_Processer
{
    partial class login_form
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(54, 72);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(60, 15);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(54, 116);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(57, 15);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(138, 113);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(212, 23);
            this.passtxt.TabIndex = 2;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(138, 69);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(212, 23);
            this.usertxt.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(205, 165);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(447, 276);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Button buttonLogin;
    }
}
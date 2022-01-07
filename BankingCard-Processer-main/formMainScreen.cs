using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;

namespace BankingCard_Processer
{
    public partial class formMainScreen : Form
    {
        public string cardID;

        public formMainScreen()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelTransactionsSubmenu.Visible = false;
            panelWitDepSubmenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelTransactionsSubmenu.Visible == true)
                panelTransactionsSubmenu.Visible = false;
            if (panelWitDepSubmenu.Visible == true)
                panelWitDepSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region Account SubMenu
        #endregion
        #region Transactions SubMenu
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTransactionsSubmenu);
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            openChildForm(new formTransfer(this.cardID));
        }
        private void btnServicePayment_Click(object sender, EventArgs e)
        {
            openChildForm(new formServicePayment(this.cardID));
        }
        private void btnPOSPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new formPOSPayment(this.cardID));
        }
        #endregion
        #region Withdraw/Deposit SubMenu
        private void btnWitdrwDepst_Click(object sender, EventArgs e) //btnWitdrwDepst
        {
            showSubMenu(panelWitDepSubmenu);
        } 
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            openChildForm(new formWithdraw(this.cardID));
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            openChildForm(new formDeposit(this.cardID));
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new formAccount(this.cardID));
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void formMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you want to log out?", "Alert!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                formLogin formLogin = new formLogin();
                formLogin.ShowDialog();
            }
        }
    }
}

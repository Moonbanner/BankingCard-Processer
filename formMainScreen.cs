using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankingCard_Processer
{
    public partial class formMainScreen : Form
    {
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
        private void btnAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new formAccount());
            hideSubMenu();
        }
        #endregion
        #region Transactions SubMenu
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTransactionsSubmenu);
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            openChildForm(new formTransfer());
        }
        private void btnServicePayment_Click(object sender, EventArgs e)
        {
            openChildForm(new formServicePayment());
        }
        private void btnPOSPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new formPOSPayment());
        }
        #endregion
        #region Withdraw/Deposit SubMenu
        private void btnWitdrwDepst_Click(object sender, EventArgs e) //btnWitdrwDepst
        {
            showSubMenu(panelWitDepSubmenu);
        } 
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            openChildForm(new formWithdraw());
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            openChildForm(new formDeposit());
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close the app?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

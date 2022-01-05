using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace BankingCard_Processer
{
    public partial class formLogin : Form
    {
        BUS_CardInfo bus_cardInfo = new BUS_CardInfo();
        public formLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string cardID = txtCardId.Text.ToString();
            string pin = txtPin.Text.ToString();
            formMainScreen formMainScreen = new formMainScreen();

            if (cardID != "" && pin != "")
            {
                if (bus_cardInfo.login(cardID, pin))
                {
                    //MessageBox.Show("Logged in successfully");
                    this.Hide();
                    formMainScreen.cardID = cardID;
                    formMainScreen.ShowDialog();
                }
                else
                    MessageBox.Show("Wrong PIN");
            }
            else
            {
                MessageBox.Show("Please type full");
            }
        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the app?", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

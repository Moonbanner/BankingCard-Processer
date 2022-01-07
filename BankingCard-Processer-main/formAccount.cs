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
    public partial class formAccount : Form
    {
        BUS_CardInfo bus_cardInfo = new BUS_CardInfo();

        public string cardID;
        public formAccount(string cardID)
        {
            InitializeComponent();
            this.cardID = cardID;
        }

        void loadDataTTGD()
        {
            dataGridViewTTGD.DataSource = bus_cardInfo.loadDataTTGD(this.cardID).Tables[0];
        }

        void loadDataTTKH()
        {
            dataGridViewTTKH.DataSource = bus_cardInfo.loadDataTTKH(this.cardID).Tables[0];
            DataGridViewRow row = dataGridViewTTKH.Rows[0];
            tbxCardID.Text = row.Cells["infoColumn_cardid"].Value.ToString();
            tbxCardHolder.Text = row.Cells["infoColumn_name"].Value.ToString();
            string formatted = string.Format("{0:#,##0.##}", int.Parse(row.Cells["infoColumn_SoDu"].Value.ToString()));
            tbxBalance.Text = formatted;

            //formatted = formatted.Replace(",", "");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formAccount_Load(object sender, EventArgs e)
        {
            dataGridViewTTGD.Visible = false;
            loadDataTTGD();
            loadDataTTKH();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dataGridViewTTGD.Visible == false)
            {
                dataGridViewTTGD.Visible = true;
                grbChangPIN.Visible = false;
            }
            else
                dataGridViewTTGD.Visible = false;
        }

        private void btnChangePIN_Click(object sender, EventArgs e)
        {
            if (grbChangPIN.Visible == false)
            {
                txtCurrent.Text = "";
                txtNew.Text = "";
                txtRetype.Text = "";
                grbChangPIN.Visible = true;
                dataGridViewTTGD.Visible = false;
            }
            else
                grbChangPIN.Visible = false;
        }

        private void btnSavePIN_Click(object sender, EventArgs e)
        {
            if (txtCurrent.Text == "" || txtNew.Text == "" || txtRetype.Text == "")
            {
                MessageBox.Show("Please type full");
                return;
            }
            string current = txtCurrent.Text;
            string newPIN = txtNew.Text;
            string reType = txtRetype.Text;
            if (bus_cardInfo.login(this.cardID, current))
            {
                if (newPIN == reType)
                {
                    if (bus_cardInfo.changePIN(this.cardID, newPIN))
                        MessageBox.Show("Change PIN successfully");
                    else
                        MessageBox.Show("Please try again");
                }
                else
                    MessageBox.Show("Passwords do not match");
            }
            else
                MessageBox.Show("PIN current wrong");
        }
    }
}

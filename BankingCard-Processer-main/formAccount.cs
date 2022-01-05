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
            dataGridViewTTGD.Visible = true;
        }
    }
}

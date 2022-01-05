using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace BankingCard_Processer
{
    public partial class formDeposit : Form
    {
        BUS_Deposit bus_deposit = new BUS_Deposit();
        BUS_CardInfo bus_cardInfo = new BUS_CardInfo();
        Random random = new Random();
        DateTime date;
        public string cardID;
        int balance = 0;

        public formDeposit(string cardID)
        {
            InitializeComponent();
            this.cardID = cardID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadData()
        {
            dataGridView.DataSource = bus_deposit.loadData(this.cardID).Tables[0];
            DataGridViewRow row = dataGridView.Rows[0];
            balance = int.Parse(row.Cells["column_balance"].Value.ToString());
            string formatted = string.Format("{0:#,##0.##}", balance);
            tbxBalance.Text = formatted;
            tbxAmount.Text = "0";
        }

        private void formDeposit_Load(object sender, EventArgs e)
        {
            loadData();
            visibleInvoice(false);
        }

        void visibleInvoice(bool b)
        {
            lbDate.Visible = b;
            lbCardID.Visible = b;
            lbCardHolder.Visible = b;
            lbWithdraw.Visible = b;
            lbAmount.Visible = b;
            lbBalance.Visible = b;
            lbVAT.Visible = b;
            lbThanks.Visible = b;
            txtDate.Visible = b;
            txtCardID.Visible = b;
            txtCardHolder.Visible = b;
            txtAmount.Visible = b;
            txtBalance.Visible = b;
            txtVAT.Visible = b;
            textBox1.Visible = b;
            textBox2.Visible = b;
            textBox3.Visible = b;
            textBox4.Visible = b;
            textBox5.Visible = b;
            textBox6.Visible = b;
        }

        void setInvoice()
        {
            date = DateTime.Now;
            txtDate.Text = date.ToShortDateString();
            DataGridViewRow row = dataGridView.Rows[0];
            txtCardHolder.Text = row.Cells["column_holder"].Value.ToString();
            txtCardID.Text = this.cardID;
            string formatted = string.Format("{0:#,##0.##}", int.Parse(tbxAmount.Text));
            txtAmount.Text = formatted;
            int moneyUpdate = balance + int.Parse(tbxAmount.Text);
            formatted = string.Format("{0:#,##0.##}", moneyUpdate);
            txtBalance.Text = formatted.ToString();
        }

        void addInvoice()
        {
            string maGD = random.Next(99999) + "";
            string loaiGD = "Deposit";
            date = DateTime.Now;
            DTO_TransactionInfo dto_transactionInfo = new DTO_TransactionInfo(this.cardID, maGD, loaiGD, date.ToShortDateString(), "+" + tbxAmount.Text);
            bus_deposit.addInvoice(dto_transactionInfo);
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int moneyUpdate = int.Parse(tbxAmount.Text) + balance;
            bus_deposit.depositMoney(this.cardID, moneyUpdate.ToString());
            setInvoice();
            addInvoice();
            loadData();
            visibleInvoice(true);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice Printing Successful");
            visibleInvoice(false);
            loadData();
        }
    }
}

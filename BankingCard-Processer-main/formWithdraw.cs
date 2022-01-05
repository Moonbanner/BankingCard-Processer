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
    public partial class formWithdraw : Form
    {
        BUS_Withdraw bus_withdraw = new BUS_Withdraw();
        BUS_CardInfo bus_cardInfo = new BUS_CardInfo();
        Random random = new Random();
        DateTime date;
        public string cardID;
        int amount = 0;
        int balance = 0;

        public formWithdraw(string cardID)
        {
            InitializeComponent();
            this.cardID = cardID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool check10m(int money)
        {
            if (money > 10000000)
                return true;
            return false;
        }

        private void btn50k_Click(object sender, EventArgs e)
        {
            amount = int.Parse(tbxAmount.Text) + 50000;
            if (check10m(amount))
                return;
            tbxAmount.Text = amount.ToString();
        }

        private void btn100k_Click(object sender, EventArgs e)
        {
            amount = int.Parse(tbxAmount.Text) + 100000;
            if (check10m(amount))
                return;
            tbxAmount.Text = amount.ToString();
        }

        private void btn200k_Click(object sender, EventArgs e)
        {
            amount = int.Parse(tbxAmount.Text) + 200000;
            if (check10m(amount))
                return;
            tbxAmount.Text = amount.ToString();
        }

        private void btn500k_Click(object sender, EventArgs e)
        {
            amount = int.Parse(tbxAmount.Text) + 500000;
            if (check10m(amount))
                return;
            tbxAmount.Text = amount.ToString();
        }

        private void btn1000k_Click(object sender, EventArgs e)
        {
            amount = int.Parse(tbxAmount.Text) + 1000000;
            if (check10m(amount))
                return;
            tbxAmount.Text = amount.ToString();
        }

        private void btn10000k_Click(object sender, EventArgs e)
        {
            amount = int.Parse(tbxAmount.Text) + 10000000;
            if (check10m(amount))
                return;
            tbxAmount.Text = amount.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxAmount.Text = "0";
            amount = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (bus_cardInfo.login(this.cardID, tbxConfirm.Text))
            {
                if (balance > int.Parse(tbxAmount.Text))
                {
                    int moneyUpdate = balance - int.Parse(tbxAmount.Text);
                    bus_withdraw.withdrawMoney(this.cardID, moneyUpdate.ToString());
                    visibleInvoice(true);
                    setInvoice();
                    addInvoice();
                    loadData();
                }
                else
                    MessageBox.Show("Insufficient account balance");
            }
            else
            {
                MessageBox.Show("Invalid PIN code");
            }
        }

        void addInvoice()
        {
            string maGD = random.Next(99999) + "";
            string loaiGD = "Withdraw";
            date = DateTime.Now;
            DTO_TransactionInfo dto_transactionInfo = new DTO_TransactionInfo(this.cardID, maGD, loaiGD, date.ToShortDateString(), "-" + tbxAmount.Text);
            bus_withdraw.addInvoice(dto_transactionInfo);
        }

        void loadData()
        {
            dataGridView.DataSource = bus_withdraw.loadData(this.cardID).Tables[0];
            DataGridViewRow row = dataGridView.Rows[0];
            balance = int.Parse(row.Cells["column_balance"].Value.ToString());
            string formatted = string.Format("{0:#,##0.##}", int.Parse(balance.ToString()));
            tbxBalance.Text = formatted;
            tbxAmount.Text = "0";
            tbxConfirm.Text = "";
            amount = 0;
            //formatted = formatted.Replace(",","");
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
            int moneyUpdate = balance - int.Parse(tbxAmount.Text);
            formatted = string.Format("{0:#,##0.##}", moneyUpdate);
            txtBalance.Text = formatted;
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
            btnInvoice.Visible = b;
        }

        private void formWithdraw_Load(object sender, EventArgs e)
        {
            visibleInvoice(false);
            loadData();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice Printing Successful");
            visibleInvoice(false);
            loadData();
        }
    }
}

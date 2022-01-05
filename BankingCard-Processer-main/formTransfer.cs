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
    public partial class formTransfer : Form
    {
        BUS_CardInfo bus_cardInfo = new BUS_CardInfo();
        BUS_Transfer bus_transfer = new BUS_Transfer();
        string cardID;
        int balance = 0;
        int amount = 0;
        DateTime date;
        Random random = new Random();

        public formTransfer(string cardID)
        {
            InitializeComponent();
            this.cardID = cardID;
        }

        bool check10m(int money)
        {
            if (money > 10000000)
                return true;
            return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            lbToAcc.Visible = b;
            txtDate.Visible = b;
            txtCardID.Visible = b;
            txtCardHolder.Visible = b;
            txtAmount.Visible = b;
            txtBalance.Visible = b;
            txtVAT.Visible = b;
            txtBeneID.Visible = b;
            textBox1.Visible = b;
            textBox2.Visible = b;
            textBox3.Visible = b;
            textBox4.Visible = b;
            textBox5.Visible = b;
            textBox6.Visible = b;
            textBox7.Visible = b;
            btnInvoice.Visible = b;
        }


        void loadData()
        {
            dataGridView.DataSource = bus_transfer.loadData(this.cardID).Tables[0];
            DataGridViewRow row = dataGridView.Rows[0];
            balance = int.Parse(row.Cells["column_balance"].Value.ToString());
            string formatted = string.Format("{0:#,##0.##}", balance);
            tbxBalance.Text = formatted;
            amount = 0;
            tbxAmount.Text = "0";
            tbxBeneID.Text = "";
            tbxConfirm.Text = "";
        }

        private void formTransfer_Load(object sender, EventArgs e)
        {
            visibleInvoice(false);
            loadData();
        }

        private void tbxBeneID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (bus_transfer.findCardID(tbxBeneID.Text))
                {
                    if(tbxBeneID.Text == this.cardID)
                    {
                        MessageBox.Show("Can't transfer to yourself");
                        return;
                    }
                    dataGridViewBene.DataSource = bus_transfer.findBeneName(tbxBeneID.Text).Tables[0];
                    DataGridViewRow row = dataGridViewBene.Rows[0];
                    tbxBeneName.Text = row.Cells["beneColumn_name"].Value.ToString();
                }
                else
                    MessageBox.Show("Beneficiary account not exist");
            }
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
            txtBeneID.Text = tbxBeneID.Text;
            int moneyUpdate = balance - int.Parse(tbxAmount.Text);
            formatted = string.Format("{0:#,##0.##}", moneyUpdate);
            txtBalance.Text = formatted;
        }

        void addInvoice()
        {
            string maGD = random.Next(99999) + "";
            string maGD1 = random.Next(99999) + "";
            string loaiGD = "Transfer";
            date = DateTime.Now;
            DTO_TransactionInfo dto_transactionInfo = new DTO_TransactionInfo(this.cardID, maGD, loaiGD, date.ToShortDateString(), "-" + tbxAmount.Text);
            DTO_TransactionInfo dto_transactionInfoBene = new DTO_TransactionInfo(tbxBeneID.Text, maGD1, loaiGD, date.ToShortDateString(), "+" + tbxAmount.Text);
            bus_transfer.addInvoice(dto_transactionInfo, dto_transactionInfoBene);

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!bus_transfer.findCardID(tbxBeneID.Text))
            {
                MessageBox.Show("Beneficiary account not exist");
                return;
            }
            if (tbxBeneID.Text == this.cardID)
            {
                MessageBox.Show("Can't transfer to yourself");
                return;
            }
            dataGridViewBene.DataSource = bus_transfer.findBeneName(tbxBeneID.Text).Tables[0];
            DataGridViewRow row = dataGridViewBene.Rows[0];
            tbxBeneName.Text = row.Cells["beneColumn_name"].Value.ToString();
            if (bus_cardInfo.login(this.cardID, tbxConfirm.Text))
            {
                if (balance > int.Parse(tbxAmount.Text))
                {
                    //User
                    int moneyUpdate = balance - int.Parse(tbxAmount.Text);
                    //Bene
                    DataGridViewRow rowBene = dataGridViewBene.Rows[0];
                    string moneyBene = rowBene.Cells["beneColumn_sodu"].Value.ToString();
                    int moneyUpdateBene = int.Parse(moneyBene) + int.Parse(tbxAmount.Text);

                    bus_transfer.transfer(this.cardID, moneyUpdate.ToString(), tbxBeneID.Text, moneyUpdateBene.ToString());
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

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice Printing Successful");
            visibleInvoice(false);
            loadData();
        }
    }
}

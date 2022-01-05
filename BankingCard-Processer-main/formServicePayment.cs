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
    public partial class formServicePayment : Form
    {
        BUS_Service bus_service = new BUS_Service();
        BUS_CardInfo bus_cardInfo = new BUS_CardInfo();        
        string cardID;
        DateTime date;
        Random random = new Random();
        int balance = 0;
        int amount = 0;

        public formServicePayment(string cardID)
        {
            InitializeComponent();
            this.cardID = cardID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formServicePayment_Load(object sender, EventArgs e)
        {
            loadData();
            visibleInvoice(false);
        }

        void loadData()
        {
            dataGridView.DataSource = bus_service.loadData(this.cardID).Tables[0];
            DataGridViewRow row = dataGridView.Rows[0];
            balance = int.Parse(row.Cells["column_balance"].Value.ToString());
            string formatted = string.Format("{0:#,##0.##}", balance);
            tbxBalance.Text = formatted;
            checkCustomerID();
        }

        void checkCustomerID()
        {
            if (cboKhuVuc.Text != "")
            {
                if (bus_service.checkCustomerID(cboKhuVuc.Text, this.cardID))
                {
                    tbxCustomerID.Text = this.cardID;
                    dataGridView1.DataSource = bus_service.loadDataService(cboKhuVuc.Text, this.cardID).Tables[0];
                    DataGridViewRow row = dataGridView1.Rows[0];
                    amount = int.Parse(row.Cells["column_sotien"].Value.ToString());
                    string formatted = string.Format("{0:#,##0.##}", amount);
                    tbxAmount.Text = formatted;
                    if (row.Cells["column_trangThai"].Value.ToString() == "1")
                        tbxStatus.Text = "Paid";
                    else
                        tbxStatus.Text = "Unpaid";

                }
                else
                {
                    tbxCustomerID.Text = "";
                    tbxAmount.Text = "0.00";
                    tbxStatus.Text = "";
                }
            }
        }

        void setInvoice()
        {
            date = DateTime.Now;
            txtDate.Text = date.ToShortDateString();
            DataGridViewRow row = dataGridView.Rows[0];
            txtCardHolder.Text = row.Cells["column_holder"].Value.ToString();
            DataGridViewRow row1 = dataGridView1.Rows[0];
            lbTransaction.Text = row1.Cells["column_loai"].Value.ToString() + " Bill Payment";
            txtProvider.Text = cboKhuVuc.Text;
            txtCardID.Text = this.cardID;
            txtAmount.Text = tbxAmount.Text;
            int moneyUpdate = balance - amount;
            string formatted = string.Format("{0:#,##0.##}", moneyUpdate);
            txtBalance.Text = formatted.ToString();
        }

        void visibleInvoice(bool b)
        {
            lbProvider.Visible = b;
            lbDate.Visible = b;
            lbCardID.Visible = b;
            lbCardHolder.Visible = b;
            lbTransaction.Visible = b;
            lbAmount.Visible = b;
            lbBalance.Visible = b;
            lbVAT.Visible = b;
            lbThanks.Visible = b;
            txtProvider.Visible = b;
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
            textBox7.Visible = b;
        }

        void addInvoice()
        {
            string maGD = random.Next(99999) + "";
            string loaiGD = lbTransaction.Text;
            date = DateTime.Now;
            DTO_TransactionInfo dto_transactionInfo = new DTO_TransactionInfo(this.cardID, maGD, loaiGD, date.ToShortDateString(), "-" + tbxAmount.Text);
            bus_service.addInvoice(dto_transactionInfo);

        }

        private void btnElectricity_Click(object sender, EventArgs e)
        {
            cboKhuVuc.Items.Clear();
            string[] temp = { "Dien luc TP HCM", "Dien luc TP Ha Noi", "Dien luc mien Bac", "Dien luc mien Trung", "Dien luc mien Nam" };
            foreach (string x in temp)
                cboKhuVuc.Items.Add(x);
            cboKhuVuc.Text = cboKhuVuc.Items[0].ToString();
            checkCustomerID();
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            cboKhuVuc.Items.Clear();
            string[] temp = { "Cong ty nuoc sach Ha Noi", "Cap nuoc Cho Lon - TP.HCM", "Cap nuoc Binh Thuan", "Cap nuoc Kien Giang" };
            foreach (string x in temp)
                cboKhuVuc.Items.Add(x);
            cboKhuVuc.Text = cboKhuVuc.Items[0].ToString();
            checkCustomerID();
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            cboKhuVuc.Items.Clear();
            string[] temp = { "VNPT", "FPT Telecom", "Viettel", "CMC Telecom" };
            foreach (string x in temp)
                cboKhuVuc.Items.Add(x);
            cboKhuVuc.Text = cboKhuVuc.Items[0].ToString();
            checkCustomerID();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (bus_cardInfo.login(this.cardID, tbxConfirm.Text))
            {
                if(tbxStatus.Text == "Paid")
                {
                    MessageBox.Show("Invoice has been paid");
                    return;
                }
                if (balance > amount)
                {
                    int moneyUpdate = balance - amount;
                    bus_service.payments(cboKhuVuc.Text, this.cardID, moneyUpdate.ToString());
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

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkCustomerID();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Deposit
    {
        DAL_Deposit dal_deposit = new DAL_Deposit();

        public DataSet loadData(string cardID)
        {
            return dal_deposit.loadData(cardID);
        }

        public bool depositMoney(string cardID, string money)
        {
            return dal_deposit.deposit(cardID, money);
        }

        public bool addInvoice(DTO_TransactionInfo transactionInfo)
        {
            return dal_deposit.addInvoice(transactionInfo);
        }

    }

}

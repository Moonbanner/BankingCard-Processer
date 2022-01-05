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
    public class BUS_Withdraw
    {
        DAL_Withdraw dal_withdraw = new DAL_Withdraw();

        public DataSet loadData(string cardID)
        {
            return dal_withdraw.loadData(cardID);
        }

        public bool withdrawMoney(string cardID, string money)
        {
            return dal_withdraw.withdraw(cardID, money);
        }

        public bool addInvoice(DTO_TransactionInfo transactionInfo)
        {
            return dal_withdraw.addInvoice(transactionInfo);
        }
    }
}

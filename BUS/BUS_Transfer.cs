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
    public class BUS_Transfer
    {
        DAL_Transfer dal_transfer = new DAL_Transfer();

        public DataSet loadData(string cardID)
        {
            return dal_transfer.loadData(cardID);
        }

        public bool findCardID(string cardID)
        {
            return dal_transfer.findCardID(cardID);
        }

        public DataSet findBeneName(string cardID)
        {
            return dal_transfer.findBeneName(cardID);
        }

        public bool transfer(string cardID, string money, string beneID, string moneyBene)
        {
            return dal_transfer.transfer(cardID, money, beneID, moneyBene);
        }

        public bool addInvoice(DTO_TransactionInfo transactionInfo, DTO_TransactionInfo transactionInfoBene)
        {
            if (dal_transfer.addInvoice(transactionInfo) && dal_transfer.addInvoice(transactionInfoBene))
                return true;
            return false;
        }

    }
}

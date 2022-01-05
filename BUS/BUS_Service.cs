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
    public class BUS_Service
    {
        DAL_Service dal_service = new DAL_Service();
        public DataSet loadData(string cardID)
        {
            return dal_service.loadData(cardID);
        }

        public bool checkCustomerID(string khuVuc, string cardID)
        {
            return dal_service.checkCustomerID(khuVuc, cardID);
        }

        public DataSet loadDataService(string khuVuc, string cardID)
        {
            return dal_service.loadDataService(khuVuc, cardID);
        }

        public bool checkPayment(string khuVuc, string cardID)
        {
            return dal_service.checkPayment(khuVuc, cardID);
        }

        public bool payments(string khuVuc, string cardID, string money)
        {
            return dal_service.payments(khuVuc, cardID, money);
        }

        public bool addInvoice(DTO_TransactionInfo transactionInfo)
        {
            return dal_service.addInvoice(transactionInfo);
        }

    }
}

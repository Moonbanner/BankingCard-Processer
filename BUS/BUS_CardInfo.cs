using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_CardInfo
    {
        DAL_CardInfo dal_cardInfo = new DAL_CardInfo();

        public bool login(string cardId, string pin)
        {
            return dal_cardInfo.login(cardId, pin);
        }

        public DataSet loadDataTTGD(string cardID)
        {
            return dal_cardInfo.loadDataTTGD(cardID);
        }

        public DataSet loadDataTTKH(string cardID)
        {
            return dal_cardInfo.loadDataTTKH(cardID);
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_CardInfo
    {
        private string maCard;
        private string maKH;
        private string maPin;
        private string soDu;

        public DTO_CardInfo(string maCard, string maKH, string pin, string sodu)
        {
            this.maCard = maCard;
            this.maKH = maKH;
            this.maPin = pin;
            this.soDu = sodu;
        }

        string MaCard
        {
            set { this.maCard = value; }
            get { return this.maCard; }
        }
        string MaKH
        {
            set { this.maKH = value; }
            get { return this.maKH; }
        }
        string MaPin
        {
            set { this.maPin = value; }
            get { return this.maPin; }
        }
        string SoDu
        {
            set { this.soDu = value; }
            get { return this.soDu; }
        }

    }
}

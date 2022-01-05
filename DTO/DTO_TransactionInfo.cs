using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TransactionInfo
    {
        private string maCard;
        private string maGD;
        private string loaiGD;
        private string thoiGianGD;
        private string soTienGD;

        public DTO_TransactionInfo(string macard,string magd,string loai,string thoigian,string sotien)
        {
            this.maCard = macard;
            this.maGD = magd;
            this.loaiGD = loai;
            this.thoiGianGD = thoigian;
            this.soTienGD = sotien;
        }

        public string MaCard
        {
            set { this.maCard = value; }
            get { return this.maCard; }
        }
        public string MaGD
        {
            set { this.maGD = value; }
            get { return this.maGD; }
        }
        public string LoaiGD
        {
            set { this.loaiGD = value; }
            get { return this.loaiGD; }
        }
        public string ThoiGianGD
        {
            set { this.thoiGianGD = value; }
            get { return this.thoiGianGD; }
        }
        public string SoTienGD
        {
            set { this.soTienGD = value; }
            get { return this.soTienGD; }
        }
    }
}

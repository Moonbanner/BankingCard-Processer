using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        private string maKH;
        private string hoTenKH;
        private string gioiTinh;
        private string ngaySinh;
        private string cmnd;
        private string diaChi;
        private string soDienThoai;

        public DTO_Customer(string ma, string hoten, string gioitinh, string ngaysinh, string cmnd, string diachi,string sdt)
        {
            this.maKH = ma;
            this.hoTenKH = hoten;
            this.gioiTinh = gioitinh;
            this.ngaySinh = ngaysinh;
            this.cmnd = cmnd;
            this.diaChi = diachi;
            this.soDienThoai = sdt;
        }

        string MaKH
        {
            set { this.maKH = value; }
            get { return this.maKH; }
        }
        string HoTenKH
        {
            set { this.hoTenKH = value; }
            get { return this.hoTenKH; }
        }
        string GioiTinh
        {
            set { this.gioiTinh = value; }
            get { return this.gioiTinh; }
        }
        string NgaySinh
        {
            set { this.ngaySinh = value; }
            get { return this.ngaySinh; }
        }
        string Cmnd
        {
            set { this.cmnd = value; }
            get { return this.cmnd; }
        }
        string DiaChi
        {
            set { this.diaChi = value; }
            get { return this.diaChi; }
        }
        string SoDienThoai
        {
            set { this.soDienThoai = value; }
            get { return this.soDienThoai; }
        }


    }


}

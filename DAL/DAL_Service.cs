using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Service : DBConnect
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet data = new DataSet();
        DataSet dataService = new DataSet();

        public DataSet loadData(string cardID)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select ttc.SoDu, ttkh.HoTenKH " +
                "from ThongTinCard ttc, ThongTinKhachHang ttkh " +
                "where ttc.UserId = ttkh.UserId and ttc.CardId = @cardID";
            command.Parameters.AddWithValue("@cardID", cardID);
            adapter.SelectCommand = command;
            data.Clear();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public DataSet loadDataService(string khuVuc, string cardID)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select ttsp.SoTien, ttsp.TrangThai, ttsp.LoaiService " +
                "from ThongTinServicePayment ttsp " +
                "where ttsp.KhuVuc = @khuVuc and ttsp.CardID = @cardID";
            command.Parameters.AddWithValue("@cardID", cardID);
            command.Parameters.AddWithValue("@khuVuc", khuVuc);
            adapter.SelectCommand = command;
            dataService.Clear();
            adapter.Fill(dataService);
            connection.Close();
            return dataService;
        }

        public bool checkCustomerID(string khuVuc, string cardID)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select COUNT(*) from ThongTinServicePayment ttsp " +
                "where ttsp.KhuVuc = @khuVuc and ttsp.CardID = @cardID";
            command.Parameters.AddWithValue("@cardID", cardID);
            command.Parameters.AddWithValue("@khuVuc", khuVuc);

            if ((int)command.ExecuteScalar() == 1)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool checkPayment(string khuVuc, string cardID)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select COUNT(*) from ThongTinServicePayment ttsp " +
                "where ttsp.KhuVuc = @khuVuc and ttsp.CardID = @cardID and ttsp.TrangThai = 1";
            command.Parameters.AddWithValue("@cardID", cardID);
            command.Parameters.AddWithValue("@khuVuc", khuVuc);

            if ((int)command.ExecuteScalar() == 1)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool payments(string khuVuc, string cardID,string money)
        {
            if (updateMoney(cardID, money) && updateStatus(khuVuc, cardID))
                return true;
            return false;
        }

        public bool updateMoney(string cardID,string money)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "update ThongTinCard set SoDu = @money where CardId = @cardID";
            command.Parameters.AddWithValue("@cardID", cardID);
            command.Parameters.AddWithValue("@money", money);
            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }

        public bool updateStatus(string khuVuc,string cardID)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "update ThongTinServicePayment set TrangThai = 1 " +
                "where KhuVuc = @khuVuc and CardID = @cardID";
            command.Parameters.AddWithValue("@cardID", cardID);
            command.Parameters.AddWithValue("@khuVuc", khuVuc);
            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }

        public bool addInvoice(DTO_TransactionInfo transactionInfo)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "insert into ThongTinGiaoDich values (@cardID, @maGD, @loaiGD, @thoigianGD, @sotienGD)";
            command.Parameters.AddWithValue("@cardID", transactionInfo.MaCard);
            command.Parameters.AddWithValue("@maGD", transactionInfo.MaGD);
            command.Parameters.AddWithValue("@loaiGD", transactionInfo.LoaiGD);
            command.Parameters.AddWithValue("@thoigianGD", transactionInfo.ThoiGianGD);
            command.Parameters.AddWithValue("@sotienGD", transactionInfo.SoTienGD);

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_CardInfo : DBConnect 
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dataThongTinGD = new DataSet();
        DataSet dataThongTinKH = new DataSet();

        public bool login(string cardId, string pin)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select COUNT(*) from ThongTinCard where CardId = @cardID and MaPin = @maPin";
            command.Parameters.AddWithValue("@cardID", cardId);
            command.Parameters.AddWithValue("@maPin", pin);
            
            
            if ((int)command.ExecuteScalar() == 1)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool changePIN(string cardId, string newPIN)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "update ThongTinCard set MaPin = @newPIN where CardId = @cardID";
            command.Parameters.AddWithValue("@cardID", cardId);
            command.Parameters.AddWithValue("@newPIN", newPIN);
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

        public DataSet loadDataTTGD(string cardID)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select ttgd.MaGD, ttgd.LoaiGD, ttgd.ThoiGianGD, ttgd.SoTienGD " +
                "from ThongTinGiaoDich ttgd, ThongTinCard ttc " +
                "where ttgd.CardID = ttc.CardID and ttc.CardId = @cardID";
            command.Parameters.AddWithValue("@cardID", cardID);
            adapter.SelectCommand = command;
            dataThongTinGD.Clear();
            adapter.Fill(dataThongTinGD);
            connection.Close();
            return dataThongTinGD;
        }

        public DataSet loadDataTTKH(string cardID)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select ttc.CardId, ttkh.HoTenKH, ttc.SoDu " +
                "from ThongTinCard ttc, ThongTinKhachHang ttkh " +
                "where ttc.UserId = ttkh.UserId and ttc.CardId = @cardID";
            command.Parameters.AddWithValue("@cardID", cardID);
            adapter.SelectCommand = command;
            dataThongTinKH.Clear();
            adapter.Fill(dataThongTinKH);
            connection.Close();
            return dataThongTinKH;
        }

    }
}

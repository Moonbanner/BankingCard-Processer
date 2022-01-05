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
    public class DAL_Transfer : DBConnect
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet data = new DataSet();
        DataSet dataBene = new DataSet();

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

        public bool findCardID(string cardID)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select COUNT(*) from ThongTinCard where CardId = @cardID";
            command.Parameters.AddWithValue("@cardID", cardID);

            if ((int)command.ExecuteScalar() == 1)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public DataSet findBeneName(string cardID)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select ttkh.HoTenKH, ttc.SoDu " +
                "from ThongTinCard ttc, ThongTinKhachHang ttkh " +
                "where ttc.UserId = ttkh.UserId and ttc.CardId = @cardID";
            command.Parameters.AddWithValue("@cardID", cardID);
            adapter.SelectCommand = command;
            dataBene.Clear();
            adapter.Fill(dataBene);
            connection.Close();
            return dataBene;
        }

        public bool transfer(string cardID, string money, string beneID, string moneyBene)
        {
            if (updateMoney(cardID, money) && updateMoney(beneID, moneyBene)) 
            {
                return true;
            }
            return false;
        }

        bool updateMoney(string cardID, string money)
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

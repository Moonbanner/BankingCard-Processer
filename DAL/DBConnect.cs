using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-U8RR33L\SQLSERVER;Initial Catalog=BankingCardProcessor;Integrated Security=True");
    }
}

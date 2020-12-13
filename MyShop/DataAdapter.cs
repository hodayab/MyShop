using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop
{
    public static class DataAdapter
    {
        const string connectionString = "Data Source=198.38.83.33;Database=hodaya_shop;Integrated Security=false;User ID=hodaya_hodaya;Password=hi1234;";

        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable("Data");
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatement = query;

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(dt);
                    _con.Close();
                }
            }
            return dt;
        }

    }
}

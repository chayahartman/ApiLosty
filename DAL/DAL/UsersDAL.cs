using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UsersDAL
    {
        public static SqlConnection connection = new SqlConnection("@Data Source=den1.mssql7.gear.host;Persist Security Info=True;User ID=losty2022;password=Rm422FmrNj~_");

        public DataTable count()
        {
            connection.Open();
            string query = "select * from tblUsers";

            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace DL
{
    public class UsersDL
    {


        SqlConnection connection = new SqlConnection(@"Data Source=den1.mssql7.gear.host;Persist Security Info=True;User ID=losty2022;password=Rm422FmrNj~_");

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

        public List<String> Scalar(string sp)
        {
            //object outPut = null;
            SqlCommand com = new SqlCommand(sp, connection);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da;
            DataTable dt = new DataTable(); ;
            List<String> ls = new List<String>();
            try
            {
                connection.Open();
               da=new SqlDataAdapter(com);
               da.Fill(dt);
                for (int i = 0; i< dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ls.Add(dr[0].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ls;
        }

        public  int ExecuteNonQuery(string sp, List<SqlParameter> param)
        {
            SqlCommand com = new SqlCommand(sp, connection);
            com.CommandType = CommandType.StoredProcedure;
            int id = 0;

            foreach (SqlParameter p in param)
            {
                com.Parameters.Add(p);
            }

            try
            {
                connection.Open();
                com.ExecuteNonQuery();
                try
                {
                    int.TryParse(com.Parameters["@id"].Value.ToString(), out id);
                }
                catch { }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return id;
        }



    }
}
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
   public class GenericProc
    {
        SqlConnection connection = new SqlConnection(@"Data Source=den1.mssql7.gear.host;Persist Security Info=True;User ID=losty2022;password=Rm422FmrNj~_");

        public DataTable DataTable(string sp)
        {
           
            SqlCommand com = new SqlCommand(sp, connection);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da;
            DataTable dt = new DataTable(); 
            
            try
            {
                connection.Open();
                da = new SqlDataAdapter(com);
                da.Fill(dt);
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
          
        }
        
        public DataTable DataTableWithParams(string sp,List<SqlParameter> param)
        {

            SqlCommand com = new SqlCommand(sp, connection);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            foreach (SqlParameter p in param)
            {
                com.Parameters.Add(p);
            }
            try
            {
                connection.Open();
                da = new SqlDataAdapter(com);
                da.Fill(dt);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;

        }

        public int ExecuteNonQuery(string sp, List<SqlParameter> param)
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

        public void DML(string sp, List<SqlParameter> param)
        {

            SqlCommand com = new SqlCommand(sp, connection);
            com.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter p in param)
            {
                com.Parameters.Add(p);
            }

            try
            {
                connection.Open();
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        //    public void DML(string sp, int id)
        //    {

        //        SqlCommand com = new SqlCommand(sp, connection);
        //        com.CommandType = CommandType.StoredProcedure;

        //        SqlParameter param = new SqlParameter("@itemrId", id);
        //        param.SqlDbType = SqlDbType.Int;
        //        com.Parameters.Add(param);


        //        try
        //        {
        //            connection.Open();
        //            com.ExecuteNonQuery();
        //        }
        //        catch (SqlException ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }
        }


    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;


namespace BL
{
    public class UsersBL
    {
        public int countUsers()
        {
            UsersDAL dl = new UsersDAL();
            DataTable dt = dl.count();
            if (dt.Rows.Count > 0)
                return dt.Rows.Count;
            else
                return -1;

        }
    }
}

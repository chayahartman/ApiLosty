using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using System.Data;
using System.Data.SqlClient;



namespace BL
{
    public class UsersBL
    {
        //public int countUsers()
        //{

        //    UsersDL dl = new UsersDL();

        //    DataTable dt = dl.count();
        //    if (dt.Rows.Count > 0)
        //        return dt.Rows.Count;
        //    else
        //        return -1;

        //}

        //public DataTable UsersList()
        //{

        //    UsersDL dl = new UsersDL();

        //    DataTable dt = dl.count();
        //    return dt;

        //}


        //public List<String> countItems()
        //{

        //    UsersDL dl = new UsersDL();

        //    List<String> res = dl.Scalar("SPgetItemsList");
            
        //    return res;

        //}

        public DataTable UsersList()
        {
            GenericProc gc = new GenericProc();
            return gc.DataTable("SPgetUsersList");
        }
    }
}

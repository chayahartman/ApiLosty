using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BL
{
    public class UsersBL
    {
        public int countUsers()
        {
            UsersDL dl = new UsersDL();
            DataTable dt = dl.count();
            if (dt.Rows.Count > 0)
                return dt.Rows.Count;
            else
                return -1;

        }
    }
}

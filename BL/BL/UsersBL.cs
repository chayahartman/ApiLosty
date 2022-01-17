using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
<<<<<<< HEAD
=======
using System.Data.SqlClient;

>>>>>>> 001c2c7b27bdac0a26f29446ff1acee9f6b9789b

namespace BL
{
    public class UsersBL
    {
        public int countUsers()
        {
<<<<<<< HEAD
            UsersDL dl = new UsersDL();
=======
            UsersDAL dl = new UsersDAL();
>>>>>>> 001c2c7b27bdac0a26f29446ff1acee9f6b9789b
            DataTable dt = dl.count();
            if (dt.Rows.Count > 0)
                return dt.Rows.Count;
            else
                return -1;

        }
    }
}

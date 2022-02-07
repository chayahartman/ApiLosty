using DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class LossesBL
    {
        public DataTable LossesList()
        {

            GenericProc gc = new GenericProc();
            return gc.DataTable("SPgetAllLosses");
        }

        public DataTable GetLostDetails(List<SqlParameter> param)
        {

            GenericProc gc = new GenericProc();
            return gc.DataTableWithParams("SPlostDetails",param);
        }
    }
}

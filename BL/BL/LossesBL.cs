using DL;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}

using DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FindingsBL
    {
        public DataTable FindingsList()
        {

            GenericProc gc = new GenericProc();
            return gc.DataTable("SPgetAllFindings");
        }
    }
}

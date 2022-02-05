using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using System.Data;

namespace BL
{
    public class EmailSettingsBL
    {
        public DataTable EmailSettingsList()
        {
            GenericProc gc = new GenericProc();
            return gc.DataTable("SPgetEmailSettingsList");
        }

    }
}

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
   public class ItemsBL
    {
        public DataTable ItemsList()
        {
            GenericProc gc = new GenericProc();
            return gc.DataTable("SPgetItemsList");
        }

        public void DeleteItem(List<SqlParameter> lsParam)
        {
            GenericProc gc = new GenericProc();
            gc.DML("SPdeleteItem", lsParam);
        }
        public void AddItem(List<SqlParameter> lsParam)
        {
            GenericProc gc = new GenericProc();
            gc.DML("SPaddItem", lsParam);
        }
        //public void DeleteItem(int id)
        //{
        //    GenericProc gc = new GenericProc();
        //    gc.DML("SPdeleteItem",id);
        //}

    }
}

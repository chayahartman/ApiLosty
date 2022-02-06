using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BL;
using System.Data;
using System.Data.SqlClient;
using newAPILosty.Models;


namespace newAPILosty.Controllers
{
    [RoutePrefix("api/Items")]
    public class ItemsController : ApiController
    {
        [Route("getItemsList")]
        public IHttpActionResult getItemsList()
        {
            ItemsBL bl = new ItemsBL();
            DataTable dt = bl.ItemsList();
            DB.lsItems.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Items item = new Items(int.Parse(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString());
                DB.lsItems.Add(item);
            }


            return Ok(DB.lsItems);
        }

        [HttpDelete]
        [Route("DeleteItem/{itemId}")]
        public IHttpActionResult DeleteItem(int itemId)
        {
            DB.lsParam.Clear();
            SqlParameter param = new SqlParameter("itemId", itemId);
            DB.lsParam.Add(param);
            ItemsBL bl = new ItemsBL();
            bl.DeleteItem(DB.lsParam);
            return getItemsList();
        }

        [HttpDelete]
        [Route("mydelete/{itemId}")]
        public IHttpActionResult mydelete(int itemId)
        {
            ItemsBL bl = new ItemsBL();
            DataTable dt = bl.ItemsList();
            DB.lsItems.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Items item = new Items(int.Parse(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString());
                DB.lsItems.Add(item);
            }
            //מחיקה
            DB.lsItems.Remove(DB.lsItems.FirstOrDefault(f => f.itemId == itemId));
            return Ok(DB.lsItems);
        }
    }
}

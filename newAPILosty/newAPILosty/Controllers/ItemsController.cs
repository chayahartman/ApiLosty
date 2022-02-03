using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BL;
using System.Data;
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
    }
}
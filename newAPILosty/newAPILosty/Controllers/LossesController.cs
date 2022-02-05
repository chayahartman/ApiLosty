using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using BL;
using newAPILosty.Models;

namespace newAPILosty.Controllers
{
    [RoutePrefix("api/Losses")]
    public class LossesController : ApiController
    {
        [Route("getLossesList")]
        public IHttpActionResult getLossesList()
        {
            LossesBL bl = new LossesBL();
            DataTable dt = bl.LossesList();
            DB.lsLosses.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Losses lost=new Losses(int.Parse(dt.Rows[i][0].ToString()), int.Parse(dt.Rows[i][1].ToString()), dt.Rows[i][2].ToString(), int.Parse(dt.Rows[i][3].ToString()), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(),
                int.Parse(dt.Rows[i][6].ToString()),dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString());
                DB.lsLosses.Add(lost);
            }

            return Ok(DB.lsLosses);
        }
    }
}

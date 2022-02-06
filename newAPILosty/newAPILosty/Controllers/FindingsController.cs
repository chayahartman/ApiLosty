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
    [RoutePrefix("api/Findings")]

    public class FindingsController:ApiController
    {
        [Route("GetFindingsList")]
        public IHttpActionResult getLossesList()
        {
            FindingsBL bl = new FindingsBL();
            DataTable dt = bl.FindingsList();
            DB.lsFindings.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Findings find = new Findings(int.Parse(dt.Rows[i][0].ToString()), int.Parse(dt.Rows[i][1].ToString()), dt.Rows[i][2].ToString(), int.Parse(dt.Rows[i][3].ToString()), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(),
                int.Parse(dt.Rows[i][6].ToString()), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString());
                DB.lsFindings.Add(find);
            }

            return Ok(DB.lsFindings);
        }
    }
}
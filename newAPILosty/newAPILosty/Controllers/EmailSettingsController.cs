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
    [RoutePrefix("api/EmailSettings")]
    public class EmailSettingsController : ApiController
    {
        [Route("getEmailSettingsList")]
        public IHttpActionResult getItemsList()
        {
            EmailSettingsBL bl = new EmailSettingsBL();
            DataTable dt = bl.EmailSettingsList();
            DB.lsEmailSettings.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EmailSettings em = new EmailSettings(int.Parse(dt.Rows[i][0].ToString()), int.Parse(dt.Rows[i][1].ToString()), bool.Parse(dt.Rows[i][2].ToString()), bool.Parse(dt.Rows[i][3].ToString()),
                   bool.Parse( dt.Rows[i][4].ToString()));
                DB.lsEmailSettings.Add(em);
            }


            return Ok(DB.lsEmailSettings);
        }

    }
}
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
    [RoutePrefix("api/QeustionsFindings")]
    public class QuestionsFindingsController:ApiController
    {
        [Route("GetQuestionsFindingsList")]
        public IHttpActionResult GetQuestionsFindingsList()
        {
            QuestionsFindingsBL bl = new QuestionsFindingsBL();
            DataTable dt = bl.FindingsQuestionsList();
            DB.lsQuestionsFindings.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuestionsFindings qf = new QuestionsFindings(int.Parse(dt.Rows[i][0].ToString()), int.Parse(dt.Rows[i][1].ToString()));

                DB.lsQuestionsFindings.Add(qf);
            }

            return Ok(DB.lsQuestionsFindings);
        }
    }
}
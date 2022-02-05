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
    [RoutePrefix("api/Questions")]
    public class QuestionsController : ApiController
    {
        [Route("getQuestionsList")]
        public IHttpActionResult getQuestionsList()
        {
            QuestionsBL bl = new QuestionsBL();
            DataTable dt = bl.QuestionsList();
            DB.lsQuestions.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Questions questions = new Questions(int.Parse(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString());
                DB.lsQuestions.Add(questions);
            }


            return Ok(DB.lsQuestions);
        }
    }
}
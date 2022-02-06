using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using BL;
using DL;
using newAPILosty.Models;

namespace newAPILosty.Controllers
{
    [RoutePrefix("api/Users")]

    public class UsersController : ApiController
    {

        //[Route("getCountUsers")]
        //public IHttpActionResult getCountUsers()
        //{
        //    UsersBL bl = new UsersBL();
        //    int count = bl.countUsers();
        //    return Ok(count);
        //}

        //[Route("getCountItems")]
        //public IHttpActionResult getCountItems()
        //{
        //    UsersBL bl = new UsersBL();
        //    List<String> res = bl.countItems();

        //    return Ok(res);
        //}

        //public HttpResponseMessage GET()
        //{
        //    UsersBL bl = new UsersBL();
        //    int count = bl.countUsers();
        //    return Request.CreateResponse(HttpStatusCode.OK, count);

        //}



        [Route("GetUsersList")]
        public IHttpActionResult GetUsersList()
        {
            UsersBL bl = new UsersBL();
            DataTable dt = bl.UsersList();
            DB.lsUsers.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Users user = new Users(int.Parse(dt.Rows[i][0].ToString()), dt.Rows[i][1].ToString()
                    , dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString());//,bool.Parse(dt.Rows[i][4].ToString()));
                DB.lsUsers.Add(user);
            }
            return Ok(DB.lsUsers);
        }
    }



}
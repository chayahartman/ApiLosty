using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DL;

namespace newAPILosty.Controllers
{

    public class UsersController : ApiController
    {


        public HttpResponseMessage GET()
        {
            UsersBL bl = new UsersBL();
            int count = bl.countUsers();
            return Request.CreateResponse(HttpStatusCode.OK, count);

        }
    }
}
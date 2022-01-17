using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BL;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiLosty.Controllers
{
	public class UsersController
	{
        public class UserController : ApiController
        {

            public HttpResponseMessage GET()
            {
                UsersBL bl = new UsersBL();
                int count = bl.countUsers();
                return Request.CreateResponse(HttpStatusCode.OK, count);

            }

        }
    }
}
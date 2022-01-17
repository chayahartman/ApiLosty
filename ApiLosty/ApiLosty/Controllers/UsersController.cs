using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
<<<<<<< HEAD
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DAL;

namespace ApiLosty.Controllers
{
    public class UsersController : ApiController
    {


        public HttpResponseMessage GET()
         {
            UsersBL bl = new UsersBL();
            int count = bl.countUsers();
            return Request.CreateResponse(HttpStatusCode.OK, count);

        }
=======
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
>>>>>>> 001c2c7b27bdac0a26f29446ff1acee9f6b9789b

        }
    }
}
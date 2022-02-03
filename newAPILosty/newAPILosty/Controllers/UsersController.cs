//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Data;
//using BL;
//using DL;

//namespace newAPILosty.Controllers
//{
//    [RoutePrefix("api/Users")]

//    public class UsersController : ApiController
//    {

//        [Route("getCountUsers")]
//        public IHttpActionResult getCountUsers()
//        {
//            UsersBL bl = new UsersBL();
//            int count = bl.countUsers();
//            return Ok(count);
//        }

//        //[Route("getUsers")]
//        //public IHttpActionResult getUsers()
//        //{
//        //    UsersBL bl = new UsersBL();
//        //    int count = bl.countUsers();
//        //    return Ok(count);
//        //}


//        [Route("getCountItems")]
//        //public IHttpActionResult getCountItems()
//        //{
//        //    UsersBL bl = new UsersBL();
//        //    List<String> res = bl.countItems();

//        //    return Ok(res);
//        //}

//        //public HttpResponseMessage GET()
//        //{
//        //    UsersBL bl = new UsersBL();
//        //    int count = bl.countUsers();
//        //    return Request.CreateResponse(HttpStatusCode.OK, count);

//        //}
//    } 
//}
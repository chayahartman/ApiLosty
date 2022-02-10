using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BL;

namespace Losty2022Entities.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController:ApiController
    {
        //[EnableCors(Origins: "*", headers: "*", methods: "*")]
        [AcceptVerbs("GET", "POST", "DELETE", "PUT")]
        [HttpGet]
        [Route("GetAllUsers")]
        public IHttpActionResult GetAllUsers()
        {
            UserBL bl = new UserBL();
            return Ok(bl.GetAllUsers());
        }

    }
}
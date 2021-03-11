using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FashionPlace.Controllers
{
    [Authorize]
    public class TestIdentityController : Controller
    {
        // GET: TestIdentity
        
        public ActionResult Identity()
        {
            return Content("We are the identity folks!!!");
        }

        [AllowAnonymous]
        public ActionResult NonIdentity()
        {
            return Content("We don't bother about identity");
        }
    }
}
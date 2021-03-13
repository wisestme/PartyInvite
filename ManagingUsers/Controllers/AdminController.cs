using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagingUsers.Infrastructure;
using Microsoft.AspNet.Identity.Owin;

namespace ManagingUsers.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View(UerManager.Users);
        }

        private AppUserManager UerManager
        {
            get { return HttpContext.GetOwinContext().GetUserManager<AppUserManager>(); }
        }
    }
}
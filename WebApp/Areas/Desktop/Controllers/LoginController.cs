using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Areas.Desktop.ViewModels;

namespace WebApp.Areas.Desktop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Desktop/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            return View();
        }
    }
}
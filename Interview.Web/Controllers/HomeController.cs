using Interview.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
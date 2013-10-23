using JoelCode.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoelCode.Web.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _db;

        public HomeController(DataContext dc)
        {
            this._db = dc;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

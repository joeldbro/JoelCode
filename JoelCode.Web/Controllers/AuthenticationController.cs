using JoelCode.Web.Models;
using JoelCode.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace JoelCode.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        private DataContext _db;

        public AuthenticationController(DataContext dc)
        {
            _db = dc;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginInfo)
        {
            if (!ModelState.IsValid)
                return View();

            var user = _db.Users.SingleOrDefault(x => x.Email == loginInfo.Email);
            if (user == null || user.Password != loginInfo.Password)
            {
                ModelState.AddModelError("", "Email or password is incorrect.");
                return View();
            }

            FormsAuthentication.SetAuthCookie(user.Id.ToString(), true);

            return RedirectToAction("Index", "Home");
        }

        public string WelcomeMessage()
        {
            var currentUser = _db.Users.Find(int.Parse(User.Identity.Name));
            return string.Format("Welcome {0}!", currentUser.FirstName);
        }
    }
}

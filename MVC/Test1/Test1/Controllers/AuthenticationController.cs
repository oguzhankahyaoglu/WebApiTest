using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BusinessEntities;
using BusinessLayer;

namespace Test1.Controllers
{
    [AllowAnonymous]
    public class AuthenticationController :Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        
        [HttpPost]
        public ActionResult DoLogin(UserDetails u)
        {
            if (!ModelState.IsValid) 
                return View("Login");
            
            var bal = new EmployeeBusinessLayer();
            //New Code Start
            var status = bal.GetUserValidity(u);
            if (status == UserStatus.AuthenticatedAdmin || status == UserStatus.AuthentucatedUser)
            {
                var isAdmin = status == UserStatus.AuthenticatedAdmin;
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                Session["IsAdmin"] = isAdmin;
                return RedirectToAction("Index", "Employee");
            }
            
            ModelState.AddModelError("CredentialError", "Invalid Username or Password");
            return View("Login");
        }
    }
}
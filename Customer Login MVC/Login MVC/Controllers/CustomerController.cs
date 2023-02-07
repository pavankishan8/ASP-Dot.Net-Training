using LoginApp.DataRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LoginApp.Controllers
{
    public class CustomerController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string pwd)
        {
            var com = new UserModule();
            try
            {
                var cst = com.ValidateUser(email, pwd);
                Session["CurrentUser"] = cst;
                FormsAuthentication.SetAuthCookie(cst.CustomerEmail, false);
                FormsAuthentication.RedirectFromLoginPage(cst.CustomerEmail, false);
                return View();
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("LoginError", ex.Message);
                return View();
            }
        }
    }
}
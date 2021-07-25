using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Profolio_ASPDotNet.Models;

namespace Profolio_ASPDotNet.Controllers
{
    public class LoginController : Controller
    {
        private ProfolioDBContext _context;
        public LoginController()
        {
            _context = new ProfolioDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Login
        public ActionResult ViewLogin()
        {
            return View();
        }
        public ActionResult ViewAdminDashboard()
		{
            return View("ViewAdminDashboard", _context.Projects.ToList());
        }
        public ActionResult Submit(Account account)
		{
            var _account = account;
            if(account.email=="tester@gmail.com" &&
                account.password == "123456")
			{
                return View("ViewAdminDashboard", _context.Projects.ToList());
            }
			else
			{
                return Content("It does not match");
            }
		}
        public ActionResult NewExperienceView()
		{
            return View();
		}
        public ActionResult Update(Project project)
		{
            return View("NewExperienceView", project);
		}
    }
}
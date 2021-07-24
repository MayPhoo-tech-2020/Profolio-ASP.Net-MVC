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
        public ActionResult Submit(Account account)
		{
            var _account = account;
            var projects = _context.Projects.ToList();
            if(account.email=="phoowintzay.software@gmail.com" &&
                account.password == "ljwljejewoijiooi1o28387u")
			{
                return View("ViewAdminDashboard", projects);
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Profolio_ASPDotNet.Models;
using Profolio_ASPDotNet.Models.ProjectsModel;


namespace Profolio_ASPDotNet.Controllers
{
    public class ProjectController : Controller
    {
        private ProfolioDBContext _context;
        public ProjectController()
        {
            _context = new ProfolioDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Project
        public ActionResult ViewProgrammingLanguage()
        {       
            return View(_context.Projects);
        }

        public ActionResult ViewProject(string pLanguage)
		{
            var projects = _context.Projects.Where(x => x.PLanguage == pLanguage);
            return View(projects);
		}
        public ActionResult ViewProjectDetails(int id)
        {
            var projectDetail = _context.Projects.SingleOrDefault(x => x.Id == id);
            return View();
        }
    }
}
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
            var projects = _context.Projects.Where(x => x.PLanguage.Trim().ToLower() == pLanguage.Trim().ToLower());
            return View(projects);
		}
        public ActionResult ViewProjectDetails(int id)
        {
            var projectDetail = _context.Projects.SingleOrDefault(x => x.Id == id);
            return View(projectDetail);
        }

        public ActionResult Save(Project project)
		{
			if (project.Id == 0)
			{
                _context.Projects.Add(project);
            }
			else
			{
                var projectInDb = _context.Projects.Single(p => p.Id == project.Id);
                //Mapper.Map(project,projectInDB)//Using Auto Mapper
                projectInDb.ProjectName = project.ProjectName;
                projectInDb.ProjectLink = project.ProjectLink;
                projectInDb.ProjectDescription = project.ProjectDescription;
                projectInDb.PLanguage = project.PLanguage;
             }
            
            _context.SaveChanges();
            return RedirectToAction("ViewAdminDashboard", "Login");

        }
    }
}
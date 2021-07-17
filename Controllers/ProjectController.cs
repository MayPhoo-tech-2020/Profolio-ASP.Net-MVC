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
        // GET: Project
        public ActionResult ViewProject()
        {
            var project = new List<Project> {
                new Project {PLanguage="C#"},
                new Project {PLanguage = "Python"}
            };
            var projectViewModel = new ProjectsViewModel
            {
                Projects = project
        };
            return View(projectViewModel);
        }
    }
}
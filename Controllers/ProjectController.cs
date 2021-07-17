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
        public ActionResult ViewProgrammingLanguage()
        {
            var project = new List<Project> {
                new Project {Id=0, ProjectName="Profolio",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/Profolio-ASP.Net-MVC",
                    ProjectDescription="Hello World",PLanguage="C#"},
                new Project {Id=1, ProjectName="WebScrappingDota2Data",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/WebScrappingDota2Data",
                    ProjectDescription="Hello World",PLanguage="Python"},
                new Project {Id=2, ProjectName="Profolio",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/AirBNB-ASP.NET-MVC/tree/main/AirBnB/Views/Customer",
                    ProjectDescription="Hello World",PLanguage="C#"},
                new Project {Id=3, ProjectName="WebScrappingDota2Data",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/ETLDevelopment-WorldBankData",
                    ProjectDescription="Hello World",PLanguage="Python"}
            };
            var projectViewModel = new ProjectsViewModel
            {
                Projects = project
            };
            return View(projectViewModel);
        }

        public ActionResult ViewProject(string pLanguage)
		{
            var project = new List<Project> {
                new Project {Id=0, ProjectName="Profolio",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/Profolio-ASP.Net-MVC",
                    ProjectDescription="Hello World",PLanguage="C#"},
                new Project {Id=1, ProjectName="WebScrappingDota2Data",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/WebScrappingDota2Data",
                    ProjectDescription="Hello World",PLanguage="Python"},
                new Project {Id=2, ProjectName="AirBNB-ASP.NET",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/AirBNB-ASP.NET-MVC/tree/main/AirBnB/Views/Customer",
                    ProjectDescription="Hello World",PLanguage="C#"},
                new Project {Id=3, ProjectName="ETLDevelopment-WorldBankData",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/ETLDevelopment-WorldBankData",
                    ProjectDescription="Hello World",PLanguage="Python"}
            };
            
            var projectViewModel = new ProjectsViewModel
            {
                Projects = project.FindAll(x => x.PLanguage == pLanguage)
            };
            Console.WriteLine(projectViewModel);
            return View(projectViewModel);
		}
        public ActionResult ViewProjectDetails(int id)
        {
            var project = new List<Project> {
                new Project {Id=0, ProjectName="Profolio",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/Profolio-ASP.Net-MVC",
                    ProjectDescription="Hello World",PLanguage="C#"},
                new Project {Id=1, ProjectName="WebScrappingDota2Data",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/WebScrappingDota2Data",
                    ProjectDescription="Hello World",PLanguage="Python"},
                new Project {Id=2, ProjectName="Profolio",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/AirBNB-ASP.NET-MVC/tree/main/AirBnB/Views/Customer",
                    ProjectDescription="Hello World",PLanguage="C#"},
                new Project {Id=3, ProjectName="WebScrappingDota2Data",
                    ProjectLink="https://github.com/MayPhoo-tech-2020/ETLDevelopment-WorldBankData",
                    ProjectDescription="Hello World",PLanguage="Python"}
            };
            var projectDetail = project.Find(x => x.Id == id);
            return View(projectDetail);
        }
    }
}
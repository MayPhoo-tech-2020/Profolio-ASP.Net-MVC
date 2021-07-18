using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Profolio_ASPDotNet.Models;
namespace Profolio_ASPDotNet.Controllers
{
	public class ProfolioDBContext:DbContext
	{
		public DbSet<Project> Projects { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		
	}
}
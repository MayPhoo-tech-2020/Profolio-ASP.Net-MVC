using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profolio_ASPDotNet.Models
{
	public class Project
	{
		public int Id { get; set; }
		public string ProjectName { get; set; }
		public string ProjectLink { get; set; }
		public string ProjectDescription { get; set; }
		public string PLanguage { get; set; }
	}
}
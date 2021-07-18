using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profolio_ASPDotNet.Models
{
	public class Experience
	{
		public int Id { get; set; }
		public string CompanyName { get; set; }
		public string Position { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
	}
}
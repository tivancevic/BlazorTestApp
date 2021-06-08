using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_MySQL_testing.Models
{
	public class PersonModel
	{
		//napisati "prop" i dva puta kliknut TAB
		public int id { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string email { get; set; }
	}
}

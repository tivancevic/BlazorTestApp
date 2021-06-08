using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_MySQL_testing.Models
{
	public class PhotoModel
	{
		public int id { get; set; }
		public string url { get; set; }
		public int person_id { get; set; }
	}
}

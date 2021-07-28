using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApi.Domain
{
	public class Address
	{
		public string type { get; set; }
		public string addressLocality { get; set; }
		public string addressRegion { get; set; }
		public string postalCode { get; set; }
		public string streetAddress { get; set; }
	}
}
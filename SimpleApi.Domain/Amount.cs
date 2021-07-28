using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApi.Domain
{
	public class Amount
	{
		public string type { get; set; }
		public decimal amount { get; set; }
		public string currency { get; set; }
	}
}

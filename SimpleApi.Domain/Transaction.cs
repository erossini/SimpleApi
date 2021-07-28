using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApi.Domain
{
	public class Transaction
	{
		public string id { get; set; }
		public string customerId { get; set; }
		public string type { get; set; }
		public string name { get; set; }
		public Amount amount { get; set; }
		public string beneficiaryBank { get; set; }
	}
}
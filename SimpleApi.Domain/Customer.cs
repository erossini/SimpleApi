using System;

namespace SimpleApi.Domain
{
	public class Customer
	{
		public string id { get; set; }
		public Address address { get; set; }
		public string email { get; set; }
		public string jobTitle { get; set; }
		public string name { get; set; }
		public string telephone { get; set; }
		public string url { get; set; }
	}
}

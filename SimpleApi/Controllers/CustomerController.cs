using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using SimpleApi.Domain;
using SimpleApi.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApi.Controllers
{
	public class CustomerController : BaseController<Customer>
	{
		public CustomerController(ICustomerRepository db,
			IHttpContextAccessor httpContextAccessor,
			ILogger<CustomerController> log)
			: base(db, httpContextAccessor, log)
		{
		}
	}
}

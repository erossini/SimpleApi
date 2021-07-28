using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleApi.Domain;
using SimpleApi.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApi.Controllers
{
	public class TransactionController : BaseController<Transaction>
	{
		public TransactionController(ITransactionRepository db,
			IHttpContextAccessor httpContextAccessor,
			ILogger<TransactionController> log)
			: base(db, httpContextAccessor, log)
		{
		}
	}
}
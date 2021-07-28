using SimpleApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApi.Persistence.Interfaces
{
	public interface ITransactionRepository : IAsyncRepository<Transaction>
	{
	}
}

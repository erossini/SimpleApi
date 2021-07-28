using SimpleApi.Domain;
using SimpleApi.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApi.Persistence
{
	public class TransactionRepository : ITransactionRepository
	{
		public Task<Transaction> AddAsync(Transaction entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(long id)
		{
			throw new NotImplementedException();
		}

		public Task<Transaction> GetByIdAsync(long id)
		{
			throw new NotImplementedException();
		}

		public IQueryable<Transaction> ListAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(Transaction entity)
		{
			throw new NotImplementedException();
		}
	}
}

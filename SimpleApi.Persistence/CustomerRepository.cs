using SimpleApi.Domain;
using SimpleApi.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApi.Persistence
{
	public class CustomerRepository : ICustomerRepository
	{
		public Task<Customer> AddAsync(Customer entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(string id)
		{
			throw new NotImplementedException();
		}

		public Task<Customer> GetByIdAsync(string id)
		{
			throw new NotImplementedException();
		}

		public IQueryable<Customer> ListAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(Customer entity)
		{
			throw new NotImplementedException();
		}
	}
}

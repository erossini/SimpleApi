using SimpleApi.Domain;
using System;

namespace SimpleApi.Persistence.Interfaces
{
	public interface ICustomerRepository : IAsyncRepository<Customer>
	{
	}
}
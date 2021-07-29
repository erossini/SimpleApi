using Moq;
using SimpleApi.Controllers;
using SimpleApi.Domain;
using SimpleApi.Persistence.Interfaces;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SimpleApi.Tests
{
	public class BaseControllerTest
	{
		[Fact]
		public async Task BasicTestOnTheController()
		{
			var mockRepo = new Mock<ICustomerRepository>();
			mockRepo.Setup(repo => repo.AddAsync(new Customer()));

			var controller = new BaseController<Customer>(mockRepo.Object, null, null);

			await controller.GetValue("1");
		}
	}
}

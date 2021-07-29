using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SimpleApi.Domain;

namespace SimpleAzureFunction
{
    public static class createCustomer
    {
        [FunctionName(nameof(createCustomer))]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "customers")] HttpRequest req,
            [CosmosDB("Accounts", "Customers", CreateIfNotExists = true, 
                ConnectionStringSetting = "CosmosDbConnectionString")]IAsyncCollector<dynamic> cosmosDb,
            ILogger log)
        {
            log.LogInformation("createCustomer HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            Customer data = JsonConvert.DeserializeObject<Customer>(requestBody);

            if (data != null && !string.IsNullOrEmpty(data.id))
			{
                log.LogInformation("The request is valid");

                await cosmosDb.AddAsync(data);
                
                log.LogInformation("New Customer created");
                return new OkObjectResult("New Customer created");
            }
            else
			{
                log.LogError("The request is not valid");
                return new BadRequestObjectResult("The customer must be passed and the id filled");
			}
        }
    }
}

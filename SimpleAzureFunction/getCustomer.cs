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
using System.Collections.Generic;

namespace SimpleAzureFunction
{
    public static class getCustomer
    {
        [FunctionName(nameof(getCustomer))]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "customers/{id}")] HttpRequest req,
            string id,
            [CosmosDB("Accounts", "Customers", CreateIfNotExists = true,
                ConnectionStringSetting = "CosmosDbConnectionString",
                SqlQuery = "SELECT * FROM c WHERE c.id = {id} ORDER BY c._ts DESC")]IEnumerable<Customer> document,
            ILogger log)
        {
            log.LogInformation("getCustomer HTTP trigger function processed a request.");

            if (document == null)
            {
                log.LogInformation($"Customer {id} not found");
                return new NotFoundResult();
            }

            log.LogInformation($"Customer {id} found");
            return new OkObjectResult(document);
        }
    }
}

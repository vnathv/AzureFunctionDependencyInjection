using Employee.Provider.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;

namespace AzureFunctionDependencyInjection
{
    public class EmployeeController
    {
        private readonly IEmployeeProvider employeeProvider;

        public EmployeeController(IEmployeeProvider employeeProvider)
        {
            this.employeeProvider = employeeProvider;
        }

        [FunctionName("GetEmployees")]
        public IActionResult GetEmployees(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger logger)
        {
            try
            {
                return new OkObjectResult(employeeProvider.GetEmployees());
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                return new BadRequestObjectResult("Something wrong happened");
            }
        }
    }
}
using Employee.Provider;
using Employee.Provider.Abstractions;
using Employee.Repository;
using Employee.Repository.Abstractions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;


[assembly: FunctionsStartup(typeof(Employee.IoC.Startup))]
namespace Employee.IoC
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        { 
            builder.Services.AddTransient<IEmployeeProvider, EmployeeProvider>();
            builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
        }
    }
}

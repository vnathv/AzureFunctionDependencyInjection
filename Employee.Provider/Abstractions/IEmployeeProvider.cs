using System.Collections.Generic;

namespace Employee.Provider.Abstractions
{
    public interface IEmployeeProvider
    {
        List<Model.Employee> GetEmployees();
    }
}
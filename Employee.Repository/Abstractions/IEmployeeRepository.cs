using System;
using System.Collections.Generic;
using System.Text;
using Employee.Model;

namespace Employee.Repository.Abstractions
{
    public interface IEmployeeRepository
    {
        List<Model.Employee> GetEmployees();
    }
}

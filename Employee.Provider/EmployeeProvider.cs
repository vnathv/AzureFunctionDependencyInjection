using Employee.Provider.Abstractions;
using Employee.Repository.Abstractions;
using System;
using System.Collections.Generic;

namespace Employee.Provider
{
    public class EmployeeProvider : IEmployeeProvider
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeProvider(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public List<Model.Employee> GetEmployees()
        {
            return employeeRepository.GetEmployees();
        }
    }
}
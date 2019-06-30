using Employee.Repository.Abstractions;
using System.Collections.Generic;

namespace Employee.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Model.Employee> GetEmployees()
        {
            //This is just test data. In live code it return from data store

            return new List<Model.Employee>
            {
                new Model.Employee
                {
                    EmployeeId  = 1,
                    Age = 24,
                    FirstName = "Sachin",
                    LastName = "Tendulkar",
                    JobTitle = "Senior Developer",
                    Sex = 'M'
                },

                new Model.Employee
                {
                    EmployeeId  = 2,
                    Age = 30,
                    FirstName = "John",
                    LastName = "Doe",
                    JobTitle = "Senior Director",
                    Sex = 'M'
                }
            };
        }
    }
}
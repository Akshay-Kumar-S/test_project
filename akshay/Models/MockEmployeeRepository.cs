using System.Linq;
using System.Collections.Generic;

namespace akshay.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Akshay", Email = "akshay@example.com", Dept= "IT"},
                new Employee() { Id = 2, Name = "Cristina", Email = "cristina@example.com", Dept= "HR"},
                new Employee() { Id = 3, Name = "Lijo", Email = "lijo@example.com", Dept= "Devops"},
                new Employee() { Id = 4, Name = "Naveen", Email = "naveen@example.com", Dept= "IT"}
            };
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}

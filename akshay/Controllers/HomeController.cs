using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using akshay.Models;
using Microsoft.AspNetCore.Mvc;

namespace akshay.Controllers
{
    public class HomeController
    {
        private readonly IEmployeeRepository _repository;

        public HomeController()
        {
            _repository = new MockEmployeeRepository();
        }

        public String Index()
        {
            return _repository.GetEmployee(1).Name;
        }

        public String Details()
        {
            Employee employee = _repository.GetEmployee(1);
            return employee.Dept;
        }
    }
}

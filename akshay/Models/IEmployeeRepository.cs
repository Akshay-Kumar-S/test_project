using System;
namespace akshay.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
    }
}

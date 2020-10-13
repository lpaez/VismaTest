using System.Collections.Generic;
using System.Threading.Tasks;
using VismaTest.Models;

namespace VismaTest.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task<bool> AddEmployee(Employee employee);
    }
}

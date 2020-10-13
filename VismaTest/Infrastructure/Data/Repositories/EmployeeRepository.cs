using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VismaTest.Infrastructure.Factory;
using VismaTest.Interfaces;
using VismaTest.Models;

namespace VismaTest.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;

        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public async Task<bool> AddEmployee(Employee employee)
        {
            try
            {
                await _employeeDbContext.Employees.AddAsync(employee);
                await _employeeDbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _employeeDbContext.Employees.ToListAsync().ConfigureAwait(false);
        }
    }
}

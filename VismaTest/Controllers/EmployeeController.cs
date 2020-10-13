using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using VismaTest.Interfaces;
using VismaTest.Models;

namespace VismaTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("employees")]
        [ProducesResponseType(typeof(List<Employee>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> GetEmployeeList()
        {
            var result = await _employeeService.GetEmployees();

            if (result == null || result.Count == 0)
                return NoContent();

            return Ok(result);
        }

        [HttpPost]
        [Route("add-employee")]
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var result = await _employeeService.AddEmployee(employee);

            if (!result)
                return BadRequest("There was an error adding an employee.");

            return Ok("Employee added succesfully!!");
        }
    }
}

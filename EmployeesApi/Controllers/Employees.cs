using EmployeesApi.Data;
using EmployeesApi.Models.Employees;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApi.Controllers
{
    public class Employees : ControllerBase
    {
        private readonly EmployeesDataContext _context;

        public Employees(EmployeesDataContext context)
        {
            _context = context;
        }

        [HttpGet("employees")]
        public async  Task<ActionResult> GetAllEmployees()
        {
            var employees = await _context.Employees
                .Where(e => e.IsActive)
                .Select(e => new GetEmployeeResponseItem
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    Department = e.Department,
                    LastName = e.LastName
                })
                .ToListAsync();

            var response = new GetEmployeeResponse
            {
                Data = employees
            };

            return Ok(response);
        }
    }
}

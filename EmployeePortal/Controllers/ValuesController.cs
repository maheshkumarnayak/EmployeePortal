using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeePortal.Data;
using EmployeePortal.Models;

namespace EmployeePortal.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly EmpPortalDbContext _context;
        public ValuesController(EmpPortalDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            List<Employee> employees;
            EmployeeService empService = new EmployeeService(_context);
            empService.Add(new Employee() { Id = 1, Address = "Bangalore", Name = "Mahesh", PhoneNumber = "8951287796" });

            employees = empService.GetAll();
            return employees;
        }



        ~ValuesController()
        {
            _context.Dispose();
        }
}
}
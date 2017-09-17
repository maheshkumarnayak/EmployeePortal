using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeePortal.Data;
using EmployeePortal.Models;
using Microsoft.Extensions.Logging;

namespace EmployeePortal.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly EmpPortalDbContext _context;
        private readonly ILogger<ValuesController> _logger;
        public ValuesController(EmpPortalDbContext context, ILogger<ValuesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            _logger.LogDebug("test log");
            EmployeeService empService = new EmployeeService(_context);
           // empService.Add(new Employee() { Id = 1, Address = "Bangalore", Name = "Mahesh", PhoneNumber = "8951287796" });
            return empService.GetAll();
        }



        ~ValuesController()
        {
            _logger.LogDebug("destructor called");
            _context.Dispose();
        }
}
}
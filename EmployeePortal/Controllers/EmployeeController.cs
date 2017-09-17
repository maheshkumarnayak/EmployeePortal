using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeePortal.Data;
using EmployeePortal.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmpPortalDbContext _context;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(EmpPortalDbContext context, ILogger<EmployeeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            _logger.LogDebug("Employee GetAll");
            return _context.Employees;
        }

        [HttpGet]
        public Employee Get(int Id)
        {
            _logger.LogDebug("Employee Get");
            return _context.Employees.FirstOrDefault(x => x.Id == Id);
        }

        public Employee Create (Employee request)
        {
            _logger.LogInformation("Employee Create");
            _context.Employees.Add(request);
            _context.SaveChanges();
            return request;
        }

        [HttpPut]
        public Employee Update(Employee request)
        {
            _logger.LogInformation("Employee Update");
            _context.Entry(request).State = EntityState.Modified;
            _context.SaveChanges();
            return request;
        }


        [HttpDelete]
        public bool Delete(int Id)
        {
            _logger.LogWarning("Employee Delete");
            var emp = _context.Employees.SingleOrDefault(x => x.Id == Id);
            _context.Employees.Remove(emp);
            return true;
        }



        ~EmployeeController()
        {
            _logger.LogDebug("destructor called");
            _context.Dispose();
        }
}
}
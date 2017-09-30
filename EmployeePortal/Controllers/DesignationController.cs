using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeePortal.Data;
using Microsoft.Extensions.Logging;
using EmployeePortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Controllers
{
    [Produces("application/json")]
    [Route("api/Designation")]
    public class DesignationController : Controller
    {
        private readonly EmpPortalDbContext _context;
        private readonly ILogger<EmployeeController> _logger;

        public DesignationController(EmpPortalDbContext context, ILogger<EmployeeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Designation> Get()
        {
            _logger.LogDebug("Designation GetAll");
            return _context.Designations;
        }

        [HttpGet("{id}")]
        public Designation Get(int id)
        {
            _logger.LogDebug("Designation Get");
            return _context.Designations.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public Designation Create([FromBody]Designation request)
        {
            _logger.LogInformation("Designation Create");
            _context.Designations.Add(request);
            _context.SaveChanges();
            return request;
        }

        [HttpPut]
        public Designation Update([FromBody]Designation request)
        {
            _logger.LogInformation("Designation Update");
            _context.Entry(request).State = EntityState.Modified;
            _context.SaveChanges();
            return request;
        }


        [HttpDelete("{id}")]
        public Designation Delete(int id)
        {
            _logger.LogWarning("Designation Delete");
            var des = _context.Designations.SingleOrDefault(x => x.Id == id);
            _context.Designations.Remove(des);
            return des;
        }


        ~DesignationController()
        {
            _logger.LogDebug("destructor called");
            _context.Dispose();
        }
    }
}
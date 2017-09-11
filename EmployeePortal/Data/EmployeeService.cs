using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePortal.Data
{
    public class EmployeeService
    {
        private EmpPortalDbContext _context { get; set; }
        public EmployeeService(EmpPortalDbContext context)
        {
            _context = context;
        }
        public void Add(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
        }
        public Employee Get(int Id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == Id);
        }
        public List<Employee> GetAll()
        {
            return _context.Employees.ToList<Employee>();
        }
    }
}

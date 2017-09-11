using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePortal.Data
{
    public class EmpPortalDbContext : DbContext
    {
        public EmpPortalDbContext(DbContextOptions<EmpPortalDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

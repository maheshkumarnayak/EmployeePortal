using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePortal.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EmpPortalDbContext context)
        {

            if (context.Designations.Any())
            {
                return;   // DB has been seeded
            }
            var designations = new Designation[]
            {
                new Designation() { Name = "Intern", MinBand = "0"},
                new Designation() { Name = "Programmer", MinBand = "2"},
                new Designation() { Name = "Software Engineer", MinBand = "2"},
                new Designation() { Name = "Sr. Software Engineer", MinBand = "4"},
                new Designation() { Name = "Team Leader", MinBand = "6"}
            };
            foreach (var des in designations)
            {
                context.Designations.Add(des);
            }
            context.SaveChanges();



            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }
            var employees = new Employee[]
            {
                new Employee() { Address = "Bangalore", Name = "Mahesh", PhoneNumber = "8951287796", DesignationId=2 },
                new Employee() { Address = "Bangalore", Name = "Umesh", PhoneNumber = "9938531892", DesignationId=2 },
                new Employee() { Address = "Bangalore", Name = "GhanaShyam", PhoneNumber = "9937010622", DesignationId=2 },
                new Employee() { Address = "Bangalore", Name = "Basant", PhoneNumber = "993701112", DesignationId=2 }
            };
            foreach (var emp in employees)
            {
                context.Employees.Add(emp);
            }
            context.SaveChanges();

        }
    }
}

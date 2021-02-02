using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session2Pro
{
     public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EmployeePro2;Trusted_Connection=True;");
        }
        public DbSet <Employee>Employees { get; set; }

    }
}

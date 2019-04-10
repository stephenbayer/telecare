﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeValidation.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() { }
        public EmployeeDbContext (DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees {get; set;}

    }
}

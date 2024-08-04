using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2.Data
{
    public class Assignment2Context : DbContext
    {
        public Assignment2Context (DbContextOptions<Assignment2Context> options)
            : base(options)
        {
        }

        public DbSet<Assignment2.Models.Department> Department { get; set; } = default!;

        public DbSet<Assignment2.Models.Employee>? Employee { get; set; }
    }
}

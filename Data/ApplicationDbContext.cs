using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebDb1.Models;

namespace WebDb1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebDb1.Models.Employee> Employee { get; set; }
        public DbSet<WebDb1.Models.Company> Company { get; set; }
        public DbSet<WebDb1.Models.Department> Department { get; set; }
        public DbSet<WebDb1.Models.History> History { get; set; }
        public DbSet<WebDb1.Models.JobDetails> JobDetails { get; set; }
        public DbSet<WebDb1.Models.Payment> Payment { get; set; }
        public DbSet<WebDb1.Models.Person> Person { get; set; }
    }
}

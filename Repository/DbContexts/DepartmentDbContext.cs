using HoneyPurchasingDepartments.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DbContexts
{
    public class DepartmentDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Buyer> Buyers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=HoneyPurchasingDepartmentsDB;Trusted_Connection=True;");
        }
        public DepartmentDbContext(DbContextOptions<DepartmentDbContext> options):base(options)
        {

        }

        public DepartmentDbContext()
        {
        }
    }
}

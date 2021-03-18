using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MVC5Rev.Models
{
    public class CompanyDbContext:DbContext
    {
        public CompanyDbContext() : base("CodeFirstString")
        {
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
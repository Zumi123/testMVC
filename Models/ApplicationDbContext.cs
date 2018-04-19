using System;
using Microsoft.EntityFrameworkCore;

namespace testMVC.Models{
    public class ApplicationDbContext : DbContext
    {
       
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
        }

    }
}

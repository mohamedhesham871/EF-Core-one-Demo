using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EF_Core_one__Demo.Data
{
    internal class CompanyDBContext:Microsoft.EntityFrameworkCore.DbContext //Base class for all context [you can have multi context ]
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Company; Integrated Security =True");
        }
        public Microsoft.EntityFrameworkCore.DbSet<Employee> MyDbSet { get; set; }

    }

}

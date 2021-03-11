using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
  public  class NorthwindContext:DbContext
  {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Newdb;Trusted_Connection=True");
     
        }

        public DbSet<Car> Cars { get; set; } //Veritabanındaki tablolarun karşılığı

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Rentals> Rentals { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<CarImage> CarImages { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<_User> _Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationsClaim { get; set; }




    }
}

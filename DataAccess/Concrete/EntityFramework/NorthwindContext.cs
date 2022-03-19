using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // Context : Db tabloları ile proje classlarını(nesnelerinip,c,c) birbirine bağlamak.
    //DbContext Ef'de base geliyor.
   public class NorthwindContext:DbContext
    {
        //override on..configuring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //projeyi bağladığımız yeri belirtmek için
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; } //hangi class hangi tabloya bağlanacak
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
    
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoWithOneProject
{
    class FruitContext : DbContext
    {
        public DbSet<Fruit>Fruits { get; set; }

        //Går in här vid tex EnsureCreated(men inte när contect skapas)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= (localdb)\\mssqllocaldb; Database=DemoWithOneProject;");
            }
        }
    }
}

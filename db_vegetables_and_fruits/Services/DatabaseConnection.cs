using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace db_vegetables_and_fruits.Services
{
    internal class DatabaseConnection
    {
        public DbSet<VegFruit> VegFruits => Set<VegFruit>();
        public DatabaseConnection() => this.Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=production.db");
        }
    }
}

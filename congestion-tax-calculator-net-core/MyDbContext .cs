using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;



namespace congestion_tax_calculator
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DataSource=MyDataBase.db;");
        }       

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Toll> Tolls { get; set; }
        
    
    }
}

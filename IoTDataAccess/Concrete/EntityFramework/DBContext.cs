using IoTEntities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IoTDataAccess.Concrete.EntityFramework
{
    public class DBContext:DbContext
    {
        public DBContext()
        {
            this.Database.EnsureCreated();
        }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        DbSet<Device> Devices { get; set; }
        DbSet<Person> Persons { get; set; }
        DbSet<Tag> Tags { get; set; }
        DbSet<Vehicle> Vehicles { get; set; }
        DbSet<DailyLog> DailyLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) =>
         dbContextOptionsBuilder.UseSqlite("FileName=./IoTTracking.db");
    }
}

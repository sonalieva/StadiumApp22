using Microsoft.EntityFrameworkCore;
using StadiumApp2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StadiumApp2.Data.DAL
{
    internal class StadiumApp2DbContext:DbContext
    {
        public DbSet<Stadions> Stadion { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WINDOWS-CP40MBP\SQLEXPRESS01;Database=StadionApp2;Trusted_Connection=TRUE");
        }
    }
}

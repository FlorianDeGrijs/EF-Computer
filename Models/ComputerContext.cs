using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerDatabase.Models
{
    /// <summary>
    /// Context class used to connect to the appointed database
    /// </summary>
    public class ComputerContext : DbContext
    {

        public DbSet<Computer> Computers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Computer1;Trusted_Connection=True");
        }
    }
}

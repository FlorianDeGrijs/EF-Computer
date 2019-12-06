using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerDatabase.Models
{
    public class DataSeeder
    {
        /// <summary>
        /// Class to add testdata to the the database if it does not contain any
        /// </summary>
        /// <param name="context"></param>
        public static void Seed(ComputerContext context)
        {
            if (context.Computers.Any())
            {
                return;
            }

            context.Computers.AddRange
                (
                new Computer {Name = "Richard", Price = 999.99, HasCooling = false, WarrentyYears = 3, DatePurchased = DateTime.Parse("2018-06-06") },
                new Computer { Name = "Kim", Price = 5729.99, HasCooling = false, WarrentyYears = 4, DatePurchased = DateTime.Parse("2018-05-06") },
                new Computer { Name = "Joe", Price = 299.69, HasCooling = true, WarrentyYears = 4, DatePurchased = DateTime.Parse("2018-04-06") },
                new Computer { Name = "Flo", Price = 1337.69, HasCooling = false, WarrentyYears = 4, DatePurchased = DateTime.Parse("2018-06-11") },
                new Computer { Name = "Zenci", Price = 420.42, HasCooling = true, WarrentyYears = 3, DatePurchased = DateTime.Parse("2018-08-06") },
                new Computer { Name = "Ruru", Price = 6969.69, HasCooling = false, WarrentyYears = 3, DatePurchased = DateTime.Parse("2018-09-06") },
                new Computer { Name = "Ro", Price = 13.37, HasCooling = true, WarrentyYears = 5, DatePurchased = DateTime.Parse("2018-09-01") },
                new Computer { Name = "James", Price = 12999.99, HasCooling = true, WarrentyYears = 1, DatePurchased = DateTime.Parse("2018-07-07") },
                new Computer { Name = "Ab", Price = 1.99, HasCooling = true, WarrentyYears = 2, DatePurchased = DateTime.Parse("2018-05-05") }
                );

            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerDatabase.Models
{
    /// <summary>
    /// Handles all the incoming actions from the main method
    /// </summary>
    class DatabaseHandler
    {
        private List<Computer> Computers { get; set; }
        private int Counter { get; set; }

        public DatabaseHandler() 
        {
            Computers = ItemList.Create();
            Counter = 0;
        }

        /// <summary>
        /// Adds 3 new items to the database
        /// </summary>
        public void Add()
        {
            if (Counter == Computers.Count)
            {
                Console.WriteLine("No more items to add!");
                return;
            }
            using (var context = new ComputerContext())
            {
                for (int i = 0; i < 3; i++)
                {
                    context.Computers.Add(Computers[Counter]);
                    Counter++;
                }
                Console.WriteLine("Succesfully added 3 new items");
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Prints out all rows from the created database
        /// </summary>
        public void Show()
        {
            if (this.Counter <= 0)
            {
                Console.WriteLine("No data available");
                return;
            }
            using (var context = new ComputerContext())
            {
                foreach (Computer c in context.Computers)
                {
                    Console.WriteLine(($"Name: {c.Name} | Price: {c.Price} | Purchased: {c.DatePurchased} | Warrenty: {c.WarrentyYears} years"));
                }
            }
        }

        /// <summary>
        /// Removes all items in Database
        /// </summary>
        public void RemoveAll()
        {
            using (var context = new ComputerContext())
            {
                foreach (Computer c in context.Computers)
                {
                    context.Remove(c);
                }
                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using ComputerDatabase.Models;

namespace ComputerDatabase
{
    /// <summary>
    /// First I remove all items from the database, so there will not be any duplicates
    /// Then, according to the answer given by the user, an action will be performed
    /// Either
    /// Show the Database
    /// Add 3 New items
    /// Or stop the program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseHandler handler = new DatabaseHandler();
            string answer = "";

            using (var context = new ComputerContext())
            {
                {
                    if (context.Computers.Any())
                    {
                        handler.RemoveAll();
                    }
                }
            }

            while (answer != "stop")
            {
                answer = "";
                answer = RetrieveAnswer();
                answer = answer.ToLower();
                    if (answer == "stop")
                    {
                        break;
                    }
                    
                    switch(answer)
                    {
                        case "add":
                            handler.Add();
                            break;
                        case "show":
                            handler.Show();
                            break;
                    }

            }
        }

        /// <summary>
        /// Checks if answer given is valid
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        private static bool isValidAnswer(string answer)
        {
            if (answer == null)
            {
                return false;
            }
            answer = answer.ToLower();
            if (answer == "add" || answer == "show" || answer == "stop")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// returns a valid given answer
        /// </summary>
        /// <returns></returns>
        private static string RetrieveAnswer()
        {
            string answer = "";
            while (!isValidAnswer(answer))
            {
                Console.WriteLine("What would you like me to do? (add/show/stop)");
                answer = Console.ReadLine();
                if (!isValidAnswer(answer))
                {
                    Console.WriteLine($"{answer} is not a valid option");
                }
            }
            return answer;
        }
    }
}

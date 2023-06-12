using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>() { "Grand Theft Auto 5", "Call of Duty", "Fortnite", "Minecraft" };
            var orderedGames = games.OrderByDescending(n => n.Length);

            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }

            
        }
    }
}


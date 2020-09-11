using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program

    {
        static void Main(string[] args)
        {

      
            List<string> videoGames = new List<string>
            { "AngryBirds", "Fortnite", "Pokemon", "Mario" };

            List<int> videogameslength = new List<int>
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            

            var length =
                videoGames.Select(videogames => videogames.Length);
            
            
            foreach (var games in length)

            {
                Console.WriteLine(games);
            }























        }
    }
}

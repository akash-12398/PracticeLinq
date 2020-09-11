using System;
using System.Collections.Generic;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {


              List<string> videoGames = new List<string>

              {"AngryBirds", "Fortnite", "Pokemon", "Mario" };

            Orderby<string> LongVideoGames =
                 videoGames.Where(game => game.Lenth.Contains("5"));

            foreach (var i in videoGames)
            {
                Console.WriteLine(i);
            }























        }
    }
}

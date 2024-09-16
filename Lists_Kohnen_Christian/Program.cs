using System;
using System.Collections.Generic;

namespace Lists_Kohnen_Christian
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>                               //Creates the string list of games
            {
                "CS;GO",
                "Halo 3",
                "Borderlands 3",
                "Fifa 22",
                "Minecraft"
            };

            string[] otherGames = new string[]                                  //creates an array string of otherGames
            {
            "Tiny Tina's Wonderlands",
            "Farcry 3"
            };

            foreach(string game in games)                                       //for each game in the game list, it prints it
            {
                Console.WriteLine(game);
            }

            Console.WriteLine($"\nGames in list: {games.Count}");               //it counts the number of games in the list and prints the result

            games.AddRange(otherGames);                                         //adds a range from othergames to games

            Console.WriteLine($"\nGames in list: {games.Count}");               //it counts the number of games in the list and prints the result

            if (games.Contains("Halo"))                                         //if there is a game that starts with Halo, it prints out a meme
            {
                Console.WriteLine("\nTHEY PUT THAH MASTA CHEEF IN DA SODA!!!");
            }
            else                                                                //otherwise, it adds halo to the list
            {
                games.Add("Halo");
            }

            int myInt = 6;                                                      //creates an Int and gives it the value 6

            if (myInt < games.Count)                                            //if the intiger is less than the number of games in the list, it removes the game that went over
            {
                games.RemoveAt(myInt);
            }
            else                                                                //otherwise it prints game not found
            {
                Console.WriteLine("\nGame not Found!");
            }

            Console.WriteLine("\nAll games in the list:");                      //title for the list
            foreach (string game in games)                                      //for each game in the game list, it prints it
            {
                Console.WriteLine(game);
            }

            games.Sort();                                                       //it sorts the game list
            Console.WriteLine("\nSorted games:");                               //a title that states what makes the list different
            foreach (string game in games)                                      //for each game in the game list, it prints it
            {
                Console.WriteLine(game);
            }

            string[] newList = new string[games.Count];                         //creates an array called newList and is initialized by the same size as the game list

            games.CopyTo(newList);                                              //copies the game list to the newList

            games.Clear();                                                      //clears the game list

            Console.WriteLine("\nNew List:");                                   //title of the new list
            foreach(string game in newList)                                     //for each game in the game list, it prints it
            {
                Console.WriteLine(game);
            }
        }
    }
}

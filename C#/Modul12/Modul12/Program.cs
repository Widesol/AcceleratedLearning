using System;
using System.Collections.Generic;

namespace Modul12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "Bruce Dickinson", "Jimmy Page" };
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "Bruce Dickinson", "Jimmy Page" };

            DisplayArrayOfRockStars(rockstarsArray);
            DisplayListOfRockStars(rockstarsList);
            DisplayArrayOfRockStars_ienu(rockstarsArray);
            DisplayListOfRockStars_ienu(rockstarsArray);
        }

        static void DisplayArrayOfRockStars(string[] rockstarsArray)
        {
            Console.WriteLine("My rockstars (array):");
            foreach (var item in rockstarsArray)
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayListOfRockStars(List<string> rockstarsList)
        {
            Console.WriteLine("My rockstars (list):");
            foreach (var item in rockstarsList)
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayArrayOfRockStars_ienu(string[] rockstarsArray)
        {
            Console.WriteLine("My rockstars (array):");
            foreach (var item in rockstarsArray)
            {
                Console.WriteLine(item);
            }

        }
        static void DisplayListOfRockStars_ienu(IEnumerable rrockstars)
        {
            Console.WriteLine("My rockstars (array):");
            foreach (var item in rockstarsArray)
            {
                Console.WriteLine(item);
            }

        }
        public interface Ienumerable
        {
            Console.WriteLine("My rockstars (array):");
            foreach (var item in rockstarsArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
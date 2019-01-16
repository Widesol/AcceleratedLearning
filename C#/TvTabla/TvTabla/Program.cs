using System;
using System.Collections.Generic;
using System.Linq;

namespace TvTabla
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var higherThanFive = new List <int> { 5, 10, 4, 18 };
         
            List <string> staroFiveList = higherThanFive(x => "*" + x + "*").ToList();

            List<string> stringar = StaroFiveList(higherThanFive);
            foreach (string item in stringar)
            {
                Console.Write(item);
            }

        }

        static List<string> StaroFiveList(List<int> higherThanFive)
        {
            List<string> stringar = new List<string>();
            foreach (int item in higherThanFive)
            {

                stringar.Add($"*{item.ToString()}*");

            }


            return stringar;
        }

    }
}

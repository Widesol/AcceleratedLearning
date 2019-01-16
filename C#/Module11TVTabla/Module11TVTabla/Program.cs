using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module11TVTabla
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Show> allShows = GetShowsFromTextFile();
            Console.WriteLine();
            DisplayInfoAboutShows(allShows);
            Console.WriteLine();
            DisplayShowsAfterTime(allShows);
            Console.WriteLine();
            DisplayShowsOn2(allShows);
            Console.WriteLine();
            CheckKulturNyheterna(allShows);
            Console.WriteLine();
            CheckEnsamPappaSöker(allShows);
            Console.WriteLine();
            AllaProgram20(allShows);
            Console.WriteLine();
            StoraBokstäver(allShows);
            Console.WriteLine();
            PrintaKanaler(allShows);



        }

       
        private static List<Show> GetShowsFromTextFile()
        {
            List<Show> allShows = new List<Show>();

            string[] aaa = File.ReadAllLines("TextFile1.txt");

           


            foreach (string item in aaa)
            {
                string[] splittadeTV = item.Split('*');
                var s = new Show
                {
                    Channel = splittadeTV[0],
                    Time= TimeSpan.Parse(splittadeTV[1]),
                    Program = splittadeTV[2]
                };
                allShows.Add(s);
            }
            return allShows;
            
        }

        private static void DisplayInfoAboutShows(List<Show> allShows)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ALLA TITLAR");
            Console.ResetColor();
            foreach (Show item in allShows)
            {
                Console.WriteLine(item.Program);
            }
        }
        private static void DisplayShowsAfterTime(List<Show> allShows)
        {
            List<Show> showAfter21 = new List<Show>();
            TimeSpan compareTime = new TimeSpan(21, 0, 0);

            foreach (var item in allShows)
            {

                if (item.Time>=compareTime)
                {
                    showAfter21.Add(item);
                }
            }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PROGRAM SOM BÖRJAR SENARE ÄN KL 21");
                Console.ResetColor();
            foreach (var item in showAfter21)
            {
                Console.WriteLine($"{item.Channel} {item.Time} {item.Program}");
            }
        }

        private static void DisplayShowsOn2(List<Show> allShows)
        {
            List<Show> showsOn2 = new List<Show>();

           // showsOn2.Sort((c1, c2) => TimeSpan.Compare(c1.Time - c2.Time));


            foreach (var item in allShows)
            {
                if (item.Channel.ToUpper() == "SVT2")
                {
                    showsOn2.Add(item);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PROGRAM PÅ SVT2");
            Console.ResetColor();
            List<Show> SortedList = showsOn2.OrderBy(o => o.Time).ToList();
           // showsOn2.Sort();
                //showsOn2(x => c1 > c2)
            foreach (var item in SortedList)
            {
                Console.WriteLine($"{item.Channel} {item.Time} {item.Program}");
            }

        }

        private static void CheckKulturNyheterna(List<Show> allShows)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("FINNS KULTURNYHETERNA");
            Console.ResetColor();
            string result="Nej";
            foreach (var item in allShows)
            {
                if (item.Program.ToUpper()== "KULTURNYHETERNA")
                {
                    result = "Ja";
                    break;
                }
            }
            Console.WriteLine(result);
        }

        private static void CheckEnsamPappaSöker(List<Show> allShows)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("FINNS ENSAM PAPPA SÖKER");
            Console.ResetColor();
            string result = "Nej";
            foreach (var item in allShows)
            {
                if (item.Program.ToUpper() == "ENSAM PAPPA SÖKER")
                {
                    result = "Ja";
                    break;
                }
            }
            Console.WriteLine(result);
        }
        private static void AllaProgram20(List<Show> allShows)
        {
            List<Show> startTid20 = new List<Show>();
            TimeSpan compareTime = new TimeSpan(20, 0, 0);
            foreach (var item in allShows)
            {
                if(item.Time==compareTime)
                {
                    startTid20.Add(item);
                }
            }
            foreach (var item in startTid20)
            {
                Console.WriteLine($"{item.Channel} {item.Time} {item.Program}");
            }
        }

        private static void StoraBokstäver(List<Show> allShows)
        {
            foreach (var item in allShows)
            {
                Console.WriteLine(item.Program.ToUpper());
            }
        }
        private static void PrintaKanaler(List<Show> allShows)
        {
            List<Show> kanaler = new List<Show>();
            

        }

    }
}

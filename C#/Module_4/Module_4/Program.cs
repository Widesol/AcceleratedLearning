using System;

namespace Module_4
{
    class Program
    {
        static string[] splittedList;

        static void Main(string[] args)
        {
            string names=AskForNames();
            string[]nameArray=SplitNames(names);
            string[]trimmedArray=CleanUpArray(nameArray);
            PrintNames(trimmedArray);

        }

       

        private static string AskForNames()
        {
            Console.Write("Enter names: ");
            string names = Console.ReadLine();
            return names;
        }

        private static string[] SplitNames(string names)
        {
            string[] nameArray = names.Split(",");
            return nameArray;
        }

        private static string[] CleanUpArray(string[] nameArray)
        {

            for (int i = 0; i < nameArray.Length; i++)
            {
                nameArray[i] = nameArray[i].Trim();
            }

            return nameArray;
        }

        private static void PrintNames(string[] trimmedArray )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in trimmedArray)
            {
                
                Console.WriteLine($"***Super-{item.ToUpper()}***");
            }
        }
    }
}

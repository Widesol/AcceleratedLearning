using System;
using System.Collections.Generic;

namespace Module10._4
{
    class Program
    {
        List<string> nameList;
        static void Main(string[] args)
        {
             List<string> nameList = new List<string>();
            string nameInput;

            while (true)
            {
                Console.Write("Enter a name to list, enter quit if you want to quit: ");
                Console.ForegroundColor = ConsoleColor.Green;
                nameInput = Console.ReadLine();
                Console.ResetColor();
                if (nameInput.ToLower()!="quit")
                {
                    nameList.Add(nameInput);
                }
                else
                {
                    break;

                }
            }
            PrintNames(nameList);
        }

        private static void PrintNames(List<string> nameList)
        {
            nameList.Sort();
            int sizeOfList = nameList.Count;
            if (sizeOfList > 2)
            {
                nameList.RemoveAt(nameList.Count - 1);
                nameList.RemoveAt(0);
                foreach (string names in nameList)
                {
                    Console.WriteLine($"Name: {names}");
                }
            }
            else
            {
                foreach (string names in nameList)
                {
                    Console.WriteLine($"Name: {names}");
                }
            }
        }

        
    }
}

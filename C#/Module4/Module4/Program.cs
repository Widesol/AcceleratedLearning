using System;

namespace Module4
{
    class Program
    {
        static string names;
        static string[] splitName;
        static string[] nameLine;
        static char separator;

        static void Main(string[] args)
        {

            SetSeparator();
            string names;
            names=GetInputFromUser();
            string[]splitName;
            splitName=CreateArrayOfPeople(names);
            string[] trimmedName;
            trimmedName=CleanUp(splitName);
            RespondToUser(trimmedName);

        }

        private static void SetSeparator()
        {
            
            string input;
            do
            {
                Console.WriteLine("Which separator you want to use, default is comma? ");
                input = (Console.ReadLine());
                if (input.Length == 1)
                {
                    separator = char.Parse(input);
                    break;
                }
            } while (true);
            Console.Clear();
        }

        private static string GetInputFromUser()
        {
            Console.Write("Enter names: ");
            string names = Console.ReadLine();
            return names;
        }

        private static string[] CreateArrayOfPeople(string nameLine)
        {
  
            string[] splitName = nameLine.Split(separator);
            
            return splitName;

        }

        private static string[] CleanUp(string[]trimmedName)
        {

            for (int i = 0; i < trimmedName.Length; i++)
            {
                trimmedName[i] = trimmedName[i].Trim();
            }

            return trimmedName;

            

        }

        private static void RespondToUser(string[]finalList)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string item in finalList)
            {
                Console.WriteLine("***SUPER-" + item.ToUpper() + "***");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Module10._5
{
    class Program
    {
        static int dicInt;
        static string dicString;


        static void Main(string[] args)
        {

            Dictionary<int, string> dic = GettingInput();
            ResponseToUser(dic);



        }

        private static Dictionary<int, string> GettingInput()
        {

            Dictionary<int, string> dic = new Dictionary<int, string>();
            while (true)
            {
                Console.Write("Enter product id and name seperate with comma: ");


                try
                {
                    var input = Console.ReadLine();
                    string[] inputArray = input.Split(',');
                    if (string.IsNullOrWhiteSpace(input))
                        break;
                    dicInt = int.Parse(inputArray[0]);
                    dicString = inputArray[1];

                    if (dic.ContainsKey(dicInt))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Number taken");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }

                    else
                        dic.Add(dicInt, dicString);
                }
                catch (FormatException)
                {

                    Console.WriteLine("Invalid input");
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid Input");
                }

                catch(ArgumentException)
                {
                    Console.WriteLine("Argument exception");
                }






            }
            return dic;



        }

        private static void ResponseToUser(Dictionary<int, string> listToShow)
        {
            foreach (var item in listToShow)
            {
                Console.WriteLine($"Product id={item.Key} and name {item.Value}");
            }





        }
    }
}

using System;
using System.Collections.Generic;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.1
            //Console.Write("Bedtime? ");
            //int bedTime = int.Parse(Console.ReadLine());
            //Console.Write("Wake up time? ");
            //int wakeTime = int.Parse(Console.ReadLine());

            //if (bedTime<24&&bedTime>12)
            //{
            //    int sleepTime = (24 - bedTime) + wakeTime;
            //    Console.WriteLine($"You have slept {sleepTime} hours");
            //}
            //else
            //{
            //    int sleepTime = wakeTime - bedTime;
            //    Console.WriteLine($"You have slept {sleepTime} hours");
            //}

            //Console.WriteLine("How long is your usual sleepingperiod? ");
            //int usualSleep = int.Parse(Console.ReadLine());

            //Console.WriteLine("When do you want to wake up? (e.g 2017-08-09 22:30) ");
            //string time = Console.ReadLine();

            //DateTime setTime;
            //DateTime.TryParse(time, out setTime);

            //Console.WriteLine(setTime);

            ////DateTime setTime = new DateTime(Console.ReadLine());
            ////Console.WriteLine(setTime).DateTime
            ///

            //3.2

            //string name;
            //int numberOfTimes;
            //do
            //{
            //Console.Write("Enter name: ");
            // name=Console.ReadLine();

            //} while (name.Length>10);
            //do
            //{
            //Console.Write("Enter number: ");
            //numberOfTimes=int.Parse(Console.ReadLine());

            //} while (numberOfTimes>10);

            //int x = 0;
            //string input;

            //do
            //{
            //Console.WriteLine("Do you want to have it comma seppareted or line separeted? answer 'line' or 'comma'");
            // input = Console.ReadLine().ToLower();


            //} while ((input != "line" || input == "comma"));

            //if (input=="line")
            //{

            //while (true)
            //{
            //    Console.Write(name.ToUpper()+", ");
            //    x++;
            //    if (x==numberOfTimes)
            //    {
            //        break;
            //    }
            //}


            //}
            //else
            //{
            //    while (true)
            //    {
            //        Console.WriteLine(name.ToUpper() + ", ");
            //        x++;
            //        if (x == numberOfTimes)
            //        {
            //            break;
            //        }
            //    }
            //}

            //3.3

            // string name;
            // int numberOfTimesR;
            // int numberOfTimesC;
            // Console.Write("Enter name: ");
            //     name = Console.ReadLine().ToUpper();

            //     Console.Write("Enter number of columns: ");
            //     numberOfTimesC = int.Parse(Console.ReadLine());
            // Console.Write("Enter number of raws: ");
            // numberOfTimesR = int.Parse(Console.ReadLine());

            // char[] reversedName = name.ToCharArray();
            // Array.Reverse(reversedName);
            //string newReversedName = new string (reversedName);

            // for (int i = 0; i <numberOfTimesR; i++)
            // {
            //     for (int j = 0; j < numberOfTimesC; j++)
            //     {
            //     Console.Write($"{name}{newReversedName}  ");

            //     }
            //     Console.WriteLine();
            // }

            // Console.WriteLine("How many times you want to see your name, side bi side, 1-9?");
            // int numberNames = int.Parse(Console.ReadLine());


            // for (int i = 0; i < numberOfTimesR; i++)
            // {
            //     for (int j = 0; j < numberOfTimesC; j++)
            //     {
            //         Console.Write($"{name}  ");

            //     }
            //     Console.WriteLine();
            // }

            //3.5

            //Console.WriteLine("Enter names to list:");
            //string nameList=Console.ReadLine();
            //Console.WriteLine("Enter username?");
            //string lM = Console.ReadLine().ToUpper();

            //string[] nameArray = nameList.Split(",");
            //string allowZelda = "AllowZelda";


            ////Om arrayen innehåller AllowZelda
            //foreach (var item in nameArray)
            //{

            //}
            //    if (item != "Zelda")
            //    {


            //        Console.WriteLine($"{item} {lM}");

            //    }
            //    else
            //        break;

            //3.6

            Random random = new Random();

            int returnValue = random.Next(1, 100);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Guess a number: ");
                int guessedNumber = int.Parse(Console.ReadLine());
                if (returnValue == guessedNumber)
                {
                    Console.WriteLine("WOHO");
                    break;
                }



            }
                Console.WriteLine("GAME OVER");



        }


    }
}

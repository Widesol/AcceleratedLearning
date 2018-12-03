using System;
using System.IO;

namespace Module8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("The chocolate contains 24 pieces");
            //Console.Write("How many want to share?");



            //try
            //{


            //decimal persons = decimal.Parse(Console.ReadLine());
            //    if (persons<0)
            //    {
            //        throw new Exception();
            //    }
            //decimal piecesEach = 24 / persons;

            //Console.WriteLine($"Evryone get {piecesEach}");

            //}
            //catch(FormatException ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(ex.Message);
            //}

            //catch (Exception)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("You can't divide with zero or less");
            //}


            //8.2

            while(true)
            {
                
                Console.Write("Enter a file name: ");


                try
                {
                    File.CreateText(Console.ReadLine());

                    break;


                   
                }
                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Något fel på filnamnet!");

                }
                catch (UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Can't reach the file this way");
                }
                catch(Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Can't do baby doll");
                }

            } 
            


            
        }
    }
}

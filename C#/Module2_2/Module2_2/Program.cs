using System;
using System.Text;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] questions = new string[3];
            ////questions[0]=
            //Console.Write("What is your name? ");
            //string name = Console.ReadLine();
            //bool result = Char.IsNumber(name,5);
            //if (result)
            //Console.WriteLine("Det är en siffra");
            //Console.Write("And age? ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Favorite letter? ");
            //char letter=char.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Thank you");
            //Console.WriteLine();
            //int retirement = 65;
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Your name is {0}",name);
            //Console.WriteLine("Your have {0}",retirement-age);
            //Console.WriteLine("Your favorite letter is {0}",letter);

            Console.WriteLine("How many fruits ");
            int number = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            //sb = "You choosed";
            char space = ' ';

            for (int i = 0; i < number; i++)
            {
            Console.Write("Enter fruit ");
                string frukt = Console.ReadLine();
                sb.Append(frukt+space); 
            }

            string result = sb.ToString();


            
            Console.WriteLine($"      {result}       ");


            result.Trim(space);

            Console.WriteLine(result);

            //string fruit1=Console.ReadLine();
            //Console.Write("Enter fruit ");
            //string fruit2 = Console.ReadLine();
            //Console.Write("Enter fruit ");
            //string fruit3 = Console.ReadLine();

            //Console.WriteLine("You entered {0} {1} {2}", fruit1, fruit2, fruit3);
            //Console.WriteLine($"You entered {fruit1}, {fruit2}, {fruit3}");



        }
    }
}

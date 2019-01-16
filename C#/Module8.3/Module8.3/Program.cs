using System;
using System.Text.RegularExpressions;

namespace Module8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter animals, seperate with',': ");
            string animalsString = Console.ReadLine();
            try
            {
                
                string[]annimalArray=ParseAnimal(animalsString);

                foreach (string item in annimalArray)
                {
                    Console.WriteLine(item);
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            
            
        }

       

        private static string[] ParseAnimal(string animalsString)
        {

        if (animalsString.Length <= 0)
        {
                throw new ArgumentException("You have to write");
        }

            string[] animalArray = animalsString.Split(',');
            foreach (string item in animalArray)
            {

         if (item.Length<0)
                {
                    throw new ArgumentException("One of animals does not contain");
                }
         else if(item.Length>10)
                {
                    throw new ArgumentException("Too many letters");
                }
            else if(!Regex.IsMatch(item,@"^[A-Za-z]+$"))
                {
                    throw new ArgumentException("Wrong letters");
                }
        

            }
            return animalArray;














        }

        
    }
}

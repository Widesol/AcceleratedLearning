using System;

namespace Module_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Lisa = new Person();
            Lisa.FirstName = "Lisa";
            Lisa.LastName = "Andersson";
            Lisa.Birthday = new DateTime(1993,2,12);
            Lisa.Gender = "Female";
            Lisa.FavoriteSport = Sport.Hockey;

            Console.WriteLine($"Lisa is a {Lisa.Gender} that likes to play {Lisa.FavoriteSport}" );

            Console.Write("Enter a sport: ");
            string input = Console.ReadLine().ToUpper();

            if (Enum.TryParse(input, true, out Sport sport))
            {
                Console.WriteLine($"I know {sport}");
            }

        }


    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public Sport FavoriteSport { get; set; }


    }
    enum Sport
    {
        Football,
        Hurling,
        Hockey,
        Banana
    }
    
}

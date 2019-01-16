using System;
using System.Collections.Generic;

namespace FruitDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClearAndInitDatabase();
            //DisplayAllFruits();
            DisplayAllSkenfrukter();
           
        }

        private static void DisplayAllSkenfrukter()
        {
            var dataAccess = new DataAccess();
            List<Fruit> fruits = dataAccess.GetFruitsinCategory("Skenfrukt");
            Console.WriteLine();
            Console.WriteLine("Skenfrukter");
            Console.WriteLine();
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.Name);
            }
        }

        private static void ClearAndInitDatabase()
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.AddCategoriesAndFruits();
            //dataAccess.ClearDatabase()
        }
        private static void DisplayAllFruits()
        {
            DataAccess dataAccess = new DataAccess();

            var frukLista=dataAccess.GetAll();

            foreach (Fruit item in frukLista)
            {
                Console.WriteLine($"{item.Name, -15} {item.Category.Name, -15} {item.Price}");
            }
        }
    }
}

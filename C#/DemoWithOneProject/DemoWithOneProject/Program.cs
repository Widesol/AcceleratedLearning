using System;

namespace DemoWithOneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitContext context = new FruitContext();
            //context.Database.EnsureDeleted();

            //context.Database.EnsureCreated();

            var newfruit = new Fruit
            {
                Name = "Banan",
                Color="Gul"
            };
            context.Fruits.Add(newfruit);
            context.Fruits.Add(new Fruit { Name = "Apple", Color="Red" });
            context.SaveChanges();

            //context.Fruits
            foreach (Fruit x in  context.Fruits)
            {
                Console.WriteLine(x.Id + " " + x.Name + " " + x.Color);
            }
        }
    }
}

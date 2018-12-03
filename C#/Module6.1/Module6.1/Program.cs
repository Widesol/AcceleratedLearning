using System;

namespace Module6._1
{
    class Program
    {
        static void Main(string[] args)
        {
        Circle bob = new Circle("Bob", 8);

        Circle lisa = new Circle("Lisa", 30);

            lisa.SayHello();
            bob.SayHello();
            Console.WriteLine();
            lisa.WriteArea();
            bob.WriteArea();


        }
    }

    class Circle
    {
        double pi = 3.14;
       public void SayHello()
        {
            Console.WriteLine("Hi im a circle with name " +  Namn);
        }

        public string Namn { get; set; }


        public void WriteArea()
        {
            Console.WriteLine("I have the radius of of "+Storlek +" and the area of " + Storlek*Storlek*pi);
        }

       public double Storlek { get; set; }


        public Circle (string name, double size)
        {
            Namn =name;
            Storlek=size;
        }


    }

}

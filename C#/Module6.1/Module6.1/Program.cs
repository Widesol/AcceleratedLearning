using System;

namespace Module6._1
{
    class Program
    {
        static void Main(string[] args)
        {


            var p1 = new Person();
            p1.Name = "Pelle";
            p1.Age = 2;
            //p1.UntilRetirement = 15;

            Console.WriteLine($"{p1.Name} är {p1.Age}år och går i pension {p1.UntilRetirement}år");
            //Circle bobby = new Circle("Bobby", 8);
            

            //Circle ooo = new Circle("Bob");

            //Circle2 bob = new Circle2();
            ////bob.Name = "Bob";
            //bob.Size = 8;

            ////bob.Name = "Lisa";

            //Console.WriteLine($"{bob.Name}");

            //Circle lisa = new Circle("Lisa", 30);

            //bob.SayHello();
            //lisa.SayHello();
            //lisa.WriteArea();
            //bob.WriteArea();

        }
    }

    public class Circle
    {

        string name;
        int size;
        double pi = 3.14;

        public Circle(string n, int a)
        {
            name = n;
            size = a;

        }

        internal void SayHello()
        {
            Console.WriteLine($"Hi my name is {name}");
        }

        internal void WriteArea()
        {
            Console.WriteLine($"Hi my area is {size * size * pi}");
        }
    }

}

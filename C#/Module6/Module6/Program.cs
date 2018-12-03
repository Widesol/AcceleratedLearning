using System;

namespace Module6
{
    class Program
    {
        static void Main(string[] args)
        {
            // todo: gör klassen Car


                var c1 = new Car("Blå", 1300);
                var c2 = new Car("Röd", 1500);
                var c3 = new Car("Silver", 800);

            //c1.SetColor("blå");

            
               
                // c2.SetColor("röd");

                var yyy = c1.Color;
                var zzz = c2.Color;
                

                Console.WriteLine("Färgen på bilen 'c1' är " + yyy);
                Console.WriteLine("Färgen på bilen 'c2' är " + zzz);
                Console.WriteLine("Färgen på bilen 'c3' är " + c3.Color + c3.Weight);


            }
    }
    class Car
    {
        public string Color { get; set; }
        public int Weight { get; set; }

        //string color;
        //int weight;

        //public void SetColor(string xxx)
        //{
        //    color = xxx;
        //}

        //public string GetColor()
        //{
        //    return color;
        //}
        public Car(string färg, int vikt)
        {
            Color = färg;
            Weight = vikt;



        }
    }
}

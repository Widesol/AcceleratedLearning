using System;

namespace Modul6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube myCube = new Cube(2,3,4);
            Cube superCube = new Cube(100,200,300);

            myCube.WriteVolume();
            superCube.WriteVolume();

            double volume = myCube.CalculateVolume();
            double supervolume = superCube.CalculateVolume();


        }
       

    }
    class Cube
    {
        double volym;

        public int Höjd;


        public int Längd;

        public int Bas;


        public Cube(int h, int l, int b)
        {
            Höjd = h;
            Längd = l;
            Bas = b;
        }

        public void WriteVolume()
        {
            
            double volym = Höjd * Längd * Bas;
            Console.WriteLine("Volume of cube: " +volym);
            
        }

        internal double CalculateVolume()
        {
            double volym = Höjd * Längd * Bas;
            return volym;
        }
    }
}

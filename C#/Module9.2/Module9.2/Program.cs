using System;
using System.IO;

namespace Module9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileWatch=new FileSystemWatcher();
            fileWatch.Path = @"C:\Project\Path";
            fileWatch.EnableRaisingEvents = true;
            Console.WriteLine("This watches folder Path");
            fileWatch.Created += EnFilÄrSkapad;
            fileWatch.Changed += EnFilÄrÄndrad;
            fileWatch.Deleted += EnFilÄrBorttagen;

            Console.ReadKey();

        }

        private static void EnFilÄrSkapad(object sender, FileSystemEventArgs e)
        {

            Console.WriteLine($"File {e.Name} is created");
        }

        private static void EnFilÄrÄndrad(object sender, FileSystemEventArgs e)
        {

            Console.WriteLine($"File {e.Name} is changed");
            
        }

        private static void EnFilÄrBorttagen(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} is deleted");
        }
    }
}

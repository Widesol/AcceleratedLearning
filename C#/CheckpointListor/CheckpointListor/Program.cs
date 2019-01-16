using System;
using System.Collections.Generic;

namespace CheckpointListor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> heltal = new List<int>();
            heltal.Add(3);
            heltal.Add(6);
            heltal.Add(9);
            heltal.Add(12);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Listan");
            Console.ResetColor();
            Console.WriteLine($"{heltal[0]},{heltal[1]},{heltal[2]},{heltal[3]}");
            List<int> nyaListan=MultiplyBy100AndAdd3(heltal);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nya listan");
            Console.ResetColor();
            Console.WriteLine($"{nyaListan[0]},{nyaListan[1]},{nyaListan[2]},{nyaListan[3]}");

            //List<int> list1 = new List<int>() { 1, 2, 4, 3 };
            //List<string> charList = new List<string>() {"a", "b", "c", "d" };

            //ReorderList(list1,charList);
           
        }

        //private static void ReorderList(List<int> list1, List<string> charList)
        //{
        //    string[] merged = new string[list1.Count];
        //    string[] bArray = new string[list1.Count];
        //    List<string> slutLista = new List<string>();
        //    int count = 1;
            
        //    if (list1.Count==charList.Count)
        //    {
        //    foreach (var item in list1)
        //    {
        //        merged[count-1]=$"{list1[count-1]}{charList[count-1]}";
        //    }

        //    }
        //    foreach (string item in merged)
        //    {
        //        if (item[0]==list1[0]) 
        //        {
        //            bArray[0] = item;
                   
        //        }
        //        else if (item[0]==list1[1])
        //        {
        //            bArray[1] = item;
        //        }
        //        else if (item[0] == list1[2])
        //        {
        //            bArray[2] = item;
        //        }
        //        else if (item[0] == list1[3])
        //        {
        //            bArray[3] = item;
        //        }

        //    }

        //    foreach (var item in bArray)
        //    {
        //        string a;
        //        a = item.Substring(1);
                
               
        //        slutLista.Add(a);
        //    }

        


        //}

        private static List<int> MultiplyBy100AndAdd3(List<int> heltal)
        {
            List<int> bearbetadeHeltal = new List<int>();
            int tal;
            int count = 0;
            foreach (int item in heltal)
            {
                 tal= (heltal[count] * 100) + 3;
                bearbetadeHeltal.Add(tal);
                count++;
            }
            return bearbetadeHeltal;
        }
    }
}

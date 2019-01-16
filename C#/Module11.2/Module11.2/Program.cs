using System;
using System.Collections.Generic;
using System.IO;

namespace Module11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textfilen = File.ReadAllLines("TextFile1.txt");
            List<Customer> list = CreateListOfCustomers(textfilen);
            RemoveFirstLine();
            SortedListByAge(list);
        }

      

        private static List<Customer> CreateListOfCustomers(string[] textfilen)
        {
            List<Customer> cust = new List<Customer>();

            // Gender g = Enum.Parse<Gender>("Male");

            foreach (string item in textfilen)
            {
                string[] splitListOfFacts = item.Split(',');
                
                var s = new Customer
                {
                    ID = int.Parse(splitListOfFacts[0]),
                FirstName = splitListOfFacts[1],
                LastName = splitListOfFacts[2],
                    EMail = splitListOfFacts[3],
                     Gender =(Gender)Enum.Parse(typeof(Gender), splitListOfFacts[4]),
                    Age = int.Parse(splitListOfFacts[5]),
                };
                cust.Add(s);
            }
            
            return cust ;
        }

        private static void RemoveFirstLine()
        {
            throw new NotImplementedException();
        }

        private static void SortedListByAge(List<Customer> list)
        {
            // List<Order> SortedList = objListOrder.OrderBy(o => o.OrderDate).ToList();
            list.Sort((c1, c2) => c1.Age - c2.Age);
            //list.Sort((c1, c2) =>string.Compare(c1.FirstName - c2.FirstName));

        }
    }
}

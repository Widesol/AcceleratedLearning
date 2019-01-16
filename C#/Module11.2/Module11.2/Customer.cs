using System;
using System.Collections.Generic;
using System.Text;

namespace Module11._2
{
   public class Customer
    {
        public int  ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
}

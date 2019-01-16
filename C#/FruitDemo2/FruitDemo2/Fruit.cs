using System;
using System.Collections.Generic;
using System.Text;

namespace FruitDemo2
{
    class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public FruitCategory Category { get; set; }
    }
    class FruitCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

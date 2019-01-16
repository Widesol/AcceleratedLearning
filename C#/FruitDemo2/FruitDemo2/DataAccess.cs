using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FruitDemo2
{
    internal class DataAccess
    {
        readonly FruitContext _context;
        
        public DataAccess()
        {
            _context = new FruitContext();

        }

        //_context.Database.EnsureDeleted();

        //_context.Database.EnsureCreated();



        internal void AddCategoriesAndFruits()
        {
            FruitCategory skenfrukt = new FruitCategory { Name = "Skenfrukt" };
            FruitCategory torrÄkta = new FruitCategory { Name = "Torr äkta frukt" };
            FruitCategory saftigÄkta = new FruitCategory { Name = "Saftig att äta" };

            _context.Fruits.Add(new Fruit { Name = "Apple", Category = skenfrukt, Price = 18 });
            _context.Fruits.Add(new Fruit { Name = "Banan", Category = torrÄkta, Price=14 });
            _context.Fruits.Add(new Fruit { Name = "Mango", Category = skenfrukt, Price=19 });
            _context.SaveChanges();

        }

        internal List<Fruit> GetFruitsinCategory(string v)
        {
            var fruits = new List<Fruit>();
            fruits = _context.Fruits.Where(s => s.Category.Name == v).ToList();
            return fruits;
        }

        internal List<Fruit> GetAll()
        {
            var lista= _context.Fruits.Include(x => x.Category).ToList();
            return lista;
        }

        //internal void ClearDatabase()
        //{
        //    foreach (var category in _context.Categorys)
        //    {
        //        _context.Remove(category);
        //    }
        //    foreach (var fruit in _context.Categorys)
        //    {
        //        _context.Remove(fruit);
        //    }
        //    _context.SaveChanges();
        //}
    }
}

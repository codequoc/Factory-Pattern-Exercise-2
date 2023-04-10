﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MangoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "RTX 3090", Price = 900},
            new Product() { Name = "Intel 13700k", Price = 500}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading from the Mango class");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data in Mango class");
        }
    }
}

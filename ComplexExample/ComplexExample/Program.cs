﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            double t = r.NextDouble();
            int q = r.Next(20, 30);
            Console.ReadKey();
            
        }
    }
}

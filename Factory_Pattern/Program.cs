﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Rectangle or Circle ...");
            string type = Console.ReadLine();

            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape = shapeFactory.GetShape(type);
            shape.DrawShape();

            Console.ReadKey();

        }
    }
}

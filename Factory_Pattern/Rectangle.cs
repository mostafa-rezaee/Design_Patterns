using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Rectangle : IShape
    {

        public void DrawShape()
        {
            Console.WriteLine("Rectangle drawed successfully!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            Console.WriteLine(logger1.GetHashCode());
            Console.WriteLine(logger2.GetHashCode());
            Console.ReadLine();

        }
    }
}

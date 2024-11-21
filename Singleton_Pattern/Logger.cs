using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    internal class Logger
    {
        private static readonly Logger Instance = new Logger();
        private Logger() { }
        public static Logger GetInstance()
        {
            return Instance;
        }
    }
}

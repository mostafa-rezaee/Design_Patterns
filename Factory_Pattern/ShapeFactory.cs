using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class ShapeFactory
    {
        public IShape GetShape(string type)
        {
            switch (type.ToLower())
            {
                case "rectangle":
                    return new Rectangle();
                case "circle":
                    return new Circle();
                case "line":
                    return new Line();
            }
            return null;
        }
    }
}

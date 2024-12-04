using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class ShapeFactory
    {
        public static Shape GetShape(string type)
        {
            switch(type)
            {
                case "Hexagon":
                    return new Hexagon();
                case "Pentagon":
                    return new Pentagon();
                default:
                    return null;
            }
        }
    }
}

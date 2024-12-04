using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class Hexagon : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a Hexagon");
        }
    }
}

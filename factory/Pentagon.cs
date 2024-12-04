using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class Pentagon : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a Pentagon...");
        }
    }
}

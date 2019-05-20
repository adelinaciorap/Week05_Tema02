using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Test
    {

        static void Main(string[] args)
        {
            // Array of shapes
            Shape[] shapes = new Shape[]
            {
                new Triangle(7, 8),
                new Rectangle(11.5, 2),
                new Square(7)
            };
            
            foreach (Shape element in shapes)
            {
                Console.WriteLine("{0}= {1}", element.GetType().Name, element.CalculateSurface());
            }

        }
    }
}




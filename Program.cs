using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_ConsoleApp_AreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float areaResult;
            Console.WriteLine("What Shape Would You Like to find the area of? \n Please enter 'R' for RECTANGLE or ANY OTHER key for CIRCLE");
            answer=Console.ReadLine();
            if (answer=="r")
            {
                Console.WriteLine("ENter the height of the rectangle");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter the width of the rectange");
                float width = float.Parse(Console.ReadLine());

                areaResult=width*height;

                Console.WriteLine("Area: "+areaResult);
            }
            else
            {
                Console.WriteLine("Enter the radius of the circle");
                float radius=float.Parse(Console.ReadLine());
                areaResult=(float)Math.PI*(radius);
                Console.WriteLine("Area of the circle: " + areaResult);
            }
            Console.ReadKey();
        }
    }
}

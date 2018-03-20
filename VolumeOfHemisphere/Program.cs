using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfHemisphere
{
    class Program
    {
        static void Main(string[] args)
        {

            const double PI = 3.14159;
            Console.WriteLine("Enter the radius: ");
            String r = Console.ReadLine();
            double radius = Convert.ToDouble(r);

            double area = PI * (radius * radius);
            double volume = (4 / 3) * radius * area;

            Console.WriteLine("The volume of this hemisphere is: " + volume);
        }
    }
}

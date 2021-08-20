using System;

namespace Area_Of_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * radius * radius;
            return area;
        }
    }
}

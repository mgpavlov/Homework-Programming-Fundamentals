using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Intersection_of_Circles
{

    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        class Circle
        {
            public Point Center { get; set; }
            public int R { get; set; }
        }
        static void Main(string[] args)
        {
            Circle c1 = ReadCircle(Console.ReadLine());
            Circle c2 = ReadCircle(Console.ReadLine());
            Intersect(c1, c2);
        }
        static Circle ReadCircle(string input)
        {
            int[] tokens = input.Split(' ').Select(int.Parse).ToArray();
            return new Circle { Center = new Point { X = tokens[0], Y = tokens[1] }, R = tokens[2] };
        }
        private static void Intersect(Circle c1, Circle c2)
        {
            int deltaX = c1.Center.X - c2.Center.X;
            int deltaY = c1.Center.Y - c2.Center.Y;
            double distanceBetweenCenters = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (distanceBetweenCenters > c1.R + c2.R)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}

using System;

namespace OutVar
{
    class Program
    {
        static void Main(string[] args)
        {
            if(int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine($"{nameof(x)} = {x}");
            }
            PrintCoordinates(new Point(10, 20));
        }

        private static void PrintCoordinates(Point p)
        {
            if (p.GetCoordinates(out int x, out int y))
            {
                Console.WriteLine($"({x}, {y})");
            }
        }
    }

    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool GetCoordinates(out int x, out int y)
        {
            x = X;
            y = Y;
            return true;
        }
    }
}

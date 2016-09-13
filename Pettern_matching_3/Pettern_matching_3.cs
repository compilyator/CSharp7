using System;
using static System.Console;

namespace Pettern_matching_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new Shape[]
            {
                new Rectangle {Length = 10, Height = 20 },
                new Circle { Radius = 5 },
                new Rectangle {Length = 30, Height = 30 },
                null
            };
            foreach (var shape in shapes)
            {
                try
                {
                    switch (shape)
                    {
                        case Circle c:
                            WriteLine($"circle with radius {c.Radius}");
                            break;
                        case Rectangle s when (s.Length == s.Height):
                            WriteLine($"{s.Length} x {s.Height} square");
                            break;
                        case Rectangle r:
                            WriteLine($"{r.Length} x {r.Height} rectangle");
                            break;
                        default:
                            WriteLine("<unknown shape>");
                            break;
                        case null:
                            throw new ArgumentNullException(nameof(shape));
                    }
                }
                catch (Exception e)
                {
                    WriteLine($"Exception: {e}");
                }
            }
            ReadKey();
        }
    }

    class Shape { }

    class Circle : Shape { public int Radius; }

    class Rectangle : Shape { public int Length; public int Height; }
}

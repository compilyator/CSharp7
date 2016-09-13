using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace TuplesDecomposition
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var (min, max) = GetMinMax(data);
            Console.WriteLine($"Min: {min} Max: {max}");
            Console.ReadKey();
        }

        static (T Min, T Max) GetMinMax<T>(IEnumerable<T> source) =>
                    (source.Min(), source.Max());

    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuples
{
    class Program
    {
static void Main(string[] args)
{
    var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    var result = GetMinMax(data);
    Console.WriteLine($"Min: {result.Min} Max: {result.Max}");
    Console.ReadKey();
}

static (T Min, T Max) GetMinMax<T>(IEnumerable<T> source) =>
            (source.Min(), source.Max());
    }
}

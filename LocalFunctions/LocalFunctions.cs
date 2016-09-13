using System;
using System.Collections.Generic;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            void ForEach<T>(IEnumerable<T> source, Action<T> action)
            {
                foreach (var item in source)
                {
                    action?.Invoke(item);
                }
            }

            var list = new[] { "First", "Second", "Third", "Forth", "Fifth" };
            ForEach(list, Console.WriteLine);
            Console.ReadKey();
        }
    }
}

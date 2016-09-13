using System;

namespace Digit_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = 11__259_375;
            var x = 0xAB_CD_EF;
            var b = 0b1010_1011_1100_1101_1110_1111;

            Console.WriteLine($"{nameof(d)}: {d}, {nameof(x)}: {x}, {nameof(b)}: {b}");
            Console.ReadKey();
        }
    }
}

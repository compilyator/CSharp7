using System;

namespace Pattern_matching_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInt("123");
            PrintInt(234);
            PrintInt(null);
            PrintInt("");
            Console.ReadKey();            
        }

        static void PrintInt(object o)
        {
            if (o is int i || (o is string s && int.TryParse(s, out i)))
            {
                Console.WriteLine(i);
            }
        }
    }
}

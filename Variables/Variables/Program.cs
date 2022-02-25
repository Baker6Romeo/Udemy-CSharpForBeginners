

using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a++;
            Console.WriteLine(b);

            int c = 1;
            int d = ++c;
            Console.WriteLine(d);
        }
    }
}

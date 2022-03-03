

namespace DemoLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (var i = 1; i <10; i++)
            {
                if (i % 2 == 0)
                    System.Console.WriteLine(i);
            }*/

            /*for (var i = 10; i > 1; i--)
            {
                if (i % 2 == 0)
                    System.Console.WriteLine(i);
            }*/

            /*var name = "John Smith";
            foreach (char character in name)
                System.Console.WriteLine(character);*/

            var i = 1;
           while (i <= 10)
            {
                if (i % 2 == 0)
                    System.Console.WriteLine(i);

                i++;
            }
        }
    }
}

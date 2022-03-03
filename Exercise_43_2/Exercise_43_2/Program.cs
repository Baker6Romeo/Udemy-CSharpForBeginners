/*Write a program which takes two numbers from the console and displays the maximum of the two.*/

using System;

namespace Exercise_43_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type two numbers: ");
            var numbers = Console.ReadLine().Split(' ');
            if (int.Parse(numbers[0]) > int.Parse(numbers[1]))
                Console.WriteLine(numbers[0]);
            else
                Console.WriteLine(numbers[1]);
        }
    }
}

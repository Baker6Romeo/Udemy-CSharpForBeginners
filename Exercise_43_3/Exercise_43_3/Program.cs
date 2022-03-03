/*Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or
portrait.*/

using System;

namespace Exercise_43_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width and height of your image separated by a space: ");
            var numbers = Console.ReadLine().Split();
            if (int.Parse(numbers[0]) > int.Parse(numbers[1]))
                Console.WriteLine("Landscape");
            else
                Console.WriteLine("Portrait");
        }
    }
}

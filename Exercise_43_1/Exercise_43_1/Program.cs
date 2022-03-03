﻿/*Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid
number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications
where values entered into input boxes need to be validated.)*/

using System;

namespace Exercise_43_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 10: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input > 0 && input <= 10 ? "valid" : "invalid");
        }
    }
}

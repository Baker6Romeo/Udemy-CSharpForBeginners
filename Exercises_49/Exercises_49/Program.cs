using System;
using System.Linq;

namespace Exercises_49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder
                Display the count on the console.*/


            int count = 0;
            int floor = 1;
            int i = floor;
            int ceiling = 100;
            int divisor = 3;

            while (i < ceiling + 1)
            {
                if (i % divisor == 0)
                    count++;
                i++;
            }
            Console.WriteLine(string.Format("There are {0} numbers between {1} and {2} that are divisable by {3}",
                count, floor, ceiling, divisor));

            /*2 - Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of
                all the previously entered numbers and display it on the console.*/

            int sum = 0;
            bool exitRequested = false;
            do
            {
                Console.WriteLine("Enter a number or \"ok\" to exit: ");
                string input = Console.ReadLine();
                if (!input.Equals("ok"))
                {
                    Console.WriteLine(sum += int.Parse(input));
                }
                else
                    exitRequested = true;
            } while (!exitRequested);

            /*3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on
                the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and
                display it as 5! = 120.*/

            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            int factorial = input;
            for (int i = factorial - 1; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(String.Format("{0}! = {1}.", input, factorial));

            /*4 - Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the
                number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure
                the program is behaving correctly, you can display the secret number on the console first.)*/

            Random random = new Random();
            int guessesLeft = 4;
            int number = random.Next(1, 10);
            Console.WriteLine(number);
            do
            {
                Console.WriteLine("Pick a number between 1 and 10");
                int guess = int.Parse(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else if (guessesLeft < 1)
                    Console.WriteLine("You lost");
                else
                    Console.WriteLine("try again");

            } while (guessesLeft > 0);

            /*5 - Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of
                the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program" +
                "should display 8.*/

            Console.WriteLine("Enter numbers separated by commas: ");
            string[] inputs = Console.ReadLine().Split(',');
            int[] numbers = new int[inputs.Length];
            for (int i = 0; i < numbers.Length; i++)
                numbers.SetValue(int.Parse(inputs[i]), i);
            Console.WriteLine(numbers.Max());
        }
    }
}

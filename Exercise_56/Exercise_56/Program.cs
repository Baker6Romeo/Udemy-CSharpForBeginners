using System;
using System.Collections.Generic;

namespace Exercise_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

                    If no one likes your post, it doesn't display anything.
                    If only one person likes your post, it displays: [Friend's Name] likes your post.
                    If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
                    If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other
                        People] others like your post.
                Write a program and continuously ask the user to enter different names, until the user presses
                Enter(without supplying a name). Depending on the number of names provided, display a message based on
                the above pattern.*/

            /*Console.WriteLine("Enter a name: ");
            string input = Console.ReadLine();
            List<string> names = new List<string>();
            while (input != "")
            {
                names.Add(input);
                Console.WriteLine("Enter a name: ");
                input = Console.ReadLine();
            }
            if (names.Count == 1)
                Console.WriteLine(string.Format("{0} likes your post.", names[0]));
            if (names.Count == 2)
                Console.WriteLine(string.Format("{0} and {1} like your post.", names[0], names[1]));
            if (names.Count > 2)            
                Console.WriteLine(string.Format("{0}, {1}, and {2} other(s) like your post.", names[0], names[1],
                    names.Count -2));*/

            /*2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store
                the result in a new string.Display the reversed name on the console.*/

            /*Console.WriteLine("Enter a name:");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string output = new string(chars);
            Console.WriteLine(output);*/

            /*3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an
                error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them
                and display the result on the console.*/

            /*Console.WriteLine("Enter a number:");
            List<string> numbers = new List<string>();
            do
            {
                var input = Console.ReadLine();
                if (numbers.Contains(input))
                    Console.WriteLine("Try again:");
                else
                    numbers.Add(input);
            } while (numbers.Count < 5);*/

            /*4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of
                numbers may include duplicates.Display the unique numbers that the user has entered.*/

            /*List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or \"quit\" to exit:");
                string input = Console.ReadLine();
                if (input.ToLower().Equals("quit"))
                {
                    break;
                }
                else if (!numbers.Contains(int.Parse(input)))
                    numbers.Add(int.Parse(input));
            }
            foreach (int number in numbers)
                Console.WriteLine(number);*/


            /*5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). If
                the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
                otherwise, display the 3 smallest numbers in the list.*/


        }
    }
}

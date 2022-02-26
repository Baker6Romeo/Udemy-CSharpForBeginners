using System;

namespace CSharpFundamentals
{
    public class Person
    {
        public String FirstName;
        public String LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}

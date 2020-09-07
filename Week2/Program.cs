using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("My name is, " + Name);
            Console.WriteLine("How old are you?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            Console.WriteLine("You were born in " + Age);
        }
    }
}

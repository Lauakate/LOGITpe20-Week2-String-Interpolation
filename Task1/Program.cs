using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            string UserInput;

            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();
            Console.WriteLine("When were you born?");
            UserInput = Console.ReadLine();
            int Year;
            Year = Int32.Parse(UserInput);
            int Age = 2020 - Year;

            Console.WriteLine($"Greetings {FirstName} {LastName}, Age {Age}");



        }
    }
}

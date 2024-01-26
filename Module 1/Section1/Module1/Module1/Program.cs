// See https://aka.ms/new-console-template for more information
using System;
namespace Survey{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the survey");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            Console.WriteLine("What month were you born in?");
            string month = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            
            Console.WriteLine("What is your favorite sport?");
            string sport = Console.ReadLine();



            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your birth month is " + month);
            Console.WriteLine("Your favorite food is " + food);
            Console.WriteLine("Your favorite sport is " + sport);
            Console.WriteLine("Press any key to exit");

        }
    }
}
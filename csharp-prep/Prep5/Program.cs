using System;

class Program
{
        static void Main(string[] args)
        {
            DisplayWelcome();
            string name = PromptUserName();
            int favorite_number = PromptUserNumber();
            int birth_year = PromptUserBirthYear();
            double squared = SquareNumber(favorite_number);
            DisplayResult(name, squared, birth_year);


        }    
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        static int PromptUserBirthYear()
        {
            Console.Write("Please enter the year you were born: ");
            return int.Parse(Console.ReadLine());
        }

        static double SquareNumber(int number)
        {
            double squared = Math.Pow(number, 2);
            return squared;
        }
        static void DisplayResult(string name, double squared, int year)
        {
            int age = 2026 - year;
            Console.WriteLine($"{name}, the square of your number is {squared}.");
            Console.WriteLine($"{name}, you will turn {age} this year.");
        }

}
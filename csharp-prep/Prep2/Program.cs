using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        float grade = float.Parse(Console.ReadLine());
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";    
        }
        else if (grade >= 70)
        {
            letter = "C";    
        }
        else if (grade >= 60)
        {
            letter = "D";    
        }      
        else if (grade < 60)
        {
            letter = "F";    
        }  

        Console.WriteLine($"Your letter grade is {letter}"); 
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry! Better luck next time!");
        }

    }
}
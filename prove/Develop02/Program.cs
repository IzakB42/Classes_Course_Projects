using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());
        Journal newJournal = new Journal();

        do
        {
        // include a while loop that brings up the menu choices after the readlines 
        // as long as the choice isn't 5. Might be easiest to make the menu a function.
            if (choice == 1)
            {
                // DateTime date1 = DateTime.Now;
                Entry newEntry = new Entry();
                newEntry.WriteEntry();
                
                newJournal.AddEntry();
            // Display Random Prompt and run NewEntry function
            }

            if (choice == 2)
            {
                newJournal.DisplayJournal();
            }

            if (choice == 3)
            {
            // Run LoadJournal from ReadFiles class
            }

            if (choice == 4)
            {
            // run SaveJournal from ReadFiles class
            }

            else
            {
                Console.Write("Try again, just input the number of the what you would like to do: ");
            }
        }while(choice!=5);
    }
}
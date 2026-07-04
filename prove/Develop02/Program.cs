using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        Journal newJournal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry newEntry = new Entry();
                newEntry.WriteEntry();
                
                newJournal.AddEntry(newEntry);
                // Don't need to pass in a variable, can pass in the class instead since writeEntry updates the variables.
            }

            else if (choice == 2)
            {
                newJournal.DisplayJournal();
            }

            else if (choice == 3)
            {
            // Run LoadJournal from ReadFiles class
            }

            else if (choice == 4)
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
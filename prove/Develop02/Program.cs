using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        Journal newJournal = new Journal();
        string file = "";

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
                // Don't need to pass in a variable, can pass in the class 
                // instead since writeEntry updates the variables.
            }

            else if (choice == 2)
            {
                newJournal.DisplayJournal();
            }

            else if (choice == 3)
            {
                newJournal.ReadFiles(file);
            }

            else if (choice == 4)
            {
                Console.WriteLine("Where would you like to save this to? (type filename):");
                file = Console.ReadLine();
                newJournal.SaveJournal(file);
            }

            else
            {
                if (choice==5)
                {
                    Console.WriteLine("Have a good day!");
                }
                else
                {
                    Console.Write("Try again, just input the number of the what you would like to do: ");
                }
            }
        }while(choice!=5);
    }
}
using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        while (true)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load from text");
            Console.WriteLine("4. Load from JSON");
            Console.WriteLine("5. Save as text");
            Console.WriteLine("6. Save as JSON");
            Console.WriteLine("7. Quit");
            Console.Write("");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry anEntry = theJournal.CreateNewEntry();
                theJournal.AddEntry(anEntry);
            }

            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                theJournal.LoadFromFile();
            }

            else if (choice == "4")
            {
                theJournal.LoadFromJson();
            }

            else if (choice == "5")
            {
                theJournal.SaveToFile();
            }

            else if (choice == "6")
            {
                theJournal.SaveAsJson();
            }

            else if (choice == "7")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("This option is not valid");
            }
        }
    }
}
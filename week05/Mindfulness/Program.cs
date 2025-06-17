using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start To do activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Console.Clear();

            if (choice == "1")
            {

                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. ChecklistGoal");
                Console.Write("Which type of goal would you like to create: ");
                string Select = Console.ReadLine();

            }

            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }

            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }

            else if (choice == "4")
            {
                ToDoActivity toDoList = new ToDoActivity();
                toDoList.Run();
            }

            else if (choice == "5")
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
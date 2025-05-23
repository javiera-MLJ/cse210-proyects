using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = null;
        Scripture hymn = null;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture or hymn Memorizer!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Memorize a scripture");
            Console.WriteLine("2. Memorize a hymn");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Console.Write("Enter the book of the scripture: ");
                string book = Console.ReadLine();

                Console.Write("Enter the chapter: ");
                int chapter = int.Parse(Console.ReadLine());

                Console.Write("Enter the starting verse: ");
                int verse = int.Parse(Console.ReadLine());

                Console.Write("Enter the ending verse: (or 0 if it's just one verse) ");
                int endVerse = int.Parse(Console.ReadLine());

                Reference reference = (endVerse == 0) ?
                    new Reference(book, chapter, verse) :
                    new Reference(book, chapter, verse, endVerse);

                Console.Write("Enter the scripture text: ");
                string scriptureText = Console.ReadLine();

                scripture = new Scripture(reference, scriptureText);


                while (!scripture.IsCompletelyHidden())
                {
                    {
                        Console.Clear();
                        Console.WriteLine(scripture.getDisplayText());
                        Console.WriteLine("\nPress Enter to hide more words or type 'quit' to stop.");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "quit")
                            break;

                        scripture.HideRandomWords(2);
                    }
                }
                Console.Clear();
                Console.WriteLine(scripture.getDisplayText());
                Console.WriteLine("\nPress Enter to Finish.");
                Console.ReadLine();
            }

            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("Enter the hymn text: ");
                string hymnText = Console.ReadLine();
                hymn = new Scripture(hymnText);

                while (!hymn.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(hymn.getDisplayText());
                    Console.WriteLine("\nPress Enter to hide more words or type 'quit' to stop.");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "quit")
                        break;

                    hymn.HideRandomWords(2);
                }
                Console.Clear();
                Console.WriteLine(hymn.getDisplayText());
                Console.WriteLine("\nPress Enter to Finish.");
                Console.ReadLine();
            }

            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Scripture or hymn Memorizer!");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadLine();
            }
            Console.Clear();
        }
    }
}
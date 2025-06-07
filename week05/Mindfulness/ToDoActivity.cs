public class ToDoActivity : Activity
{
    private List<string> _chores = new List<string>();

    public ToDoActivity()
    {
        _name = "To Do";
        _description = "This activity helps you get better organized with a to-do list so you don't forget anything and have it recorded.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nThink about what things you need to do today:");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        GetListFromUser();
        Console.Clear();

        Console.WriteLine("\nYou wrote the following to-do items:");
        foreach (var chore in _chores)
        {
            Console.WriteLine($"- {chore}");
        }

        Console.WriteLine();
        Console.WriteLine("\nWhen you finish your tasks, press Enter to continue");
        Console.ReadLine();
        DisplayEndingMessage();
    }

    private void GetListFromUser()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                _chores.Add(item);
            }
        }
    }
}
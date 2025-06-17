public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                
                case "7": running = false; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("the goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("the goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine("\npress Enter to continue");
        Console.ReadLine();
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.WriteLine("what is the name of your goal?");
        string n = Console.ReadLine();
        Console.WriteLine("what is a short description of it?");
        string d = Console.ReadLine();
        Console.WriteLine("what is the amount of points associated with this goal?");
        int p = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(n, d, p));
                break;
            case "2":
                _goals.Add(new EternalGoal(n, d, p));
                break;
            case "3":
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(n, d, p, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid option.");
                Console.WriteLine("\npress Enter to continue");
                Console.ReadLine();
                break;
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine();
        if (index >= 0 && index < _goals.Count)
        {
            var selectedGoal = _goals[index];
            selectedGoal.RecordEvent();

            _score += selectedGoal._points;

            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal._bonus;
            }

            Console.WriteLine($"You now have {_score} points!");
            Console.WriteLine("\npress Enter to continue");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
            Console.WriteLine("\npress Enter to continue");
            Console.ReadLine();
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamWriter outputFile = new StreamWriter(filename, append: true))
            {
                outputFile.WriteLine($"Score:{_score}");
                foreach (var goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals saved successfully.");
            Console.WriteLine("\npress Enter to continue");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("File does not exist.");
            Console.WriteLine("\npress Enter to continue");
            Console.ReadLine();
        }
    }
    
    public void LoadGoals()
    {
        Console.Write("What is the filename: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();
            string[] lines = System.IO.File.ReadAllLines(filename);

            string[] scoreLine = lines[0].Split(':');
            if (scoreLine[0] == "Score")
            {
                _score = int.Parse(scoreLine[1]);
            }
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(":");
                string type = parts[0];
                string[] data = parts[1].Split(",");


                switch (type)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(
                            data[0],
                            data[1],
                            int.Parse(data[2]),
                            int.Parse(data[4]),
                            int.Parse(data[3])
                        ));
                        break;
                }
            }
            Console.WriteLine("Goals and score loaded successfully.");
            Console.WriteLine("\npress Enter to continue");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("File does not exist.");
            Console.WriteLine("\npress Enter to continue");
            Console.ReadLine();
        }
    }
}
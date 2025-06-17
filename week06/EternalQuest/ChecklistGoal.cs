public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    public int _bonus { get; }

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Congratulations! You have earned {_points} points");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Goal completed, you earned {_bonus} extra points");
            }
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}"; 
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Currently complete {_amountCompleted}/{_target}";
    }
}
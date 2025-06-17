public abstract class Goal
{
    public string _shortName { get; }
    protected string _description;
    public int _points { get; }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})"; 
    }
    public abstract string GetStringRepresentation();
}
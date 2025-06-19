using System.Xml;

public abstract class Activity
{
    private DateTime _date;
    public double _minutes { get; set; }

    public Activity(DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $" {_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} km/h, Pace: {GetPace():0.0} min per km";
    }
}
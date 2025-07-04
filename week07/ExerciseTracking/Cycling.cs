public class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime date, double minutes, double speed) : base( date, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * (_minutes / 60.0);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}
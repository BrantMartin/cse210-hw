public class Running : Activity
{
    protected double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double getDistance()
    {
        return _distance;
    }

    public override double getSpeed()
    {
        return _distance / _length * 60;
    }

    public override double getPace()
    {
        return _length / _distance;
    }

    public override void getSummary()
    {
        Console.WriteLine($"{getDate()} Running ({getLength()})- Distance: {getDistance()} miles, Speed: {getSpeed()} mph, Pace: {getPace()} min per mile");
    }
}
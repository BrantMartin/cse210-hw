public class Swimming : Activity
{
    protected double _laps;

    public Swimming(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double getDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double getSpeed()
    {
        return getDistance() / _length * 60;
    }

    public override double getPace()
    {
        return 60 / getSpeed();
    }

    public override void getSummary()
    {
        Console.WriteLine($"{getDate()} /swimming ({getLength()})- Distance: {getDistance()} miles, Speed: {getSpeed()} mph, Pace: {getPace()} min per mile");
    }
}
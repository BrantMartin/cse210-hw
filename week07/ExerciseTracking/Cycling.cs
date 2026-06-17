public class Cycling : Activity
{
    protected double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double getDistance()
    {
        return _speed * (_length / 60);
    }

    public override double getSpeed()
    {
        return getDistance() / _length * 60;
    }

    public override double getPace()
    {
        return 60 / _speed;
    }

    public override void getSummary()
    {
        Console.WriteLine($"{getDate()} Cycling ({getLength()})- Distance: {getDistance()} miles, Speed: {getSpeed()} mph, Pace: {getPace()} min per mile");
    }
}
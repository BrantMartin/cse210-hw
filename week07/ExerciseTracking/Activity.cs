public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string getDate()
    {
        return _date;
    }

    public int getLength()
    {
        return _length;
    }

    public abstract double getDistance();

    public abstract double getSpeed();

    public abstract double getPace();
    
    public abstract void getSummary();
}
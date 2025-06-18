public class Running : Activity
{
    private float _distance;

    public Running(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed()
    {
        return (_distance / _length) * 60;
    }
    public override float GetPace()
    {
        return _length / _distance;
    }
}
public class Swimming : Activity
{
    private float _laps;

    public Swimming(string date, int length, float laps) : base(date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return (_laps * 50f) / 1000f;
    }
    public override float GetSpeed()
    {
        return GetDistance() / (_length / 60f);
    }
    public override float GetPace()
    {
        return 60f / GetSpeed();
    }
}
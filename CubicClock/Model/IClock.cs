namespace CubicClock.Model
{
    public interface IClock
    {
        void Attach(IClockEvents presenter);
        void Update();
        void Start();
    }
}
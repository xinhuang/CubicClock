namespace CubicClock.Model
{
    public interface IClockEvents
    {
        int Hour { set; }
        int Minute { set; }
        int Second { set; }
    }
}
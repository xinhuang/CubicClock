namespace CubicClock.View
{
    public interface IView
    {
        Presenter Presenter { set; }
        int Hour { get; set; }
        int Minute { get; set; }
    }
}
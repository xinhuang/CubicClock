namespace CubicClock
{
    public interface IView
    {
        Presenter Presenter { set; }
        int Hour { get; set; }
    }
}
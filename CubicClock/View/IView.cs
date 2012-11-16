namespace CubicClock.View
{
    public interface IView
    {
        Presenter Presenter { set; }
        int Hour { set; }
        int Minute { set; }
    }
}
namespace CubicClock.View
{
    public interface IViewEvents
    {
        void OnRefresh();
        void OnExit();
        void OnTopMostCheckChanged(bool value);
    }
}
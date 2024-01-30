namespace DesignPatterns.ObserverPattern.Interfaces
{
    public interface ISubject
    {
        string AddObserver(IObserver observer);
        string RemoveObserver(IObserver observer);
        string NotifyObservers();
        string IncreaseNumber(int multiplier);
    }
}

namespace DesignPatterns.ObserverPattern.Interfaces
{
    public interface IObserver
    {
        string Update(ISubject subject);
    }
}

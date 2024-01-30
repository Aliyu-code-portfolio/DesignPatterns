using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.ObserverPattern.Implementation
{
    public class Subject : ISubject
    {
        private List<IObserver> observers;
        public int Number { get; set; }=1;

        public Subject(List<IObserver> observers)
        {
            this.observers = observers;
        }

        public string AddObserver(IObserver observer)
        {
            Console.WriteLine("Adding an observer");
            observers.Add(observer);
            return "Observer added";
        }

        public string IncreaseNumber(int multiplier)
        {
            Console.WriteLine("Changing the value of Number");
            Number*=multiplier;
            var message = $"Number is now {Number}\n";
            message += NotifyObservers();
            return message;
        }

        public string NotifyObservers()
        {
            string messages ="Notifying all observers of the change\n";
            foreach (IObserver observer in observers)
            {
                messages += observer.Update(this)+"\n";
            }
            return messages;
        }

        public string RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
            return "Observer removed";
        }

    }
}

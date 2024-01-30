using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.ObserverPattern.Implementation
{
    public class EvenNumberObserver : IObserver
    {
        public string Update(ISubject subject)
        {
            var message = string.Empty;
            if((subject as Subject).Number % 2 == 0)
            {
                message = "EvenObserver got the new value of Number\nThe new Number is an even number";
            }
            else
            {
                message = "EvenObserver got the update, it is not an even number";
            }
            return message;
        }
    }
}

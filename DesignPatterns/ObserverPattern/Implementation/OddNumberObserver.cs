using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.ObserverPattern.Implementation
{
    public class OddNumberObserver : IObserver
    {
        public string Update(ISubject subject)
        {
            string message = string.Empty;
            if((subject as Subject).Number % 2==1)
            {
                message = "OddObserver got the new value of Number\nThe new Number is an odd number";
            }
            else
            {
                message = "OddObserver got the update, it is not an odd number";
            }
            return message;
        }
    }
}

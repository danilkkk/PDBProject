using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PDBProject1
{
    public class Countdown : ISubject
    {
        public string message { get; private set; } = "И мне очень жалко людей, которые покупают доллар за 35 рублей, потому что вероятность, что они потеряют свои деньги, — большая";

        private List<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber observer)
        {
            subscribers.Add(observer);
        }
        public void Unsubscribe(ISubscriber observer)
        {
            subscribers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in subscribers)
            {
                observer.Update(this);
            }
        }
        public void SendMessagesWithDelay(string message, int delay)
        {
            this.message = message;
            Thread.Sleep(1000 * delay);
            Notify();
        }

        public void SendMessagesWithDelay(int delay)
        {
            Thread.Sleep(1000 * delay);
            Notify();
        }
    }
}

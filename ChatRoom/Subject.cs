using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    public class Subject
    {
        List<Observer> observers = new List<Observer>();
        public void Subscribe(Observer observer)
        {
            this.observers.Add(observer);
        }
        public void Unsubscribe(Observer observer)
        {
            this.observers.Remove(observer);
        }
        public void Notify(ReceiveData message)
        {
            foreach (var observer in this.observers)
            {
                observer.Update(message);
            }
        }
    }
}

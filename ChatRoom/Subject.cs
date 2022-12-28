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
        public void Notify(List<Room> rooms, ReceiveData message)
        {
            foreach (var observer in this.observers)
            {
                observer.SendPrivate(rooms, message);
            }
        }

        public void ChangeRoom(string roomName)
        {
            foreach (var observer in this.observers)
            {
                observer.ChangeRoom(roomName);
            }
        }
        public void UpdateUsers(List<User> usersList)
        {
            foreach (var observer in this.observers)
            {
                observer.UpdateUsers(usersList);
            }
        }
        public void UpdateUsers(List<User> userList, List<Room> rooms)
        {
            foreach (var observer in this.observers)
            {
                observer.UpdateUsers(userList, this, rooms);
            }
        }

        public void UpdateRoomList(List<Room> rooms, ReceiveData data)
        {
            foreach (var observer in this.observers)
            {
                observer.UpdateRoomList(rooms, data);
            }
        }

    }
}

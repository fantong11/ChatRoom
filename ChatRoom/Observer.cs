using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    public abstract class Observer
    {
        public abstract void Update(ReceiveData message);
        public abstract void Update(Room room);
        public abstract void UpdateUsers(List<User> usersList);
        public abstract void UpdateUsers(List<User> usersList, Subject subject, List<Room> rooms);
        public abstract void ChangeRoom(string roomName);
        public abstract void UpdateRoomList(List<Room> rooms, ReceiveData message);
        public abstract void SendPrivate(List<Room> rooms, ReceiveData message);
    }
}

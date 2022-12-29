using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    public abstract class Observer
    {
        public abstract void UpdateMessage(ReceiveData message);
        public abstract void UpdateUsers(List<User> usersList);
        public abstract void ChangeRoom(string roomName);
        public abstract void UpdateRoomList(List<Room> rooms);
    }
}

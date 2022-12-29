using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    public class Room
    {
        public string roomName;
        public List<ReceiveData> messagesList = new List<ReceiveData>();

        public Room(ReceiveData data)
        {
            this.roomName = data.roomName;
        }

        public Room(string roomName)
        {
            // For create private room
            this.roomName = roomName;
        }

        public void AddMessage(ReceiveData data)
        {
            this.messagesList.Add(data);
            Console.WriteLine("This data is added to message list: ");
            Console.WriteLine(data.ToString());
        }
    }
}

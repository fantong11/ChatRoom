using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    public class SendData
    {
        public CommandType command { get; set; }
        public MessageData messageData { get; set; }

    }
    public class MessageData 
    {
        public string username { get; set; }
        public string message { get; set; }
        public string roomName { get; set; }
        public string recipientName { get; set; }
    }

    public enum CommandType
    {
        Join,
        Leave,
        SendPrivate,
        SendPublic,
        Connect,
        CreatePrivateRoom,
        UpdateUserList,
    }
}

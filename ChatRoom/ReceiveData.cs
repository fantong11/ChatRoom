using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    public class ReceiveData
    {
        public string username { get; set; }
        public string message { get; set; }
        public string roomName { get; set; }
        public string recipientName { get; set; }
    }
}

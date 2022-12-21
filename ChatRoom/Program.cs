using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoom
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ChatRoomClient client = new ChatRoomClient("ws://localhost:3030");
            Application.Run(new WelcomeForm(client));
        }
    }
}

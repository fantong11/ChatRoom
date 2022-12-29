using System;
using System.Windows.Forms;
using dotenv.net;

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
            DotEnv.Load();
            var envVars = DotEnv.Read();

            ChatRoomClient client = new ChatRoomClient("ws://" + envVars["PORT"]);
            Application.Run(new WelcomeForm(client));
        }
    }
}

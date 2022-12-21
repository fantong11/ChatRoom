using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    internal class WelcomeFormController
    {
        ChatRoomClient chatRoomClient;
        WelcomeForm welcomeForm;
        public WelcomeFormController(WelcomeForm welcomeForm, ChatRoomClient chatRoomClient)
        {
            this.chatRoomClient = chatRoomClient;
            this.welcomeForm = welcomeForm;
        }

        public void EnterChatRoom()
        {
            this.chatRoomClient.SetUsername(this.welcomeForm.userNameTextBox.Text);

            chatRoomClient.Connect();
            SendData sendData = new SendData
            {
                command = CommandType.Connect,
                messageData = new MessageData
                {
                    username = this.chatRoomClient.GetUsername(),
                    message = "",
                    roomName = "",
                    recipientName = ""
                }
            };
            this.chatRoomClient.Send(sendData);

            ChatRoomForm chatRoomForm = new ChatRoomForm(this.chatRoomClient);

            this.welcomeForm.Hide();
            chatRoomForm.Show();
        }
    }
}

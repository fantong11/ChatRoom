using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChatRoom
{
    internal class ChatRoomController : Observer
    {
        ChatRoomClient chatRoomClient;
        ChatRoomForm chatRoomForm;
        Subject subject;

        public ChatRoomController(ChatRoomForm chatRoomForm, ChatRoomClient chatRoomClient, Subject subject)
        {
            this.chatRoomClient = chatRoomClient;
            this.chatRoomForm = chatRoomForm;
            this.subject = subject;
            subject.Subscribe(this);

            chatRoomForm.MeRichTextBox.Text = chatRoomClient.GetUsername();
        }

        public override void Update(ReceiveData data)
        {
            this.chatRoomForm.Invoke((MethodInvoker)delegate
            {
                this.chatRoomForm.chatFlowLayoutPanel.Controls.Add(new ChatBubble(data));
            });
        }

        public override void UpdateUsers(List<User> usersList)
        {
            this.chatRoomForm.Invoke((MethodInvoker)delegate
            {
                this.chatRoomForm.usersListFlowLayoutPanel.Controls.Clear();
                
                foreach (User user in usersList)
                {
                    this.chatRoomForm.usersListFlowLayoutPanel.Controls.Add(new OnlineUser(user));
                }
            });
            
        }

        public void Send()
        {
            SendData sendData = new SendData
            {
                command = CommandType.SendPublic,
                messageData = new MessageData
                {
                    username = this.chatRoomClient.GetUsername(),
                    message = this.chatRoomForm.chatRichTextBox.Text,
                    roomName = "",
                    recipientName = ""
                }
            };
            this.chatRoomClient.Send(sendData);
            this.chatRoomForm.chatRichTextBox.Text = "";
        }
    }
}

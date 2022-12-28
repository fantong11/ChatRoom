using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using System.Xml.Linqs;
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
        List<Room> rooms;

        public ChatRoomController(ChatRoomForm chatRoomForm, ChatRoomClient chatRoomClient, Subject subject, List<Room> rooms)
        {
            this.chatRoomClient = chatRoomClient;
            this.chatRoomForm = chatRoomForm;
            this.subject = subject;
            this.rooms = rooms;

            subject.Subscribe(this);

            chatRoomForm.MeRichTextBox.Text = chatRoomClient.GetUsername();
        }

        public override void Update(ReceiveData data)
        {
            this.chatRoomForm.Invoke((MethodInvoker)delegate
            {
                // new ChatBubble(data, subject);
                // pass the variable "subject" to let the clicking on user call "ChangeRoom" method
                this.chatRoomForm.chatFlowLayoutPanel.Controls.Add(new ChatBubble(data));
            });
        }

        public override void Update(Room room)
        {
            this.chatRoomForm.Invoke((MethodInvoker)delegate
            {
                /*
                this.chatRoomForm.chatFlowLayoutPanel.Controls.Clear();
                if (room.messagesList != null)
                {
                    foreach (ReceiveData data in room.messagesList)
                    {
                        this.chatRoomForm.chatFlowLayoutPanel.Controls.Add(new ChatBubble(data));
                    }
                }
                */
            });
        }

        public override void UpdateUsers(List<User> usersList)
        {
            this.chatRoomForm.Invoke((MethodInvoker)delegate
            {
                this.chatRoomForm.usersListFlowLayoutPanel.Controls.Clear();
                
                foreach (User user in usersList)
                {
                    this.chatRoomForm.usersListFlowLayoutPanel.Controls.Add(new OnlineUser(user, subject));
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

        public void SendPrivate()
        {
            SendData sendData = new SendData
            {
                command = CommandType.SendPrivate,
                messageData = new MessageData
                {
                    username = this.chatRoomClient.GetUsername(),
                    message = this.chatRoomForm.chatRichTextBox.Text,
                    roomName = "2",
                    recipientName = "2"
                }
            };
            this.chatRoomClient.Send(sendData);
            this.chatRoomForm.chatRichTextBox.Text = "";
        }

        public override void UpdateUsers(List<User> usersList, Subject subject, List<Room> rooms)
        {
            throw new NotImplementedException();
        }

        public override void ChangeRoom(string roomName)
        {
            this.chatRoomForm.Invoke((MethodInvoker)delegate
            {
                this.chatRoomForm.chatFlowLayoutPanel.Controls.Clear();
                this.chatRoomForm.SetPrivate(true);

                foreach (var room in rooms)
                {
                    if (roomName == room.roomName)
                    {
                        foreach (var data in room.messagesList)
                        {
                            this.chatRoomForm.chatFlowLayoutPanel.Controls.Add(new ChatBubble(data));
                        }
                    }
                }
            });
        }

        public override void UpdateRoomList(List<Room> rooms, ReceiveData message)
        {
            this.chatRoomForm.Invoke((MethodInvoker)delegate
            {
                Room room = new Room(message);
                rooms.Add(room);
            });
        }

        public override void SendPrivate(List<Room> rooms, ReceiveData message)
        {
            throw new NotImplementedException();
        }
    }
}

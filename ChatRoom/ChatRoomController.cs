using System;
using System.Collections.Generic;
using System.Windows.Forms;
// using System.Xml.Linqs;

namespace ChatRoom
{
    internal class ChatRoomController : Observer
    {
        ChatRoomClient chatRoomClient;
        ChatRoomForm chatRoomForm;
        Subject subject;
        List<Room> rooms;
        string username;

        public ChatRoomController(ChatRoomForm chatRoomForm, ChatRoomClient chatRoomClient, Subject subject)
        {
            subject.Subscribe(this);
            this.chatRoomClient = chatRoomClient;
            this.chatRoomForm = chatRoomForm;
            this.subject = subject;
            this.rooms = chatRoomClient.GetRooms();
            chatRoomForm.MeRichTextBox.Text = chatRoomClient.GetUsername();
            username = chatRoomClient.GetUsername();
        }

        public override void UpdateMessage(ReceiveData data)
        {
            // public
            if (data.command == 3)
            {
                FindRoom("大廳").AddMessage(data);
            }
            // private
            else if (data.command == 2)
            {
                // by me
                if (data.username == this.username)
                {
                    Room room = FindRoom(data.recipient);
                    room.AddMessage(data);
                }
                // by other
                else
                {
                    Room room = FindRoom(data.username);
                    if (room != null)
                    {
                        room.AddMessage(data);
                    }
                    else
                    {
                        AddRoom(data.username, data);
                    }
                }
            }
            UpdateMessageListUI();
        }
        public void AddRoom(string roomName)
        {
            Room room = new Room(roomName);
            this.rooms.Add(room);
            UpdateRoomList(this.rooms);
        }
        public void AddRoom(string roomName, ReceiveData data)
        {
            Room room = new Room(roomName);
            this.rooms.Add(room);
            UpdateRoomList(this.rooms);
            room.AddMessage(data);
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

        public void SendPublic()
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
            SendData sendData;
            sendData = new SendData
            {
                command = CommandType.CreatePrivateRoom,
                messageData = new MessageData
                {
                    username = this.chatRoomClient.GetUsername(),
                    message = "",
                    roomName = "",
                    recipientName = this.chatRoomForm.currentRoom
                }
            };

            if (FindRoom(this.chatRoomForm.currentRoom) == null)
            {
                AddRoom(this.chatRoomForm.currentRoom);
                Console.WriteLine("Send Create Private Room");
                this.chatRoomClient.Send(sendData);
            }
            Console.WriteLine("Send Private");
            sendData.command = CommandType.SendPrivate;
            sendData.messageData.message = this.chatRoomForm.chatRichTextBox.Text;
            this.chatRoomClient.Send(sendData);
            this.chatRoomForm.chatRichTextBox.Text = "";
        }

        public override void ChangeRoom(string roomName)
        {
            if (roomName == username)
            {
                roomName = "大廳";
            }
            // change the form behavior when click_send (Lobby or private)
            this.chatRoomForm.SetRoom(roomName);
            if (FindRoom(roomName) != null)
            {
                UpdateMessageListUI();
            }
            else
            {
                this.chatRoomForm.Invoke((MethodInvoker)delegate
                {
                    this.chatRoomForm.chatFlowLayoutPanel.Controls.Clear();
                });
            }
        }
        public Room FindRoom(string roomName)
        {
            foreach (Room room in this.rooms)
            {
                if (room.roomName == roomName)
                {
                    return room;
                }
            }
            return null;
        }
        ///
        public void UpdateMessageListUI()
        {
            Room room = FindRoom(this.chatRoomForm.currentRoom);
            this.chatRoomForm.Invoke((MethodInvoker)delegate
            {
                this.chatRoomForm.chatFlowLayoutPanel.Controls.Clear();
                if (room.messagesList.Count > 0)
                {
                    foreach (ReceiveData data in room.messagesList)
                    {
                        this.chatRoomForm.chatFlowLayoutPanel.Controls.Add(new ChatBubble(data));
                    }
                }
                this.chatRoomForm.chatFlowLayoutPanel.VerticalScroll.Value = this.chatRoomForm.chatFlowLayoutPanel.VerticalScroll.Maximum;
                this.chatRoomForm.chatFlowLayoutPanel.PerformLayout();
            });
        }

        public override void UpdateRoomList(List<Room> rooms)
        {
            Console.WriteLine("Update Room List");
            this.chatRoomForm.Invoke((MethodInvoker)delegate
            {
                this.chatRoomForm.roomFlowLayoutPanel.Controls.Clear();
                foreach (Room room in this.rooms)
                {
                    this.chatRoomForm.roomFlowLayoutPanel.Controls.Add(new RoomUI(room.roomName, subject));
                }
            });
        }
    }
}

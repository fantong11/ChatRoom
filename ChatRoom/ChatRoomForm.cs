using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoom
{
    public partial class ChatRoomForm : Form
    {
        ChatRoomController controller;
        Subject subject = new Subject();
        public string currentRoom;

        public ChatRoomForm(ChatRoomClient chatRoomClient)
        {
            InitializeComponent();
            this.currentRoom = "大廳";
            roomNameLabel.Text = "大廳";
            chatRoomClient.SetSubject(this.subject);
            this.controller = new ChatRoomController(this, chatRoomClient, this.subject);
            roomFlowLayoutPanel.Controls.Add(new RoomUI("大廳", this.subject));
        }

        public void SetRoom(string roomName)
        {
            this.currentRoom = roomName;
            roomNameLabel.Text = roomName;
        }

        private void ChatRoomForm_Load(object sender, EventArgs e)
        {
            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (this.currentRoom == "大廳")
                this.controller.SendPublic();
            else
                this.controller.SendPrivate();
        }

        private void ChatRoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ChatRoomForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(sender, null);
            }
        }
    }
}

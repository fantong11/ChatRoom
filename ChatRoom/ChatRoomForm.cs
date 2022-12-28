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
        public bool isPrivate;

        public ChatRoomForm(ChatRoomClient chatRoomClient)
        {
            InitializeComponent();
            this.isPrivate = false;
            chatRoomClient.SetSubject(this.subject);
            this.controller = new ChatRoomController(this, chatRoomClient, subject, chatRoomClient.GetRooms());
        }

        public void SetPrivate(bool value)
        {
            this.isPrivate = value;
        }

        private void ChatRoomForm_Load(object sender, EventArgs e)
        {
            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!this.isPrivate)
                this.controller.Send();
            else
                this.controller.SendPrivate();
        }

        private void ChatRoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

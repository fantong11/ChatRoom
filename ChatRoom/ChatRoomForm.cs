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

        public ChatRoomForm(ChatRoomClient chatRoomClient)
        {
            InitializeComponent();
            chatRoomClient.SetSubject(this.subject);
            this.controller = new ChatRoomController(this, chatRoomClient, subject);
        }


        private void ChatRoomForm_Load(object sender, EventArgs e)
        {
            this.controller.AddUser();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            this.controller.Send();
        }

        private void ChatRoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

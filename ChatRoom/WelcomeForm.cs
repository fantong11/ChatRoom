using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;

namespace ChatRoom
{
    public partial class WelcomeForm : Form
    {
        WelcomeFormController controller;
        public WelcomeForm(ChatRoomClient chatRoomClient)
        {
            InitializeComponent();
            this.controller = new WelcomeFormController(this, chatRoomClient);
        }


        private void enterChatButton_Click(object sender, EventArgs e)
        {
            this.controller.EnterChatRoom();
         }
    }
}

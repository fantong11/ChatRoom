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
    public partial class RoomUI : UserControl
    {
        Subject subject;
        public RoomUI(string roomName, Subject subject)
        {
            InitializeComponent();
            roomNameBox.Text = roomName;
            this.subject = subject;
        }

        private void RoomUI_Load(object sender, EventArgs e)
        {

        }

        private void RoomUI_Click(object sender, EventArgs e)
        {
            this.subject.ChangeRoom(roomNameBox.Text);
        }
    }
}

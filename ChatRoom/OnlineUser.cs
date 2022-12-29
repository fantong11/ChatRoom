using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChatRoom
{
    public partial class OnlineUser : UserControl
    {
        Subject subject;
        public OnlineUser(User user, Subject subject)
        {
            InitializeComponent();
            userNameBox.Text = user.name;
            this.subject = subject;
        }

        private void OnlineUser_Load(object sender, EventArgs e)
        {
        }

        private void OnlineUser_Click(object sender, EventArgs e)
        {
            // ChangeRoom will do {isPrivate = true}
            this.subject.ChangeRoom(userNameBox.Text);
        }
    }
}

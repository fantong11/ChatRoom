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
        
        public OnlineUser(User user)
        {
            InitializeComponent();
            userNameBox.Text = user.name;
        }

        private void OnlineUser_Load(object sender, EventArgs e)
        {
        }
    }
}

﻿using System;
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
    public partial class ChatBubble : System.Windows.Forms.UserControl
    {
        public ChatBubble(ReceiveData data)
        {
            InitializeComponent();
            userRichTextBox.Text = data.username;
            chatRichTextBox.Text = data.message;
        }
    }
}

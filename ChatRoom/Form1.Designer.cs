namespace ChatRoom
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.TypePanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.PersonalPanel = new System.Windows.Forms.Panel();
            this.onlineUser2 = new ChatRoom.OnlineUser();
            this.onlineUser1 = new ChatRoom.OnlineUser();
            this.typingBox1 = new ChatRoom.TypingBox();
            this.chatBubble1 = new ChatRoom.ChatBubble();
            this.ChatPanel.SuspendLayout();
            this.TypePanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.PersonalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatPanel
            // 
            this.ChatPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChatPanel.Controls.Add(this.chatBubble1);
            this.ChatPanel.Location = new System.Drawing.Point(190, 10);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(800, 500);
            this.ChatPanel.TabIndex = 0;
            // 
            // TypePanel
            // 
            this.TypePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TypePanel.Controls.Add(this.typingBox1);
            this.TypePanel.Location = new System.Drawing.Point(190, 520);
            this.TypePanel.Name = "TypePanel";
            this.TypePanel.Size = new System.Drawing.Size(800, 90);
            this.TypePanel.TabIndex = 1;
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserPanel.Controls.Add(this.onlineUser1);
            this.UserPanel.Location = new System.Drawing.Point(1000, 10);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(170, 600);
            this.UserPanel.TabIndex = 2;
            // 
            // PersonalPanel
            // 
            this.PersonalPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PersonalPanel.Controls.Add(this.onlineUser2);
            this.PersonalPanel.Location = new System.Drawing.Point(10, 10);
            this.PersonalPanel.Name = "PersonalPanel";
            this.PersonalPanel.Size = new System.Drawing.Size(170, 600);
            this.PersonalPanel.TabIndex = 3;
            // 
            // onlineUser2
            // 
            this.onlineUser2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.onlineUser2.Location = new System.Drawing.Point(8, 14);
            this.onlineUser2.Name = "onlineUser2";
            this.onlineUser2.Size = new System.Drawing.Size(153, 50);
            this.onlineUser2.TabIndex = 0;
            // 
            // onlineUser1
            // 
            this.onlineUser1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.onlineUser1.Location = new System.Drawing.Point(9, 14);
            this.onlineUser1.Name = "onlineUser1";
            this.onlineUser1.Size = new System.Drawing.Size(152, 50);
            this.onlineUser1.TabIndex = 0;
            // 
            // typingBox1
            // 
            this.typingBox1.Location = new System.Drawing.Point(0, 3);
            this.typingBox1.Name = "typingBox1";
            this.typingBox1.Size = new System.Drawing.Size(800, 87);
            this.typingBox1.TabIndex = 0;
            this.typingBox1.Load += new System.EventHandler(this.typingBox1_Load);
            // 
            // chatBubble1
            // 
            this.chatBubble1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chatBubble1.Location = new System.Drawing.Point(26, 29);
            this.chatBubble1.Name = "chatBubble1";
            this.chatBubble1.Size = new System.Drawing.Size(743, 69);
            this.chatBubble1.TabIndex = 0;
            this.chatBubble1.Load += new System.EventHandler(this.chatBubble1_Load);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.PersonalPanel);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.TypePanel);
            this.Controls.Add(this.ChatPanel);
            this.Name = "Form1";
            this.ChatPanel.ResumeLayout(false);
            this.TypePanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.PersonalPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.Panel TypePanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Panel PersonalPanel;
        private TypingBox typingBox1;
        private ChatBubble chatBubble1;
        private OnlineUser onlineUser1;
        private OnlineUser onlineUser2;
    }
}


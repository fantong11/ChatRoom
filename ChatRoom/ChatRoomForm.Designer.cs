namespace ChatRoom
{
    partial class ChatRoomForm
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
            this.TypePanel = new System.Windows.Forms.Panel();
            this.chatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.usersListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chatFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.roomFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MePanel = new System.Windows.Forms.Panel();
            this.MePictureBox = new System.Windows.Forms.PictureBox();
            this.MeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypePanel.SuspendLayout();
            this.MePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TypePanel
            // 
            this.TypePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TypePanel.Controls.Add(this.chatRichTextBox);
            this.TypePanel.Controls.Add(this.sendButton);
            this.TypePanel.Location = new System.Drawing.Point(194, 520);
            this.TypePanel.Name = "TypePanel";
            this.TypePanel.Size = new System.Drawing.Size(791, 90);
            this.TypePanel.TabIndex = 1;
            // 
            // chatRichTextBox
            // 
            this.chatRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chatRichTextBox.Location = new System.Drawing.Point(16, 14);
            this.chatRichTextBox.Name = "chatRichTextBox";
            this.chatRichTextBox.Size = new System.Drawing.Size(701, 60);
            this.chatRichTextBox.TabIndex = 1;
            this.chatRichTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendButton.Location = new System.Drawing.Point(723, 25);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(63, 40);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // usersListFlowLayoutPanel
            // 
            this.usersListFlowLayoutPanel.AutoScroll = true;
            this.usersListFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.usersListFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.usersListFlowLayoutPanel.Location = new System.Drawing.Point(12, 60);
            this.usersListFlowLayoutPanel.Name = "usersListFlowLayoutPanel";
            this.usersListFlowLayoutPanel.Size = new System.Drawing.Size(172, 550);
            this.usersListFlowLayoutPanel.TabIndex = 3;
            this.usersListFlowLayoutPanel.WrapContents = false;
            // 
            // chatFlowLayoutPanel
            // 
            this.chatFlowLayoutPanel.AutoScroll = true;
            this.chatFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chatFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatFlowLayoutPanel.Location = new System.Drawing.Point(194, 60);
            this.chatFlowLayoutPanel.Name = "chatFlowLayoutPanel";
            this.chatFlowLayoutPanel.Size = new System.Drawing.Size(791, 454);
            this.chatFlowLayoutPanel.TabIndex = 4;
            this.chatFlowLayoutPanel.WrapContents = false;
            // 
            // roomFlowLayoutPanel
            // 
            this.roomFlowLayoutPanel.AutoScroll = true;
            this.roomFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.roomFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.roomFlowLayoutPanel.Location = new System.Drawing.Point(996, 123);
            this.roomFlowLayoutPanel.Name = "roomFlowLayoutPanel";
            this.roomFlowLayoutPanel.Size = new System.Drawing.Size(176, 487);
            this.roomFlowLayoutPanel.TabIndex = 5;
            this.roomFlowLayoutPanel.WrapContents = false;
            // 
            // MePanel
            // 
            this.MePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MePanel.Controls.Add(this.MePictureBox);
            this.MePanel.Controls.Add(this.MeRichTextBox);
            this.MePanel.Location = new System.Drawing.Point(996, 10);
            this.MePanel.Name = "MePanel";
            this.MePanel.Size = new System.Drawing.Size(176, 62);
            this.MePanel.TabIndex = 6;
            // 
            // MePictureBox
            // 
            this.MePictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MePictureBox.Location = new System.Drawing.Point(10, 8);
            this.MePictureBox.Name = "MePictureBox";
            this.MePictureBox.Size = new System.Drawing.Size(49, 46);
            this.MePictureBox.TabIndex = 2;
            this.MePictureBox.TabStop = false;
            // 
            // MeRichTextBox
            // 
            this.MeRichTextBox.Enabled = false;
            this.MeRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MeRichTextBox.Location = new System.Drawing.Point(68, 8);
            this.MeRichTextBox.Name = "MeRichTextBox";
            this.MeRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MeRichTextBox.Size = new System.Drawing.Size(96, 31);
            this.MeRichTextBox.TabIndex = 1;
            this.MeRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "在線使用者";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(190, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "目前的聊天室：";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.roomNameLabel.Location = new System.Drawing.Point(338, 18);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(121, 24);
            this.roomNameLabel.TabIndex = 9;
            this.roomNameLabel.Text = "RoomName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(996, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "我的聊天室";
            // 
            // ChatRoomForm
            // 
            this.AcceptButton = this.sendButton;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MePanel);
            this.Controls.Add(this.roomFlowLayoutPanel);
            this.Controls.Add(this.chatFlowLayoutPanel);
            this.Controls.Add(this.usersListFlowLayoutPanel);
            this.Controls.Add(this.TypePanel);
            this.Name = "ChatRoomForm";
            this.Text = "Anonymous Chat Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatRoomForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatRoomForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatRoomForm_KeyDown);
            this.TypePanel.ResumeLayout(false);
            this.MePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel TypePanel;
        public System.Windows.Forms.FlowLayoutPanel usersListFlowLayoutPanel;
        public System.Windows.Forms.FlowLayoutPanel chatFlowLayoutPanel;
        public System.Windows.Forms.FlowLayoutPanel roomFlowLayoutPanel;
        public System.Windows.Forms.RichTextBox chatRichTextBox;
        public System.Windows.Forms.Button sendButton;
        public System.Windows.Forms.Panel MePanel;
        private System.Windows.Forms.PictureBox MePictureBox;
        public System.Windows.Forms.RichTextBox MeRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label label3;
    }
}


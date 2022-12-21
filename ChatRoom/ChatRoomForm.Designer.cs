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
            this.personalFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chatFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MePanel = new System.Windows.Forms.Panel();
            this.MeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MePictureBox = new System.Windows.Forms.PictureBox();
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
            this.TypePanel.Location = new System.Drawing.Point(190, 520);
            this.TypePanel.Name = "TypePanel";
            this.TypePanel.Size = new System.Drawing.Size(800, 90);
            this.TypePanel.TabIndex = 1;
            // 
            // chatRichTextBox
            // 
            this.chatRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chatRichTextBox.Location = new System.Drawing.Point(16, 14);
            this.chatRichTextBox.Name = "chatRichTextBox";
            this.chatRichTextBox.Size = new System.Drawing.Size(701, 60);
            this.chatRichTextBox.TabIndex = 1;
            this.chatRichTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendButton.Location = new System.Drawing.Point(728, 24);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(63, 40);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // personalFlowLayoutPanel
            // 
            this.personalFlowLayoutPanel.AutoScroll = true;
            this.personalFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.personalFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.personalFlowLayoutPanel.Location = new System.Drawing.Point(12, 10);
            this.personalFlowLayoutPanel.Name = "personalFlowLayoutPanel";
            this.personalFlowLayoutPanel.Size = new System.Drawing.Size(172, 600);
            this.personalFlowLayoutPanel.TabIndex = 3;
            this.personalFlowLayoutPanel.WrapContents = false;
            // 
            // chatFlowLayoutPanel
            // 
            this.chatFlowLayoutPanel.AutoScroll = true;
            this.chatFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chatFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatFlowLayoutPanel.Location = new System.Drawing.Point(190, 10);
            this.chatFlowLayoutPanel.Name = "chatFlowLayoutPanel";
            this.chatFlowLayoutPanel.Size = new System.Drawing.Size(800, 504);
            this.chatFlowLayoutPanel.TabIndex = 4;
            this.chatFlowLayoutPanel.WrapContents = false;
            // 
            // userFlowLayoutPanel
            // 
            this.userFlowLayoutPanel.AutoScroll = true;
            this.userFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.userFlowLayoutPanel.Location = new System.Drawing.Point(996, 84);
            this.userFlowLayoutPanel.Name = "userFlowLayoutPanel";
            this.userFlowLayoutPanel.Size = new System.Drawing.Size(176, 526);
            this.userFlowLayoutPanel.TabIndex = 5;
            this.userFlowLayoutPanel.WrapContents = false;
            // 
            // MePanel
            // 
            this.MePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MePanel.Controls.Add(this.MePictureBox);
            this.MePanel.Controls.Add(this.MeRichTextBox);
            this.MePanel.Location = new System.Drawing.Point(996, 10);
            this.MePanel.Name = "MePanel";
            this.MePanel.Size = new System.Drawing.Size(176, 68);
            this.MePanel.TabIndex = 6;
            // 
            // MeRichTextBox
            // 
            this.MeRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MeRichTextBox.Location = new System.Drawing.Point(68, 8);
            this.MeRichTextBox.Name = "MeRichTextBox";
            this.MeRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MeRichTextBox.Size = new System.Drawing.Size(96, 31);
            this.MeRichTextBox.TabIndex = 1;
            this.MeRichTextBox.Text = "";
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
            // ChatRoomForm
            // 
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.MePanel);
            this.Controls.Add(this.userFlowLayoutPanel);
            this.Controls.Add(this.chatFlowLayoutPanel);
            this.Controls.Add(this.personalFlowLayoutPanel);
            this.Controls.Add(this.TypePanel);
            this.Name = "ChatRoomForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatRoomForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatRoomForm_Load);
            this.TypePanel.ResumeLayout(false);
            this.MePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel TypePanel;
        public System.Windows.Forms.FlowLayoutPanel personalFlowLayoutPanel;
        public System.Windows.Forms.FlowLayoutPanel chatFlowLayoutPanel;
        public System.Windows.Forms.FlowLayoutPanel userFlowLayoutPanel;
        public System.Windows.Forms.RichTextBox chatRichTextBox;
        public System.Windows.Forms.Button sendButton;
        public System.Windows.Forms.Panel MePanel;
        private System.Windows.Forms.PictureBox MePictureBox;
        public System.Windows.Forms.RichTextBox MeRichTextBox;
    }
}


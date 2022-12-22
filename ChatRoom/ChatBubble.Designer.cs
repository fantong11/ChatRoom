namespace ChatRoom
{
    partial class ChatBubble
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.chatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.userRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.avatarPictureBox.Location = new System.Drawing.Point(17, 10);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(51, 50);
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // chatRichTextBox
            // 
            this.chatRichTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.chatRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chatRichTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.chatRichTextBox.Location = new System.Drawing.Point(153, 10);
            this.chatRichTextBox.Name = "chatRichTextBox";
            this.chatRichTextBox.Size = new System.Drawing.Size(577, 50);
            this.chatRichTextBox.TabIndex = 1;
            this.chatRichTextBox.Text = "";
            // 
            // userRichTextBox
            // 
            this.userRichTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userRichTextBox.Location = new System.Drawing.Point(74, 22);
            this.userRichTextBox.Name = "userRichTextBox";
            this.userRichTextBox.Size = new System.Drawing.Size(73, 29);
            this.userRichTextBox.TabIndex = 2;
            this.userRichTextBox.Text = "";
            // 
            // ChatBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.userRichTextBox);
            this.Controls.Add(this.chatRichTextBox);
            this.Controls.Add(this.avatarPictureBox);
            this.Name = "ChatBubble";
            this.Size = new System.Drawing.Size(752, 69);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.RichTextBox chatRichTextBox;
        private System.Windows.Forms.RichTextBox userRichTextBox;
    }
}

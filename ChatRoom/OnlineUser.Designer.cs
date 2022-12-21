namespace ChatRoom
{
    partial class OnlineUser
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
            this.userNameBox = new System.Windows.Forms.RichTextBox();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameBox
            // 
            this.userNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameBox.Enabled = false;
            this.userNameBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userNameBox.Location = new System.Drawing.Point(66, 3);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(87, 32);
            this.userNameBox.TabIndex = 0;
            this.userNameBox.Text = "哈囉";
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AvatarPictureBox.Location = new System.Drawing.Point(3, 3);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(57, 57);
            this.AvatarPictureBox.TabIndex = 1;
            this.AvatarPictureBox.TabStop = false;
            // 
            // OnlineUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.AvatarPictureBox);
            this.Controls.Add(this.userNameBox);
            this.Name = "OnlineUser";
            this.Size = new System.Drawing.Size(159, 66);
            this.Load += new System.EventHandler(this.OnlineUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox userNameBox;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
    }
}

namespace ChatRoom
{
    partial class TypingBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.SendPicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendPicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SendPicture);
            this.panel1.Controls.Add(this.UserPicture);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 84);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UserPicture
            // 
            this.UserPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserPicture.Location = new System.Drawing.Point(14, 21);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(42, 43);
            this.UserPicture.TabIndex = 1;
            this.UserPicture.TabStop = false;
            // 
            // SendPicture
            // 
            this.SendPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SendPicture.Location = new System.Drawing.Point(730, 11);
            this.SendPicture.Name = "SendPicture";
            this.SendPicture.Size = new System.Drawing.Size(35, 43);
            this.SendPicture.TabIndex = 2;
            this.SendPicture.TabStop = false;
            this.SendPicture.Click += new System.EventHandler(this.SendPicture_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.richTextBox2);
            this.panel3.Location = new System.Drawing.Point(78, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 84);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(730, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 43);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox2.Location = new System.Drawing.Point(5, 11);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(633, 61);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(727, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 84);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(730, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 43);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox3.Location = new System.Drawing.Point(14, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 43);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // TypingBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "TypingBox";
            this.Size = new System.Drawing.Size(800, 90);
            this.Load += new System.EventHandler(this.TypingBox_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SendPicture;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

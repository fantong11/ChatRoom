namespace ChatRoom
{
    partial class RoomUI
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
            this.roomNameBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // roomNameBox
            // 
            this.roomNameBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.roomNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomNameBox.Enabled = false;
            this.roomNameBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roomNameBox.Location = new System.Drawing.Point(5, 5);
            this.roomNameBox.Margin = new System.Windows.Forms.Padding(5);
            this.roomNameBox.Name = "roomNameBox";
            this.roomNameBox.ReadOnly = true;
            this.roomNameBox.Size = new System.Drawing.Size(141, 37);
            this.roomNameBox.TabIndex = 0;
            this.roomNameBox.Text = "RoomName";
            // 
            // RoomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.roomNameBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RoomUI";
            this.Size = new System.Drawing.Size(165, 51);
            this.Load += new System.EventHandler(this.RoomUI_Load);
            this.Click += new System.EventHandler(this.RoomUI_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox roomNameBox;
    }
}

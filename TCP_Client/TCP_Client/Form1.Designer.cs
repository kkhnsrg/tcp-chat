namespace TCP_Client
{
    partial class fClient
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClient));
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lInf = new System.Windows.Forms.Label();
            this.bSend = new System.Windows.Forms.Button();
            this.bEName = new System.Windows.Forms.Button();
            this.lChat = new System.Windows.Forms.Label();
            this.lEMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbChat
            // 
            this.rtbChat.BackColor = System.Drawing.Color.White;
            this.rtbChat.Location = new System.Drawing.Point(5, 33);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.Size = new System.Drawing.Size(374, 211);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            // 
            // rtbMessage
            // 
            this.rtbMessage.BackColor = System.Drawing.Color.White;
            this.rtbMessage.Location = new System.Drawing.Point(412, 140);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(223, 68);
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(412, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 20);
            this.tbName.TabIndex = 2;
            // 
            // lInf
            // 
            this.lInf.AutoSize = true;
            this.lInf.BackColor = System.Drawing.Color.Transparent;
            this.lInf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lInf.Location = new System.Drawing.Point(408, 9);
            this.lInf.Name = "lInf";
            this.lInf.Size = new System.Drawing.Size(138, 21);
            this.lInf.TabIndex = 3;
            this.lInf.Text = "Input nickname:";
            // 
            // bSend
            // 
            this.bSend.BackColor = System.Drawing.Color.Transparent;
            this.bSend.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSend.Location = new System.Drawing.Point(412, 214);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(134, 30);
            this.bSend.TabIndex = 4;
            this.bSend.Text = "Send message";
            this.bSend.UseVisualStyleBackColor = false;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bEName
            // 
            this.bEName.BackColor = System.Drawing.Color.Transparent;
            this.bEName.CausesValidation = false;
            this.bEName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEName.Location = new System.Drawing.Point(412, 59);
            this.bEName.Name = "bEName";
            this.bEName.Size = new System.Drawing.Size(78, 34);
            this.bEName.TabIndex = 5;
            this.bEName.Text = "Confirm";
            this.bEName.UseVisualStyleBackColor = false;
            this.bEName.Click += new System.EventHandler(this.bEName_Click);
            // 
            // lChat
            // 
            this.lChat.AutoSize = true;
            this.lChat.BackColor = System.Drawing.Color.Transparent;
            this.lChat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lChat.Location = new System.Drawing.Point(1, 9);
            this.lChat.Name = "lChat";
            this.lChat.Size = new System.Drawing.Size(121, 21);
            this.lChat.TabIndex = 6;
            this.lChat.Text = "Chat window:";
            // 
            // lEMessage
            // 
            this.lEMessage.AutoSize = true;
            this.lEMessage.BackColor = System.Drawing.Color.Transparent;
            this.lEMessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEMessage.Location = new System.Drawing.Point(408, 116);
            this.lEMessage.Name = "lEMessage";
            this.lEMessage.Size = new System.Drawing.Size(130, 21);
            this.lEMessage.TabIndex = 7;
            this.lEMessage.Text = "Input message:";
            // 
            // fClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(647, 263);
            this.Controls.Add(this.lEMessage);
            this.Controls.Add(this.lChat);
            this.Controls.Add(this.bEName);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.lInf);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.rtbChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fClient";
            this.Text = "TCP_Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fClient_FormClosing);
            this.Load += new System.EventHandler(this.fClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lInf;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bEName;
        private System.Windows.Forms.Label lChat;
        private System.Windows.Forms.Label lEMessage;
    }
}


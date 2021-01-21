
namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.richTextBxChat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxIp = new System.Windows.Forms.TextBox();
            this.txtBxNickname = new System.Windows.Forms.TextBox();
            this.txtBxPort = new System.Windows.Forms.TextBox();
            this.richTxtBxMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(289, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(289, 34);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(97, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // richTextBxChat
            // 
            this.richTextBxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBxChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.richTextBxChat.HideSelection = false;
            this.richTextBxChat.Location = new System.Drawing.Point(1, 64);
            this.richTextBxChat.Name = "richTextBxChat";
            this.richTextBxChat.ReadOnly = true;
            this.richTextBxChat.Size = new System.Drawing.Size(385, 226);
            this.richTextBxChat.TabIndex = 2;
            this.richTextBxChat.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nickname";
            // 
            // txtBxIp
            // 
            this.txtBxIp.Location = new System.Drawing.Point(12, 24);
            this.txtBxIp.Name = "txtBxIp";
            this.txtBxIp.Size = new System.Drawing.Size(77, 20);
            this.txtBxIp.TabIndex = 6;
            this.txtBxIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxNickname
            // 
            this.txtBxNickname.Location = new System.Drawing.Point(178, 24);
            this.txtBxNickname.Name = "txtBxNickname";
            this.txtBxNickname.Size = new System.Drawing.Size(105, 20);
            this.txtBxNickname.TabIndex = 7;
            this.txtBxNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxPort
            // 
            this.txtBxPort.Location = new System.Drawing.Point(95, 24);
            this.txtBxPort.Name = "txtBxPort";
            this.txtBxPort.Size = new System.Drawing.Size(77, 20);
            this.txtBxPort.TabIndex = 8;
            this.txtBxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTxtBxMessage
            // 
            this.richTxtBxMessage.Location = new System.Drawing.Point(1, 296);
            this.richTxtBxMessage.Name = "richTxtBxMessage";
            this.richTxtBxMessage.Size = new System.Drawing.Size(283, 64);
            this.richTxtBxMessage.TabIndex = 9;
            this.richTxtBxMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(289, 296);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 64);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 362);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.richTxtBxMessage);
            this.Controls.Add(this.txtBxPort);
            this.Controls.Add(this.txtBxNickname);
            this.Controls.Add(this.txtBxIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBxChat);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(403, 401);
            this.MinimumSize = new System.Drawing.Size(403, 401);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.RichTextBox richTextBxChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxIp;
        private System.Windows.Forms.TextBox txtBxNickname;
        private System.Windows.Forms.TextBox txtBxPort;
        private System.Windows.Forms.RichTextBox richTxtBxMessage;
        private System.Windows.Forms.Button btnSend;
    }
}


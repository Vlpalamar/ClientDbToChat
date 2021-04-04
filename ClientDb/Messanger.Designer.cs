
namespace ClientDb
{
    partial class Messanger
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
            this.components = new System.ComponentModel.Container();
            this.Chat_txtBox = new System.Windows.Forms.RichTextBox();
            this.chat_lbl = new System.Windows.Forms.Label();
            this.LogIn_btn = new System.Windows.Forms.Button();
            this.Email_txtBox = new System.Windows.Forms.TextBox();
            this.Password_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reg_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegPassword_txtBox = new System.Windows.Forms.TextBox();
            this.RegEMail_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegName_txtBox = new System.Windows.Forms.TextBox();
            this.Send_txtBox = new System.Windows.Forms.TextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.Users_listBox = new System.Windows.Forms.ListBox();
            this.SendToGroupChat_btn = new System.Windows.Forms.Button();
            this.GroupChatText_TxtBox = new System.Windows.Forms.TextBox();
            this.GroupChat = new System.Windows.Forms.RichTextBox();
            this.GroupChatMembers_listBox = new System.Windows.Forms.ListBox();
            this.AddToGroupChat_bttn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveFromeGroupList_bttn = new System.Windows.Forms.Button();
            this.BlackList_listBox = new System.Windows.Forms.ListBox();
            this.RemoveFromeBlackList_Bttn = new System.Windows.Forms.Button();
            this.AddToBlackList_bttn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Chat_txtBox
            // 
            this.Chat_txtBox.Enabled = false;
            this.Chat_txtBox.Location = new System.Drawing.Point(38, 185);
            this.Chat_txtBox.Name = "Chat_txtBox";
            this.Chat_txtBox.Size = new System.Drawing.Size(320, 198);
            this.Chat_txtBox.TabIndex = 0;
            this.Chat_txtBox.Text = "";
            // 
            // chat_lbl
            // 
            this.chat_lbl.AutoSize = true;
            this.chat_lbl.Location = new System.Drawing.Point(177, 144);
            this.chat_lbl.Name = "chat_lbl";
            this.chat_lbl.Size = new System.Drawing.Size(29, 13);
            this.chat_lbl.TabIndex = 1;
            this.chat_lbl.Text = "Chat";
            // 
            // LogIn_btn
            // 
            this.LogIn_btn.Location = new System.Drawing.Point(320, 37);
            this.LogIn_btn.Name = "LogIn_btn";
            this.LogIn_btn.Size = new System.Drawing.Size(75, 23);
            this.LogIn_btn.TabIndex = 2;
            this.LogIn_btn.Text = "Log In";
            this.LogIn_btn.UseVisualStyleBackColor = true;
            this.LogIn_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
            // 
            // Email_txtBox
            // 
            this.Email_txtBox.Location = new System.Drawing.Point(38, 39);
            this.Email_txtBox.Name = "Email_txtBox";
            this.Email_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Email_txtBox.TabIndex = 3;
            // 
            // Password_txtBox
            // 
            this.Password_txtBox.Location = new System.Drawing.Point(182, 39);
            this.Password_txtBox.Name = "Password_txtBox";
            this.Password_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Password_txtBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "EMail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // Reg_Btn
            // 
            this.Reg_Btn.Location = new System.Drawing.Point(1090, 51);
            this.Reg_Btn.Name = "Reg_Btn";
            this.Reg_Btn.Size = new System.Drawing.Size(75, 23);
            this.Reg_Btn.TabIndex = 7;
            this.Reg_Btn.Text = "Reg";
            this.Reg_Btn.UseVisualStyleBackColor = true;
            this.Reg_Btn.Click += new System.EventHandler(this.Reg_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(995, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1004, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "EMail";
            // 
            // RegPassword_txtBox
            // 
            this.RegPassword_txtBox.Location = new System.Drawing.Point(971, 100);
            this.RegPassword_txtBox.Name = "RegPassword_txtBox";
            this.RegPassword_txtBox.Size = new System.Drawing.Size(100, 20);
            this.RegPassword_txtBox.TabIndex = 9;
            // 
            // RegEMail_txtBox
            // 
            this.RegEMail_txtBox.Location = new System.Drawing.Point(971, 54);
            this.RegEMail_txtBox.Name = "RegEMail_txtBox";
            this.RegEMail_txtBox.Size = new System.Drawing.Size(100, 20);
            this.RegEMail_txtBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1004, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // RegName_txtBox
            // 
            this.RegName_txtBox.Location = new System.Drawing.Point(971, 15);
            this.RegName_txtBox.Name = "RegName_txtBox";
            this.RegName_txtBox.Size = new System.Drawing.Size(100, 20);
            this.RegName_txtBox.TabIndex = 7;
            // 
            // Send_txtBox
            // 
            this.Send_txtBox.Location = new System.Drawing.Point(191, 412);
            this.Send_txtBox.Name = "Send_txtBox";
            this.Send_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Send_txtBox.TabIndex = 14;
            // 
            // Send_btn
            // 
            this.Send_btn.Location = new System.Drawing.Point(297, 409);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(75, 23);
            this.Send_btn.TabIndex = 15;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = true;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // Users_listBox
            // 
            this.Users_listBox.FormattingEnabled = true;
            this.Users_listBox.Location = new System.Drawing.Point(378, 144);
            this.Users_listBox.Name = "Users_listBox";
            this.Users_listBox.Size = new System.Drawing.Size(120, 264);
            this.Users_listBox.TabIndex = 16;
            // 
            // SendToGroupChat_btn
            // 
            this.SendToGroupChat_btn.Location = new System.Drawing.Point(772, 388);
            this.SendToGroupChat_btn.Name = "SendToGroupChat_btn";
            this.SendToGroupChat_btn.Size = new System.Drawing.Size(75, 23);
            this.SendToGroupChat_btn.TabIndex = 19;
            this.SendToGroupChat_btn.Text = "Send";
            this.SendToGroupChat_btn.UseVisualStyleBackColor = true;
            // 
            // GroupChatText_TxtBox
            // 
            this.GroupChatText_TxtBox.Location = new System.Drawing.Point(666, 388);
            this.GroupChatText_TxtBox.Name = "GroupChatText_TxtBox";
            this.GroupChatText_TxtBox.Size = new System.Drawing.Size(100, 20);
            this.GroupChatText_TxtBox.TabIndex = 18;
            // 
            // GroupChat
            // 
            this.GroupChat.Enabled = false;
            this.GroupChat.Location = new System.Drawing.Point(700, 214);
            this.GroupChat.Name = "GroupChat";
            this.GroupChat.Size = new System.Drawing.Size(226, 158);
            this.GroupChat.TabIndex = 17;
            this.GroupChat.Text = "";
            // 
            // GroupChatMembers_listBox
            // 
            this.GroupChatMembers_listBox.FormattingEnabled = true;
            this.GroupChatMembers_listBox.Location = new System.Drawing.Point(955, 185);
            this.GroupChatMembers_listBox.Name = "GroupChatMembers_listBox";
            this.GroupChatMembers_listBox.Size = new System.Drawing.Size(116, 108);
            this.GroupChatMembers_listBox.TabIndex = 20;
            // 
            // AddToGroupChat_bttn
            // 
            this.AddToGroupChat_bttn.Location = new System.Drawing.Point(378, 443);
            this.AddToGroupChat_bttn.Name = "AddToGroupChat_bttn";
            this.AddToGroupChat_bttn.Size = new System.Drawing.Size(110, 23);
            this.AddToGroupChat_bttn.TabIndex = 21;
            this.AddToGroupChat_bttn.Text = "Add to Group";
            this.AddToGroupChat_bttn.UseVisualStyleBackColor = true;
            this.AddToGroupChat_bttn.Click += new System.EventHandler(this.AddToGroupChat_bttn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RemoveFromeGroupList_bttn
            // 
            this.RemoveFromeGroupList_bttn.Location = new System.Drawing.Point(983, 299);
            this.RemoveFromeGroupList_bttn.Name = "RemoveFromeGroupList_bttn";
            this.RemoveFromeGroupList_bttn.Size = new System.Drawing.Size(75, 23);
            this.RemoveFromeGroupList_bttn.TabIndex = 22;
            this.RemoveFromeGroupList_bttn.Text = "Remove";
            this.RemoveFromeGroupList_bttn.UseVisualStyleBackColor = true;
            this.RemoveFromeGroupList_bttn.Click += new System.EventHandler(this.RemoveFromeGroupList_bttn_Click);
            // 
            // BlackList_listBox
            // 
            this.BlackList_listBox.FormattingEnabled = true;
            this.BlackList_listBox.Location = new System.Drawing.Point(513, 197);
            this.BlackList_listBox.Name = "BlackList_listBox";
            this.BlackList_listBox.Size = new System.Drawing.Size(116, 160);
            this.BlackList_listBox.TabIndex = 23;
            // 
            // RemoveFromeBlackList_Bttn
            // 
            this.RemoveFromeBlackList_Bttn.Location = new System.Drawing.Point(530, 363);
            this.RemoveFromeBlackList_Bttn.Name = "RemoveFromeBlackList_Bttn";
            this.RemoveFromeBlackList_Bttn.Size = new System.Drawing.Size(75, 23);
            this.RemoveFromeBlackList_Bttn.TabIndex = 24;
            this.RemoveFromeBlackList_Bttn.Text = "Remove";
            this.RemoveFromeBlackList_Bttn.UseVisualStyleBackColor = true;
            this.RemoveFromeBlackList_Bttn.Click += new System.EventHandler(this.RemoveFromeBlackList_Bttn_Click);
            // 
            // AddToBlackList_bttn
            // 
            this.AddToBlackList_bttn.Location = new System.Drawing.Point(378, 414);
            this.AddToBlackList_bttn.Name = "AddToBlackList_bttn";
            this.AddToBlackList_bttn.Size = new System.Drawing.Size(110, 23);
            this.AddToBlackList_bttn.TabIndex = 25;
            this.AddToBlackList_bttn.Text = "Add to BlackList";
            this.AddToBlackList_bttn.UseVisualStyleBackColor = true;
            this.AddToBlackList_bttn.Click += new System.EventHandler(this.AddToBlackList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(786, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Group Chat";
            // 
            // Messanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 473);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddToBlackList_bttn);
            this.Controls.Add(this.RemoveFromeBlackList_Bttn);
            this.Controls.Add(this.BlackList_listBox);
            this.Controls.Add(this.RemoveFromeGroupList_bttn);
            this.Controls.Add(this.AddToGroupChat_bttn);
            this.Controls.Add(this.GroupChatMembers_listBox);
            this.Controls.Add(this.SendToGroupChat_btn);
            this.Controls.Add(this.GroupChatText_TxtBox);
            this.Controls.Add(this.GroupChat);
            this.Controls.Add(this.Users_listBox);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.Send_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegName_txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegPassword_txtBox);
            this.Controls.Add(this.RegEMail_txtBox);
            this.Controls.Add(this.Reg_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_txtBox);
            this.Controls.Add(this.Email_txtBox);
            this.Controls.Add(this.LogIn_btn);
            this.Controls.Add(this.chat_lbl);
            this.Controls.Add(this.Chat_txtBox);
            this.Name = "Messanger";
            this.Text = "Messanger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Messanger_FormClosed);
            this.Load += new System.EventHandler(this.Messanger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Chat_txtBox;
        private System.Windows.Forms.Label chat_lbl;
        private System.Windows.Forms.Button LogIn_btn;
        private System.Windows.Forms.TextBox Email_txtBox;
        private System.Windows.Forms.TextBox Password_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reg_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RegPassword_txtBox;
        private System.Windows.Forms.TextBox RegEMail_txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RegName_txtBox;
        private System.Windows.Forms.TextBox Send_txtBox;
        private System.Windows.Forms.Button Send_btn;
        public System.Windows.Forms.ListBox Users_listBox;
        private System.Windows.Forms.Button SendToGroupChat_btn;
        private System.Windows.Forms.TextBox GroupChatText_TxtBox;
        private System.Windows.Forms.RichTextBox GroupChat;
        public System.Windows.Forms.ListBox GroupChatMembers_listBox;
        private System.Windows.Forms.Button AddToGroupChat_bttn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button RemoveFromeGroupList_bttn;
        public System.Windows.Forms.ListBox BlackList_listBox;
        private System.Windows.Forms.Button RemoveFromeBlackList_Bttn;
        private System.Windows.Forms.Button AddToBlackList_bttn;
        private System.Windows.Forms.Label label6;
    }
}


using ClassLibrary1.Entities;
using ClassLibrary1.Enums;
using ClassLibrary1.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp27;
using DbServer;

namespace ClientDb
{
    public partial class Messanger : Form
    {
        private bool isConnected = false;
        private User currentUser = null;
        private string message = null;

        public Messanger()
        {
            InitializeComponent();
            ServerConnect.getInstance();
            ClientListener.addMessagePublic = GetMessage;
            ClientListener.refreshUserList = GetUsersList;
            ClientListener.OnUser = GetUser;

            //проверка на запуск
            RefreshUserList();
        }

        public void GetUser(User u)
        {
            currentUser = u;
            if (currentUser != null)
            {
                Chat_txtBox.Text += currentUser.name;

                RefreshUserList();
            }
        }

        public void RefreshUserList()
        {
            ServerConnect.getInstance().ShowUsers();
        }


        void GetMessage(UserMessage message)
        {

            this.Invoke(new MethodInvoker(() => { Chat_txtBox.Text += message.UserFrom + ": " + message.message+"\n"; }));

        }


        void GetUsersList(List<User> users)
        {

            this.Invoke(new MethodInvoker(() =>
            {
                Users_listBox.Items.Clear();
                foreach (User user in users)
                {
                    Users_listBox.Items.Add(user);
                }
            }));

        }


        private void LogIn_btn_Click(object sender, EventArgs e)
        {
             ServerConnect.getInstance()
                .LogIn(Email_txtBox.Text, Password_txtBox.Text);


        }

        private void Reg_Btn_Click(object sender, EventArgs e)
        {
             ServerConnect.getInstance()
                .Reg(RegName_txtBox.Text, RegEMail_txtBox.Text, RegPassword_txtBox.Text);
           
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                UserMessage mes = new UserMessage() {message = Send_txtBox.Text, UserFrom = currentUser};
                ServerConnect.getInstance().SendMessage(mes);

            }
        }



        private void Messanger_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServerConnect.getInstance().Bye();
            if (currentUser!=null)
            {
                Users_listBox.Items.Remove(currentUser);
                RefreshUserList();
            }
            
           

        }

        private void Messanger_Load(object sender, EventArgs e)
        {

        }

        private void AddToGroupChat_bttn_Click(object sender, EventArgs e)
        {
            if (Users_listBox.Items.Count>0)
            {
                GroupChatMembers_listBox.Items.Add(Users_listBox.SelectedItem);
            }
        }

        private void RemoveFromeGroupList_bttn_Click(object sender, EventArgs e)
        {
            if (GroupChatMembers_listBox.Items.Count > 0)
            {
                GroupChatMembers_listBox.Items.Remove(GroupChatMembers_listBox.SelectedItem);
            }
        }

        private void AddToBlackList_Click(object sender, EventArgs e)
        {
            if (GroupChatMembers_listBox.Items.Count>0)
            {
                BlackList_listBox.Items.Add(GroupChatMembers_listBox.SelectedItem);
                currentUser.BlackList.Add(GroupChatMembers_listBox.SelectedItem as User);
                ServerConnect.getInstance().RefreshBlackList(this.currentUser);
            }
        }

        private void RemoveFromeBlackList_Bttn_Click(object sender, EventArgs e)
        {
            BlackList_listBox.Items.Remove(GroupChatMembers_listBox.SelectedItem);
            currentUser.BlackList.Remove(GroupChatMembers_listBox.SelectedItem as User);
            ServerConnect.getInstance().RefreshBlackList(this.currentUser);
        }
    }
}

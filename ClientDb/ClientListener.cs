using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Windows.Forms;
using WindowsFormsApp27;
using ClassLibrary1.Entities;
using ClassLibrary1.Enums;
using ClassLibrary1.Messages;

namespace ClientDb
{
    public class ClientListener
    {
        private ClientListener() {}
        private static ClientListener instance;

        public static Action<UserMessage> addMessagePublic;
        public static Action<List<User>> refreshUserList;

        public static ClientListener getInstance()
        {
            if (instance==null)
            {
                instance = new ClientListener();
               
            }

            return instance;
        }

        public NetworkStream stream;
        public void waitResponce()
        {
            Response response;
            while (true)
            {
                
                while (!stream.DataAvailable)
                {



                }
                response = ServerConnect.getInstance().receiveResponce();
                if (response== null)
                {
                    continue;
                    
                }
                if (response.Entity== Entities.UserMessage)
                {
                    response.success = true;
                    response.code = ResponseCodes.OK;
                    addMessagePublic(response.data as UserMessage);
                }
                if (response.Entity == Entities.UserList)
                {
                    response.success = true;
                    response.code = ResponseCodes.OK;
                    refreshUserList(response.data as List<User>);
                }




            }
        }

       
    }
}
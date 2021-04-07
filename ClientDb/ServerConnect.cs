using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1.Entities;
using ClassLibrary1.Enums;
using ClassLibrary1.Messages;
using ClientDb;
using DbServer;

namespace WindowsFormsApp27
{
    public class ServerConnect
    {
        
        public static Action<string> onError = new Action<string>((string msg) => { MessageBox.Show("Client Error: " + msg); });




        private TcpClient tcpClient;
        private Thread listen;
        private NetworkStream stream;
        private Task task;

        public string host { get; set; } = "localhost";
        public int port { get; set; } = 3334;

        private BinaryFormatter bf;

      


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        private ServerConnect( string host = "localhost", int port = 3334)
        {
            start(host, port);
        }




        /// <summary>
        /// Установка соединения
        /// </summary>
      
        /// <param name="host"></param>
        /// <param name="port"></param>
        private void start( string host = "localhost", int port = 3334)
        {

            if (tcpClient != null)
            {
                onError(" Уже есть экземпляр");
                return;
            }
            try
            {
                tcpClient = new TcpClient(host, port);
                stream = tcpClient.GetStream();
                bf = new BinaryFormatter();

                ClientListener.getInstance().stream = stream;
                task = new Task(ClientListener.getInstance().waitResponce);
                task.Start();
            }
            catch (Exception e)
            {
                onError(e.Message);
            }

        }
      




        /// <summary>
        /// нужно исправить, метод не должен возвращать string, в этом нет смысла
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public void SendMessage(UserMessage message)
        {
            Request request = new Request();
            request.command = Commands.SendMessageToAll;
            request.id = 2;
            request.entity = Entities.UserMessage;
            request.data = message;
            sendRequest(ref request);
            Response resp = receiveResponce();
            if (!resp.success)
            {

                Close();
                onError(" Неудалось отправить сообщение");
                return;
            }

            if (resp.code != ResponseCodes.OK)
            {
                Close();
                onError(" Код ответа " + resp.code);
                return;
            }

            

            

        }

        public void RefreshBlackList(User u)
        {
            Request request = new Request();
            request.command = Commands.AddToBlackList;
            request.id = 5;
            request.entity = Entities.User;
            request.data = u;
            sendRequest(ref request);
            Response response = receiveResponce();
            if (!response.success)
            {
                Close();
                onError(" Ответ в добовлении в черный список не норм не норма");
                return ;
            }
            if (response.code != ResponseCodes.OK)
            {
                Close();
                onError(" Код ответа " + response.code);
                return  ;
            }
        }


        public void Reg(string name, string login, string password)
        {
            Request request = new Request();
            request.command = Commands.Create;
            request.id = 1;
            request.entity = Entities.User;
            User u= new User() {name = name, email = login, pswd = password, isOnline = true};
            request.data = u;
            sendRequest(ref request);
           
           
        }


        /// <summary>
        /// отправить запрос на получение списка, должен срабатывать при входе, при каждом заходе и выходе пользователя
        /// </summary>
        public void ShowUsers()
        {
            Request request = new Request();
            request.command = Commands.ShowUsers;
            request.id = 4;
            request.entity = Entities.None;
            sendRequest(ref request);
          
            //не уверен нужно ли принимать здесь ответ, ибо он должен приходить в ClientListener тоже и касается отправки сообщения

        }


        /// <summary>
        /// запрос на удаления клиента из сети 
        /// </summary>
        public void Bye()
        {

            //отправляем запрос
            Request request = new Request();
            request.command = Commands.UserBye;
            request.entity = Entities.None;
            request.id = 3;
            sendRequest(ref request);
            //ответ в данной программе получать не нужно по этому на этом все
        }



      

        /// <summary>
        // АВТОРИЗАЦИЯ 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public void  LogIn(string login, string password)
        {
            // Запрос на авторизацию
            Request request = new Request();
            request.command = Commands.UserLogin;
            request.id = 0;
            request.entity = Entities.None;
            // Последняя точка - шифрование пароля
            User u= new User() { email = login, pswd = password, isOnline = true};
            request.data=u ;

            // Отправка запроса
            sendRequest(ref request);
          


        }

        private void Close()
        {

        }
         
        private static ServerConnect instance;


        /// <summary>
        /// Реализация одиночки
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        public static ServerConnect getInstance( string host = "localhost", int port = 3334)
        {
            if (instance == null)
            {
                instance = new ServerConnect(host, port);
            }
            return instance;
        }

      
        /// <summary>
        /// Отослать запрос серверу
        /// </summary>
        /// <param name="res"></param>
        public ServerConnect sendRequest(ref Request req)
        {
           
            try
            {
                bf.Serialize(stream, req);
            }
            catch (Exception ex)
            {
                onError(" sendRequest: " + ex.Message);
            }

            return this;
        }

        /// <summary>
        /// Получить получить ответ от сервера
        /// </summary>
        /// <returns></returns>
        public Response receiveResponce()
        {
            try
            {
                while (!stream.DataAvailable)
                {

                }
                return (Response)bf.Deserialize(stream);
            }
            catch (Exception ex)
            {
                onError(" receiveRequest: " + ex.Message);
            }

            return null;
        }

    }
}

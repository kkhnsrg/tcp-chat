using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketServer
{
    class Program
    {
        
        // Устанавливаем для сокета локальную конечную точку
        static List<Socket> All_Clients = new List<Socket>();
        static IPHostEntry ipHost = Dns.GetHostEntry("localhost");
        static IPAddress ipAddr = ipHost.AddressList[0];
        static IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
        bool isListen = true;

        // Создаем сокет Tcp/Ip
        static Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        public static void Main(string[] args)
        {    
            // Назначаем сокет локальной конечной точке и слушаем входящие сокеты
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);

                // Начинаем слушать соединения
                while (true)
                {
                    Console.WriteLine("Wait connection trough port {0}", ipEndPoint);

                    // Программа приостанавливается, ожидая входящее соединение
                    Socket handler = sListener.Accept();
                    Thread ServerThread = new Thread(new ParameterizedThreadStart(Server));
                    ServerThread.Start(handler);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void Server(object obj)
        {
            Socket handler = (Socket)obj;
            string data = null;
            string reply;
            byte[] msg;
            int bytesRec;
            byte[] bytes = new byte[1024];
            // Мы дождались клиента, пытающегося с нами соединиться
            try
            {
                while (true)
                {
                    bytesRec = handler.Receive(bytes);

                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);

                    // Показываем данные на консоли или регестрируем
                    if (data == "Сonected")
                    {
                        Console.WriteLine("Сonected");
                        All_Clients.Add(handler);
                      
                        data = "";
                    }

                    else
                    {

                        if (data == "Disconected")
                        {
                            All_Clients.Remove(handler);
                            Console.WriteLine("The server has finished connecting to the client");
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                        }
                        else
                        {
                            Console.Write("Receiving text: " + data + "\n\n");

                            // Отправляем ответ клиенту
                            reply = data;
                            msg = Encoding.UTF8.GetBytes(reply);
                            for (int i = 0; i < All_Clients.Count; i++)
                            {
                                All_Clients[i].Send(msg);
                            }
                            data = "";
                        }
                    }
                }  
            }
            catch (Exception ex)
            {
                Console.WriteLine("error client");
            }
               
            }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace TCP_Client
{
    public partial class fClient : Form
    {
        string Client_Name;
        bool isListen = true;
        static int port = 11000;
        byte[] bytes = new byte[1024];
        // Устанавливаем удаленную точку для сокета
        static IPHostEntry ipHost = Dns.GetHostEntry("localhost");
        static IPAddress ipAddr = ipHost.AddressList[0];
        IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);


        string message;
        byte[] msg;
        Socket sende = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);        
        public fClient()
        {
            InitializeComponent();
            rtbChat.Enabled = false;
            rtbMessage.Enabled = false;
            bSend.Enabled = false;
            try
            {
                Client_Name = tbName.Text + ": ";
                sende.Connect(ipEndPoint);
                Thread ReChatThread = new Thread(ReChat);
                ReChatThread.Start();
            }
            catch
            {
                MessageBox.Show("Connection to the server failed. Please try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
           
        }
        private void ReChat ()
        {
            string data;
            byte[] bytes;
            int bytesRec;
            try
            {
                while (isListen)
                {
                    data = null;
                    // Мы дождались рассылки сервера
                    bytes = new byte[1024];
                    bytesRec = sende.Receive(bytes);
                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
                    // Показываем в чате
                    SetText(rtbChat, data);
                }
            }
            catch { }
        }
        private void SetText(Control rb, string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => SetText(rb, text)));
                return;
            }
            rb.Text += text+"\n";
        }
        private void fClient_Load(object sender, EventArgs e)
        {
            
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            try {     
                // Отправляем данные через сокет
                message = Client_Name +": "+ rtbMessage.Text;
                msg = Encoding.UTF8.GetBytes(message);
                // Отправляем данные через сокет
                int bytesSent = sende.Send(msg);
                rtbMessage.Text = "";
            }
            catch{}
        }

        public void bEName_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text != "")
                {
                    message = "Сonected";
                    msg = Encoding.UTF8.GetBytes(message);
                    // Отправляем данные через сокет
                    int bytesSent = sende.Send(msg);
                    rtbMessage.Enabled = true;
                    bSend.Enabled = true;
                    Client_Name = tbName.Text;
                }
            }
            catch { }
        }

        private void fClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                isListen = false;
                message = "Disconected";
                msg = Encoding.UTF8.GetBytes(message);
                // Отправляем данные через сокет
                int bytesSent = sende.Send(msg);
            }
            catch
            {

            }
        }
    }
}

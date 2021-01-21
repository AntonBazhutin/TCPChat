using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static TcpClient user = new TcpClient();
        public static NetworkStream stream = null;
        public static string firstRequest = null;
        public static string sendedMessage = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtBxIp.Text = "127.0.0.1";
            txtBxPort.Text = "8080";
            txtBxNickname.Text = "Unknown001";
            richTextBxChat.Enabled = false;
            btnDisconnect.Enabled = false;
            richTxtBxMessage.Enabled = false;
            btnSend.Enabled = false;
            StartReading();
        }

        public async void StartReading()
        {
            richTextBxChat.Clear();
            string message = null;
            await Task.Run(() =>
           {
               while (true)
               {
                   try
                   {
                       while (user.Connected == true)
                       {
                           if (firstRequest == "true")
                           {
                               try
                               {
                                   message = ReadMessage();
                                   Invoke((Action)(() =>
                                    {
                                        if (message != "true" && richTextBxChat.Text != null)
                                        {
                                            richTextBxChat.Text += message;
                                        }
                                    }));
                               }
                               catch (Exception)
                               {
                               }
                           }
                       }
                   }
                   catch (Exception)
                   {
                   }
               }
           });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtBxIp.Text != string.Empty && txtBxPort.Text != string.Empty && txtBxNickname.Text != string.Empty)
            {
                try
                {
                    user = new TcpClient();
                    user.Connect(txtBxIp.Text, int.Parse(txtBxPort.Text));
                    stream = user.GetStream();

                    SendMessage(stream, txtBxNickname.Text);
                    firstRequest = ReadMessage();

                    if (firstRequest == "false")
                    {
                        stream.Close();
                        user.Close();
                        MessageBox.Show("User with that nickname is already in chat");
                        btnDisconnect.Enabled = false;
                        btnConnect.Enabled = true;
                        txtBxIp.ReadOnly = false;
                        txtBxNickname.ReadOnly = false;
                        txtBxPort.ReadOnly = false;
                    }
                    else
                    {
                        richTxtBxMessage.Enabled = true;
                        btnSend.Enabled = true;
                        btnDisconnect.Enabled = true;
                        btnConnect.Enabled = false;
                        txtBxIp.ReadOnly = true;
                        txtBxNickname.ReadOnly = true;
                        txtBxPort.ReadOnly = true;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Server doesn't respond. Try again later 0_o");
                    btnConnect.Enabled = true;
                    txtBxIp.ReadOnly = false;
                    txtBxNickname.ReadOnly = false;
                    txtBxPort.ReadOnly = false;
                }
            }
            else
                MessageBox.Show("Fill in all the fields");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (user.Connected == true)
            {
                sendedMessage = ("[" + DateTime.Now.ToShortTimeString() + "] "
                    + txtBxNickname.Text + " : " + richTxtBxMessage.Text);
                richTxtBxMessage.Text = string.Empty;
                SendMessage(stream, sendedMessage);
            }
        }

        public static string ReadMessage()
        {
            int bytes = 0;
            byte[] data = new byte[256];
            StringBuilder completeMessage = new StringBuilder();

            do
            {
                bytes = stream.Read(data, 0, data.Length);
                completeMessage.AppendFormat("{0}", Encoding.UTF8.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);

            return completeMessage.ToString();
        }
        public static void SendMessage(NetworkStream stream, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            stream.Close();
            user.Close();
            txtBxIp.ReadOnly = false;
            txtBxPort.ReadOnly = false;
            txtBxNickname.ReadOnly = false;
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
            richTxtBxMessage.Clear();
            richTxtBxMessage.Enabled = false;
            richTextBxChat.Clear();
        }
    }
}

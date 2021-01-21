using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public class User
    {
        public TcpClient Client { get; set; }
        public NetworkStream Stream { get; set; }
        public string Nickname { get; set; }

        public User(TcpClient tcp,NetworkStream stream ,string nickname)
        {
            Nickname = nickname;
            Client = tcp;
            Stream = stream;
        }

        public User()
        {
            Nickname = "";
            Stream = null;
            Client = null;
        }
    }
}

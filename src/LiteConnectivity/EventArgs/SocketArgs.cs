﻿// © 2019 NIREX ALL RIGHTS RESERVED

using System.Net.Sockets;

namespace LiteConnectivity.EventArgs
{
    public class SocketArgs : System.EventArgs
    {
        public SocketArgs(Socket sock)
        {
            Connection = sock;
        }

        public Socket Connection { get; protected set; }
    }
}

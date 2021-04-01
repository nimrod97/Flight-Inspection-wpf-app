﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class MyTelnetClient : ITelnetClient
    {
        Socket s;
        public void connect(string ip, int port)
        {
            this.s = new Socket(AddressFamily.InterNetwork,
                   SocketType.Stream,
                   ProtocolType.Tcp);

            s.Connect(ip, port);
            Console.WriteLine("Connection established");

        }

        public string read()
        {
            throw new NotImplementedException();
        }

        public void write(string line)
        {
            byte[] messageSent = Encoding.ASCII.GetBytes(line + "\r\n");
            int b = s.Send(messageSent);
        }

        public void disconnect()
        {
            this.s.Close();
        }
    }
}

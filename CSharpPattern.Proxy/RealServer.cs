using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharpPattern.Proxy
{
    class RealServer : IServer
    {
        private int _port;
        private string _host;

        public RealServer(int port, string host)
        {
            _port = port;
            _host = host;
            Console.WriteLine("Initializing server...");
        }

        public void DownLoad(string url)
        {
            Console.WriteLine("Downloading " + _host + ":" + _port + "/" + url);
        }
    }
}

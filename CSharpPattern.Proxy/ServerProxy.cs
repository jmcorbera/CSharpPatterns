using System;

namespace CSharpPattern.Proxy
{
    public class ServerProxy : IServer
    {
        private int _port;
        private string _host;
        private RealServer _srv;
        
        public ServerProxy(int port, string host)
        {
            _port = port;
            _host = host;
            _srv = null;
            Console.WriteLine("Initializing proxy...");
        }

        public void DownLoad(string file)
        {
            if(isRestricted(file))
            {
                if (_srv == null)
                {
                    _srv = new RealServer(_port, _host);             
                }

                _srv.DownLoad(file);
            }
            else
            {
                Console.WriteLine("You are currently in an area that does not allow the download of the file.");
            }
        }

        private bool isRestricted(string file)
        {
            return !string.Equals(file, "/download/prohibited.avi");
        }
    }
}

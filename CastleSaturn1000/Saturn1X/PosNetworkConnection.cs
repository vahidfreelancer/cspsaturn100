using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CastlePaySolutions.Saturn1X
{
    class PosNetworkConnection
    {
        private TcpClient _tcpClient = null;
        private string _address;
        private int _port = -1;
        public PosNetworkConnection(string address,int port)
        {
            _address = address;
            _port = port;
            _tcpClient = new TcpClient(address, port);
        }
        public void Connect() 
        {
            _tcpClient.BeginConnect(_address, _port, onTcpPosConnect, null);
        }

        private void onTcpPosConnect(IAsyncResult ar)
        {
            var result = ar.AsyncState;
        }

        public bool IsConnected
        {
            get
            {
                try
                {
                    if (_tcpClient != null && _tcpClient.Client != null && _tcpClient.Client.Connected)
                    {
                        /* pear to the documentation on Poll:
                         * When passing SelectMode.SelectRead as a parameter to the Poll method it will return 
                         * -either- true if Socket.Listen(Int32) has been called and a connection is pending;
                         * -or- true if data is available for reading; 
                         * -or- true if the connection has been closed, reset, or terminated; 
                         * otherwise, returns false
                         */
                        // Detect if client disconnected
                        if (_tcpClient.Client.Poll(0, SelectMode.SelectRead))
                        {
                            byte[] buff = new byte[1];
                            if (_tcpClient.Client.Receive(buff, SocketFlags.Peek) == 0)
                            {
                                // Client disconnected
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}

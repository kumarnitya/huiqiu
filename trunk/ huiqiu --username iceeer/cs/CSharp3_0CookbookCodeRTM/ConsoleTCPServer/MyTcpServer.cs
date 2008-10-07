using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.IO;


namespace ConsoleTCPServer
{
    class MyTcpServer
    {
        #region Private Members
        private TcpListener _listener;
        private IPAddress _address;
        private int _port;
        private bool _listening;
        private object _syncRoot = new object();
        #endregion

        #region CTORs

        public MyTcpServer(IPAddress address, int port)
        {
            _port = port;
            _address = address;
        }
        #endregion // CTORs

        #region Properties
        public IPAddress Address
        {
            get { return _address; }
        }

        public int Port
        {
            get { return _port; }
        }

        public bool Listening
        {
            get { return _listening; }
        }
        #endregion

        #region Public Methods
        public void Listen()
        {
            try
            {
                lock (_syncRoot)
                {
                    _listener = new TcpListener(_address, _port);

                    // fire up the server
                    _listener.Start();

                    // set listening bit
                    _listening = true;
                }

                // Enter the listening loop.
                do
                {
                    Trace.Write("Looking for someone to talk to... ");

                    // Wait for connection
                    TcpClient newClient = _listener.AcceptTcpClient();
                    Trace.WriteLine("Connected to new client");

                    // queue a request to take care of the client
                    ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessClient), newClient);
                }
                while (_listening);
            }
            catch (SocketException se)
            {
                Trace.WriteLine("SocketException: " + se.ToString());
            }
            finally
            {
                // shut it down
                StopListening();
            }
        }

        public void StopListening()
        {
            if (_listening)
            {
                lock (_syncRoot)
                {
                    // set listening bit
                    _listening = false;
                    // shut it down
                    _listener.Stop();
                }
            }
        }
        #endregion

        #region Private Methods
        private void ProcessClient(object client)
        {
            TcpClient newClient = (TcpClient)client;
            try
            {
                // Buffer for reading data
                byte[] bytes = new byte[1024];
                StringBuilder clientData = new StringBuilder();

                // get the stream to talk to the client over
                using (NetworkStream ns = newClient.GetStream())
                {
                    // set initial read timeout to 1 minute to allow for connection
                    ns.ReadTimeout = 60000;
                    // Loop to receive all the data sent by the client.
                    int bytesRead = 0;
                    do
                    {
                        // read the data
                        try
                        {
                            bytesRead = ns.Read(bytes, 0, bytes.Length);
                            if (bytesRead > 0)
                            {
                                // Translate data bytes to an ASCII string and append
                                clientData.Append(
                                    Encoding.ASCII.GetString(bytes, 0, bytesRead));
                                // decrease read timeout to 1 second now that data is coming in
                                ns.ReadTimeout = 1000;
                            }
                        }
                        catch (IOException ioe)
                        {
                            // read timed out, all data has been retrieved
                            Trace.WriteLine("Read timed out: {0}",ioe.ToString());
                            bytesRead = 0;
                        }
                    }
                    while (bytesRead > 0);

                    Trace.WriteLine("Client says: {0}", clientData.ToString());

                    // Thank them for their input
                    bytes = Encoding.ASCII.GetBytes("Thanks call again!");

                    // Send back a response.
                    ns.Write(bytes, 0, bytes.Length);
                }
            }
            finally
            {
                // stop talking to client
                if(newClient != null)
                    newClient.Close();
            }
        }
        #endregion
    }
}

using System;
using System.Net.Sockets;
using System.Net;
using System.Text;


namespace Uno
{
    public class USocket : Comunication
    {
        Socket listener;
        Socket sender;
        ConnectSockets form;
        bool open;

        public USocket()
        {
            form = new ConnectSockets(this);
            sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void connect()
        {
            form.ShowDialog();
            open = true;
        }


        /*
         * este metodo se ejecuta a travez de un hilo para que la aplicacion no se congele.
         */
        public void connectServer(Object obj)
        {
            string port = (string)obj;
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direction = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(port));

            socket.Bind(direction);
            socket.Listen(5);
            listener = socket.Accept();

            Console.WriteLine("Conectado con exito");
        }


        /*
         * Este metodo libera al server para poder establecer la conexion.
         */
        public void connectSender(string port)
        {
            IPEndPoint direction = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(port));
            sender.Connect(direction);
        }

        public bool isOpen()
        {
            return open;
        }

        public string listen()
        {
            while (listener == null) ;
            byte[] info = new byte[255];
            int length  = listener.Receive(info);
            Array.Resize(ref info, length);
            return Encoding.Default.GetString(info);
        }

        public void send(string msg)
        {
            byte[] info = Encoding.Default.GetBytes(msg);
            sender.Send(info);
        }

        public void close()
        {
            sender.Close();
            listener.Close();
        }
    }
}

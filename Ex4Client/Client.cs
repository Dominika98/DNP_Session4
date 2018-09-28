using System;
using System.Net;
using System.Net.Sockets;


namespace Ex4Client
{
    class Client
    {
        static void Main(string[] args)
        {
         
            //byte[] adr= {127, 0, 0, 1};
            TcpClient client=new TcpClient("127.0.0.1", 12345);

            //client.Connect(new IPEndPoint(new IPAddress(adr), 12345));

            NetworkStream ns=client.GetStream();
            string welcome = "Hello from the client";
            byte[] data = System.Text.Encoding.ASCII.GetBytes(welcome);
            ns.Write(data, 0, data.Length);

            byte[] bytes = new byte[1024];  
            int bytesRead = ns.Read(bytes, 0, bytes.Length);  

            Console.WriteLine(System.Text.Encoding.ASCII.GetString(bytes,0,bytesRead));

        }
    }
}

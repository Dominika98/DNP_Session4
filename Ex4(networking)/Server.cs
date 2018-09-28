using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Ex4_networking_
{
    class Server
    {
        static void Main(string[] args)
        {
             byte[] adr={127,0,0,1};
            IPAddress IPAddress= new IPAddress(adr);
            TcpListener newsock=new TcpListener(IPAddress, 12345);
            newsock.Start();
            Console.WriteLine("Waiting for a client...");

            while(true){
                
                 Thread thread=new Thread(new ThreadStart(RunT));
            }
        }

        public static void RunT(NetworkStream ns){
           
               TcpClient client=newsock.AcceptTcpClient();
                 NetworkStream ns=client.GetStream();
                while (true){
                string welcome = "Welcome to the DNP test server";
                byte[] data = System.Text.Encoding.ASCII.GetBytes(welcome);
                ns.Write(data, 0, data.Length);
                byte[] bytes = new byte[1024];  
                int bytesRead = ns.Read(bytes, 0, bytes.Length);  

                Console.WriteLine(System.Text.Encoding.ASCII.GetString(bytes,0,bytesRead));
                }
        }
        
    }
}
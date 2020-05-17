using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.IO;

namespace ConsoleServer
{
    class ProgramServer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server............");
           
            //1创建服务端通讯对象=监听对象
            TcpListener server = new TcpListener(9999);
            //2 启动监听对象server
            server.Start();
            //3接受客户端的连接请求
            //Socket socket=server.AcceptSocket();
            TcpClient client = server.AcceptTcpClient();
            //Socket socket = client.Client;
            if (!client.Connected)
            {
                Console.WriteLine("没有连上");
                return;
            }
            //4数据交换：发 收 本质【 网络流的读写】
            //NetworkStream stream = new NetworkStream(socket);
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            //发
            Console.WriteLine("请输入要发出去的信息");
            string info = Console.ReadLine();//"我是服务器！";
            writer.WriteLine(info);
            writer.Flush();
            Console.WriteLine("我发出去的信息是：" + info);
            //收
            string getInfo = reader.ReadLine();
            Console.WriteLine("我是服务器，收到的信息是：" + getInfo);
            //结束
            writer.Close(); reader.Close(); 
            stream.Close(); 
            //socket.Close(); 
            server.Stop();
            Console.ReadKey();
        }
    }
}

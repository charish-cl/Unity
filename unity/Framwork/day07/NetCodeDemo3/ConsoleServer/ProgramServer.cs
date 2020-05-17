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
            Socket socket=server.AcceptSocket();
            if (!socket.Connected)
            {
                Console.WriteLine("没有连上");
                return;
            }
            //4数据交换：发 收 本质【 网络流的读写】

            //发 socket
            Console.WriteLine("请输入要发出去的信息");
            string info = Console.ReadLine();//"我是服务器！";
            // string>byte[]  8bit=1byte
            byte[] bytesSendInfo = System.Text.Encoding.UTF8.GetBytes(info);
            socket.Send(bytesSendInfo);  
            Console.WriteLine("我发出去的信息是：" + info);
            
            //结束           
            socket.Close(); server.Stop();
            Console.ReadKey();
        }
    }
}

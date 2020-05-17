using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.IO;

namespace ConsoleClient
{
    class ProgramClient
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client............");
            //1 创建客户端对象
            TcpClient client = new TcpClient();
            //2连接服务器
            client.Connect("127.0.0.1", 9999);//不同电脑 "localhost"
            if (!client.Connected)
            {
                Console.WriteLine("没有连上");
                return;
            }
            //3数据交换 收 发 
            Socket  socket=client.Client;
            NetworkStream stream = new NetworkStream(socket);
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            //收
            string getInfo=reader.ReadLine();
            Console.WriteLine("我是客户端，收到的信息是："+getInfo);
            //发 
            Console.WriteLine("请输入要发出去的信息");
            string info = Console.ReadLine();//"我是客户端！";
            writer.WriteLine(info);
            writer.Flush();
            Console.WriteLine("我客户端发出去的信息是：" + info);

            //结束
            writer.Close(); reader.Close();
            stream.Close(); socket.Close(); client.Close();
            Console.ReadKey();
        }
    }
}

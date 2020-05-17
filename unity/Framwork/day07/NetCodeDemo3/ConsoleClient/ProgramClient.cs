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
            //收
            //string getInfo=reader.ReadLine();
            //Console.WriteLine("我是客户端，收到的信息是："+getInfo);  
            byte[] bytesGetInfo = new byte[100];//10000 
            //? 如果有个属性能提前告诉我 发过来的长度  不支持获取长度！
            //                                         适合自定义协议！
            socket.Receive(bytesGetInfo);
            //byte[]>string
            string getInfo = System.Text.Encoding.UTF8.GetString(bytesGetInfo);
            Console.WriteLine("我是客户端，收到的信息是："+getInfo);  
            //结束            
            socket.Close(); client.Close();
            Console.ReadKey();
        }
    }
}

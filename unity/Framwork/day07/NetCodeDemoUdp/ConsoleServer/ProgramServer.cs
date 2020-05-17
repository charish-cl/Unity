using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.IO;
using System.Net;

namespace ConsoleServer
{
    class ProgramServer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UDP Server............");
           
            //1创建服务端通讯对象
            UdpClient udpserver = new UdpClient();            
            //4数据交换：发 收 本质【 网络流的读写】
            //发 
            Console.WriteLine("请输入要发出去的信息");
            string info = Console.ReadLine();//"我是服务器！";
            // string>byte[]  8bit=1byte
            byte[] bytesSendInfo = System.Text.Encoding.UTF8.GetBytes(info);

            IPEndPoint ipPoint=new IPEndPoint(IPAddress.Parse("127.0.0.1"),9999);
            //IPEndPoint数据类型 表示 ip地址和端口号 封装 》终结点
            udpserver.Send(bytesSendInfo, bytesSendInfo.Length, ipPoint);  
            Console.WriteLine("我发出去的信息是：" + info);
            
            //结束           
            udpserver.Close();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.IO;
using System.Net;

namespace ConsoleClient
{
    class ProgramClient
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UDP Client............");
            //1 创建客户端对象
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            UdpClient udpclient = new UdpClient(ipPoint);    
            //收  
           
            byte[] bytesGetInfo=  udpclient.Receive(ref ipPoint);
            //byte[]>string
            string getInfo = System.Text.Encoding.UTF8.GetString(bytesGetInfo);
            Console.WriteLine("我是客户端，收到的信息是："+getInfo);  
            //结束            
            udpclient.Close();
            Console.ReadKey();
        }
    }
}

using System;
using UnityEngine;
using System.Net.Sockets;
using System.IO;
using System.Threading;
public class TCPServer
{
    public TcpListener server;//**
    public TcpClient   client;
    public NetworkStream stream;
    public StreamReader reader;
    public StreamWriter writer;
    public Thread thread;
    public event Action<string> ReciveEvent;   
    public void StartServer()
    {
        if (thread == null)
        {
            thread = new Thread(Listener);
            thread.Start();
        }
    }
    void Listener()
    {
        server = new TcpListener(9999);//**
        server.Start();//**
        Debug.Log("启动服务：等待客户端连接");
        client = server.AcceptTcpClient();//**        
        Debug.Log("接受客户端连接:");

        Debug.Log("开始数据交换"); 
        stream = client.GetStream();
        writer = new StreamWriter(stream);
        reader = new StreamReader(stream);
        Recive();
    }
    void Recive()
    {
        while (true)
        {
            string msg = null;            
            msg = reader.ReadLine();
            while (msg != null)
            {
                if (ReciveEvent != null)
                    ReciveEvent(msg);
                msg = reader.ReadLine();
            }
        }
    }
    public void Send(string msg)
    {
        if (writer != null)
        {            
            writer.WriteLine(msg);
            writer.Flush();
        }
    }
    public void Close()
    {
        reader.Close();
        writer.Close();
        stream.Close();
        client.Close();
        server.Stop();//**
        thread.Abort();
    }
}

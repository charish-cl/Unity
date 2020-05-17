using System;
using UnityEngine;
using System.Net.Sockets;
using System.IO;
using System.Threading;
public class MyTCPClient
{
    public TcpClient client;
    public NetworkStream stream;
    public StreamReader reader;
    public StreamWriter writer;
    public Thread thread;
    public event Action<string> ReciveEvent;
    private string hostName;//
    private int port;//
    public MyTCPClient(string hostName, int port)
    {
        this.hostName = hostName;
        this.port = port;
    }
    //连接  
    public void ConnectServer()
    {
        if (thread == null)
        {
            thread = new Thread(Connect);
            thread.Start();
        }
    }
    void Connect()
    {
        client = new TcpClient(System.Net.Dns.GetHostName(), port);
        Debug.Log("已连接服务器");

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
        thread.Abort();
    }

}

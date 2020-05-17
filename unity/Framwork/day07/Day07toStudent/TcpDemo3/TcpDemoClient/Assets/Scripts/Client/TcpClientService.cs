using System;
using UnityEngine;
using System.Net.Sockets;
using System.Net;
/// <summary>
/// 发送消息接收消息，消息到达后触发事件去显示
/// </summary>
public class TcpClientService
{
    private static TcpClientService instance;
    public static string Ip = "127.0.0.1";
    public static int Prot = 8899;
    public static TcpClientService Instance
    {
        get
        {
            if (instance == null)
                instance = new TcpClientService();
            return instance;
        }
    }
    private TcpClient client;
    private byte[] readByte;
    private TcpClientService()
    {
        try
        {
            //创建服务器终结点 (需要改为真正服务器ip)
            IPEndPoint serverIpPoint = new IPEndPoint(IPAddress.Parse(Ip), Prot);
            //创建Tcp客户端
            client = new TcpClient();
            //连接服务器
            client.Connect(serverIpPoint);
            Debug.Log("建立连接");
            readByte = new byte[1024];
            //启动线程接收消息  (不需要接受可以不启动)
            Loom.Initialize();//在主线程初始化Loom对象
            this.client.GetStream().
                BeginRead(readByte, 0, readByte.Length, ReceiveMessage, null);            
        }
        catch (Exception e)
        {
            Debug.Log("连接失败");
        } 
    }      
    /// <summary>
    /// 接收消息
    /// </summary>
    /// <param name="ar"></param>
    private void ReceiveMessage(IAsyncResult ar)
    {
        int bytesRead = this.client.GetStream().EndRead(ar);
        if (bytesRead > 1)
        {
            Message msg = Message.BytesToStruct(readByte);
            //当前方法即线程 
            Loom.QueueOnMainThread(() =>
            {
                //在主线程中执行
                MessageArrived(msg);
            });
        }
        this.client.GetStream().BeginRead(readByte, 0,
            readByte.Length, ReceiveMessage, null);
    }  
    /// <summary>
    /// 消息到达事件
    /// </summary>
    public event System.Action<Message> MessageArrived;
    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="msg"></param>
    public void SendMessage(Message msg)
    {
        try
        {
            if (client.Connected)
            {
                byte[] buffer = msg.StructToBytes();
                client.GetStream().Write(buffer, 0, buffer.Length);
            }
            else
            {
                Debug.Log("链接断开,不能发送");
            }
        }
        catch (Exception e)
        {
            Debug.Log("服务器掉线");
        }
    }
}

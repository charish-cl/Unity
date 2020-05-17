using System;
using System.Collections.Generic;
using System.Net.Sockets;//
/// <summary>
/// 
/// </summary>
class TcpServerService
{
    public static Dictionary<string, TcpServerService> allClients =
        new  Dictionary<string, TcpServerService>(); // 客户列表 
    private TcpClient client; 
    public string clientIP;   
    private byte[] data;  
    public TcpServerService(TcpClient client)
    {
        this.client = client;
        this.clientIP = client.Client.RemoteEndPoint.ToString();
        //将当前客户端存储到列表
        allClients.Add(this.clientIP, this);
        data = new byte[1024]; 
        // 从服务端获取消息  
        client.GetStream().BeginRead(data, 0, data.Length, ReceiveMessage, null);
    }
    public System.Action<Message> MessageArrived;
    // 从客戶端获取消息  
    public void ReceiveMessage(IAsyncResult ar)
    {
        int bytesRead = this.client.GetStream().EndRead(ar); 
        if (bytesRead < 1)
        {//读取完毕
            return;
        }
        else
        { 
            Message msg = Message.BytesToStruct(data); 
            Loom.QueueOnMainThread(()=>{
                MessageArrived(msg);
            }); 
        }
        this.client.GetStream().BeginRead(data, 0, data.Length, ReceiveMessage, null); 
    }
    public void SendMessage(Message msg)
    {
        try
        {
            if (client.Connected)
            {
                byte[] buffer = msg.StructToBytes();
                client.GetStream().Write(buffer, 0, buffer.Length);
                UnityEngine.Debug.Log(buffer.Length);
            } 
        }
        catch (Exception e)
        {
            UnityEngine.Debug.Log("客户端掉线");
        }
    }
}

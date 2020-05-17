using UnityEngine;
using System.Net.Sockets;
/// <summary>
/// 收到消息后的处理：1接收，2绘制。
/// </summary>
public class ServerTest : MonoBehaviour 
{
    public static string ip = "127.0.0.1";
    public static int port = 8899; 
    // 设置连接端口   
    private TcpListener listener;
    private TcpServerService user;
    private void Awake()
    {  
        //初始化服务器IP  
        System.Net.IPAddress localAdd = System.Net.IPAddress.Parse(ip);
        //创建TCP侦听器  
        listener = new TcpListener(localAdd, port);
        listener.Start();  
        Loom.RunAsync(() =>
        {
            while (true)
            {
                user = new TcpServerService(listener.AcceptTcpClient()); 
                user.MessageArrived = Arrived;
            }
        }); 
    }
    private Vector3 movePosition;
    private Quaternion rotation=Quaternion.identity;
    private void Arrived(Message msg)
    {
        movePosition = msg.Position;
        rotation = msg.Rotation;
    }
    public float moveSpeed = 10;
    public float rotateSpeed = 10;
    private void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, movePosition, Time.deltaTime * moveSpeed);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, rotation, Time.deltaTime * rotateSpeed);
    }
    private void OnGUI()
    { 
       if(GUILayout.Button("发送"))
       {
           Message msg = new Message() { CharacterName = "aa" };
           user.SendMessage(msg);
       }
    }
}

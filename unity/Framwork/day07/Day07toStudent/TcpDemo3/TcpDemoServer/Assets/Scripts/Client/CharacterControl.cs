using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 角色控制类:运动，发送消息
/// </summary>
public class CharacterControl : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    public int a = 0;
    /// <summary>
    /// 文本组件
    /// </summary>
    public Text txt;
    /// <summary>
    /// 初始化
    /// </summary>
    void Start()
    {
        txt = GameObject.Find("Text").GetComponent<Text>(); 
        //注册消息到达事件
        TcpClientService.Instance.MessageArrived += client_MessageArrived;
    }
    public void client_MessageArrived(Message obj)
    {
         //收到消息的回调函数
        txt.text += a + "\t";
    }     
    //移动旋转运动
    private void MovementRotation()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            this.transform.Translate(0, 0, vertical);
            this.transform.Rotate(0, horizontal, 0); 
        }
    }
    //异步发送消息
    private float nextTime = 0;
    private void SyncMessage()
    {
        if (Time.time >= nextTime)
        {
            //发送消息
            Message msg = new Message() 
            { 
                Position = this.transform.position, 
                Rotation = this.transform.rotation 
            };
            TcpClientService.Instance.SendMessage(msg);
            nextTime = Time.time + 0.5f;//间隔0.2秒
        }
    }
    //
    private void Update()
    {
        MovementRotation();
        SyncMessage();
    }
}

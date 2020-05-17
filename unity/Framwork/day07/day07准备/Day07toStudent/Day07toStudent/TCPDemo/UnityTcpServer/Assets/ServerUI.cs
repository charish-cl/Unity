using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class ServerUI : MonoBehaviour
{
    TCPServer server = new TCPServer();//**
    public InputField txtInput = null;
    public InputField txtShow = null;
    public void btnStart_Click()
    {
        server.ReciveEvent+= ShowReciveMsg;
        server.StartServer();
    }
    public void btnSend_Click()
    {
        server.Send(txtInput.text);
    }
    public void btnClose_Click()
    {
        server.Close();
    }
    Queue<String> msgQueue = new Queue<string>();
    public void ShowReciveMsg(string msg)
    {
        msgQueue.Enqueue(msg);        
    }  
    public void Update()
    {
       if(msgQueue.Count > 0)
       {
          txtShow.text +=msgQueue.Dequeue();
       }
    }
    public void OnGUI()
    {
        if (msgQueue.Count > 0)
        {
            txtShow.text += msgQueue.Dequeue();
        }
    }
}

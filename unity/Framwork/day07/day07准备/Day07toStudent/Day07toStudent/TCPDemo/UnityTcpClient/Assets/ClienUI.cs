using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class ClienUI : MonoBehaviour
{
    MyTCPClient client = null;
    public InputField txtInput = null;
    public InputField txtShow = null;
    public void btnStart_Click()
    {
        client = new MyTCPClient("127.0.0.1", 9999);
        client.ReciveEvent+= ShowReciveMsg;
        client.ConnectServer();
    }
    public void btnSend_Click()
    {
        client.Send(txtInput.text);
    }
    public void btnClose_Click()
    {
        client.Close();
    }
    Queue<String> msgQueue = new Queue<string>();
    void ShowReciveMsg(string msg)
    {
        msgQueue.Enqueue(msg);
    }
    void Update()
    {
        if (msgQueue.Count > 0)
        {
            txtShow.text += msgQueue.Dequeue();
        }
    }
}

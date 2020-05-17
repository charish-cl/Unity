using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
/// <summary>
/// 
/// </summary>
public class Test : MonoBehaviour
{ 
    Text txt;
    //使用LOOM
    private void Start()
    { 
        txt = GetComponent<Text>();
        actionList = new List<Action>();         
        //必须在主线程初始化(创建脚本对象)
        Loom.Initialize();
        ThreadPool.QueueUserWorkItem((o) => {
            while (true)
            {
                Debug.Log(Thread.CurrentThread.Name + "---" + txt.text);
                Thread.Sleep(500);
                Loom.QueueOnMainThread(Fun1);
            }
        }); 
    }     
    List<Action> actionList;
    private void Update()
    {
        if (actionList.Count > 0)
        {
            foreach (var item in actionList)
            {
                if (item != null)
                    item();
            }
            actionList.Clear();
        }
    }
    private void Fun1()
    {
        txt.text += "a+\r\n"; 
    }
}

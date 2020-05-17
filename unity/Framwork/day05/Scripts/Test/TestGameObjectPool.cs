using UnityEngine;
using System.Collections;
//TestGameObjectPool 把GameObjectPool 方法都调用一下
public class TestGameObjectPool : MonoBehaviour {
    public GameObject[] prefabs;//记住赋值
    public string[] names = {"Cube","Sphere" };
	// Use this for initialization
    GameObjectPool poolobj = null;
	void Start () {
        poolobj = GameObjectPool.instance;
	    //调用创建的方法
        for (int i = 0; i < 3; i++)
        {
            Vector3 pos1 = new Vector3(Random.Range(-10, 10), 0,
                Random.Range(-10, 10));

            
            poolobj.CreateObject(names[0], prefabs[0],
                pos1, Quaternion.identity);
        }

	}
	
	// Update is called once per frame
	void OnGUI () {
        if (GUILayout.Button("创建"))
        {
            Vector3 pos1 = new Vector3(Random.Range(-10, 10), 0,
                Random.Range(-10, 10));           
            poolobj.CreateObject(names[0], prefabs[0],
                pos1, Quaternion.identity);
        }
        if (GUILayout.Button("释放 ，彻底删除"))
        {
            poolobj.ClearAll();
        }
        if (GUILayout.Button("回收"))
        {
            //找到某一个，回收
           var go= GameObject.FindGameObjectWithTag(names[0]);
           if (go != null) poolobj.CollectObject(go);
        }
	}
}

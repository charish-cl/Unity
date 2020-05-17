using UnityEngine;
using System.Collections;

public class TestArrayHelper : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //FindHPMax();
        //FindAllEnemys();
        FindDistanceNear();
	}

    //问题1：找出敌人中生命值HP最大的敌人，变为黄色
    private void FindHPMax()
    { 
        //1根据tag找到所有的敌人
        GameObject[] gos=GameObject.FindGameObjectsWithTag("Enemy");
        //2找HP最大的    HP>脚本=组件》go
        var enemy=ArrayHelper.Max(gos, go =>
            go.GetComponent<EnemyHealth>().HP);
        //3变为黄色
        enemy.GetComponent<Renderer>().material.color = Color.yellow;
        
    }
    //问题2: 找出敌人中生命值HP大于（某个值）20的所有敌人，变为蓝色
    private void FindAllEnemys()
    {
        //1根据tag找到所有的敌人
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Enemy");
        //2找HP最大的    HP>脚本=组件》go
        var enemys = ArrayHelper.FindAll(gos, go =>
            go.GetComponent<EnemyHealth>().HP>20);
        //3变为蓝色
        foreach(var enemy in enemys)
        { enemy.GetComponent<Renderer>().material.color = Color.blue; }      

    }
    //问题3: 找出离主角最近的敌人，变为红色
    private void FindDistanceNear()
    {
        //1根据tag找到所有的敌人
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Enemy");
        //2找出离主角最近的敌人
        var enemy = ArrayHelper.Min(gos, 
            go => Vector3.Distance(this.transform.position, go.transform.position));
        //3变为红色
        enemy.GetComponent<Renderer>().material.color = Color.red;

    }
}

using UnityEngine;
using System.Collections;

public class TestArrayHelper : MonoBehaviour {

	// Use this for initialization
	void Start () {
        FindHPMax();

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
}

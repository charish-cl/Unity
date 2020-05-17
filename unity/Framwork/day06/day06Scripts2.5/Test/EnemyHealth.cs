using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public int HP;
    public int SP;
	void Awake () {

        HP = Random.Range(0, 50);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

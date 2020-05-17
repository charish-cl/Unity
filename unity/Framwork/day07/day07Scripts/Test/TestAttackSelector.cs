using UnityEngine;
using System.Collections;

using ARPGDemo.Skill;

public class TestAttackSelector : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SkillData skill=new SkillData();
        skill.attackDistance=5;
        skill.attackType=SkillAttackType.Group;//
        skill.attackAngle=180; //对扇形有意义

        IAttackSelector Selector = new CircleAttackSelector();//SectorAttackSelector();//
        var enemys=Selector.SelectTarget(skill, this.transform);
        if (enemys != null)
        {
            foreach (var enemy in enemys)
            {
                enemy.GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
         
	}
	
}

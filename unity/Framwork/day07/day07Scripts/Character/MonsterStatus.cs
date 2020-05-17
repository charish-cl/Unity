﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ARPGDemo.Character
{
    /// <summary>
    /// 小怪状态
    /// </summary>
    public class MonsterStatus : CharacterStatus
    {
        /// <summary>
        /// 贡献经验值
        /// </summary>
        public int GiveExp;

        public override void Dead()
        {
            print("MonsterStatus Dead ");
        }
        public override void OnDamage(int damageVal)
        {            
            base.OnDamage(damageVal);
            //
            //print("MonsterStatus OnDamage ");
        }
       
    }
}

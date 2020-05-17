using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ARPGDemo.Character
{
    /// <summary>
    /// 小怪状态
    /// </summary>
    public class MonsterStatus
    {
        /// <summary>
        /// 攻击距离
        /// </summary>
        public int attackDistance;

        /// <summary>
        /// 攻击速度
        /// </summary>
        public int attackSpeed;

        /// <summary>
        /// 伤害
        /// </summary>
        public int Damage;

        /// <summary>
        /// 防御
        /// </summary>
        public int Defence;

        /// <summary>
        /// 生命
        /// </summary>
        public int HP;

        /// <summary>
        /// 最大生命
        /// </summary>
        public int MaxHP;

        /// <summary>
        /// 魔法
        /// </summary>
        public int SP;

        /// <summary>
        /// 最大魔法
        /// </summary>
        public int MaxSP;

        /// <summary>
        /// 受击
        /// </summary>
        public void OnDamage()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 死亡
        /// </summary>
        public void Dead()
        {
            throw new System.NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ARPGDemo.Character
{
    /// <summary>
    /// 动画事件行为
    /// </summary>
    public class AnimationEventBehaviour
    {
        /// <summary>
        /// 动画组件
        /// </summary>
        private int anim;

        /// <summary>
        /// 攻击时使用
        /// </summary>
        public void OnAttack()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 撤销动画播放
        /// </summary>
        public void OnCancelAnim()
        {
            throw new System.NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件的使用案例_猫和老鼠
{
    class Program
    {
        static void Main(string[] args)
        {
            //猫 mao = new 猫();
            //老鼠 laoshu = new 老鼠();
            //mao.叫();
            //laoshu.逃跑();

            猫 mao = new 猫();
            老鼠 laoshu = new 老鼠();
            //步骤2：注册事件
            mao.叫+=new Handler(laoshu.逃跑);//添加老鼠跑行为
            //mao.叫-= laoshu.逃跑;
            //步骤4：
            mao.Notify();

            Console.Read();
        }
    }
    //1.1 定义一个委托
    delegate void Handler();//定义一个委托
    class 猫
    {
        //public void 叫()
        //{
        //    Console.WriteLine("miaomiao");
        //}
        //步骤1.2：定义事件
        //public event Handler 叫;
        public Handler 叫;
        //步骤3：触发事件 固有的写法
        public void Notify()
        { 
            if(叫!=null)//判断事件有没有执行
            {
                Console.WriteLine("miaomiao");
                叫();//调用事件的方法
            }
        }

    }
    class 老鼠
    {

        public void 逃跑()//老鼠逃跑行为
        {
            Console.WriteLine("jiji。。。。");
        }
    }
}

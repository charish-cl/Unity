using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateUse1
{
    class Program
    {
        static void Main1(string[] args)
        {
            A aObj = new A();
            //2>得到委托对象=实例化委托 写法

            //Handler handerObj = aObj.F1;
            //aObj.F2(handerObj);

            //aObj.F2(aObj.F1);

            //aObj.F2(() => {
            //    Console.WriteLine("明天休息");
            //    Console.WriteLine("后天是元旦");           
            //});

            aObj.F2(() =>Console.WriteLine("后天是元旦"));

            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            A aobj = new A();
            //aobj.F1();//
            aobj.Fun(() => { Console.WriteLine("调用时确定：下班晚了，超市买菜！"); });

            Console.ReadKey();
        }
    }

    //定义端
    class A
    {
        public void F1()
        {
            Console.WriteLine(111);
            Console.WriteLine(2222);
        }
        public void F2(Handler handerObj)
        {
            //3>
            handerObj();
            Console.WriteLine("aaa");
            Console.WriteLine("bbbb");
        }

        public void Fun(HandlerBuyWhere buy)
        { 
            //买菜 从哪里买？  做饭 
            buy();
            Console.WriteLine("定义是能确定的 做饭 :西红柿炒鸡蛋");
            
        }
        
    }
    //1>
    delegate void Handler();

    delegate void HandlerBuyWhere();
}

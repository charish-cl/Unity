using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异步调用
{
    class Program
    {
        static Handler handlerObj = null;
        static void Main(string[] args)
        {
            //同步调用=一个完，才能另一个 阻塞
            //A obja = new A();
            //obja.F1big();
            //obja.F2();

            //异步调用方式很多：1 委托【封装】2多线程【直接使用】
            //2>实例化委托
            A obja = new A();
            handlerObj = new Handler(obja.F1big);
            //3>开始异步调用
            // AsyncCallback参数 要指定一个方法来取结果！           
            handlerObj.BeginInvoke(new AsyncCallback(FunGetRe), null);

            obja.F2();
            Console.ReadKey();
        }
        //定义一个取 结果的方法
        //IAsyncResult 看做 服务员【监控器】
        static void FunGetRe(IAsyncResult ar)
        {
            bool re = ar.IsCompleted;
            // 4>结束异步调用【如果有返回值 可以取返回值】
            if (re)            
            {
                handlerObj.EndInvoke(ar);
                Console.WriteLine("IsCompleted");
            }
        }
    }
    class A
    {
        public void F1big()
        {
            System.Threading.Thread.Sleep(3000);//3001，4000
            Console.WriteLine("1111111111");
        }
        public string F2big(int a)
        {
            System.Threading.Thread.Sleep(3000);//3001，4000
            Console.WriteLine("big big");
            return a.ToString();
        }
        public void F2()
        {
            Console.WriteLine("222222");
        }
    }
    //1>定义相应的委托
    delegate  void Handler ();
}

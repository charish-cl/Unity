using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate2
{
    //调用端
    class DelagateDemo1
    {
        static void Main2(string[] args)
        {
            //步骤2:实例化委托
            CalHandler handlerObj = new CalHandler(Add);
            handlerObj = handlerObj + new CalHandler(Divide);
            //步骤3:调用委托
            int re=handlerObj(6,2);
        }
       static  public int Add(int a,int b)
        {
            return a + b;
       }
       static public int Divide(int a, int b)
       {
           return a/b;
       }   
       
    }
    //定义端
    //步骤1：声明委托，定义委托   
    delegate int CalHandler(int a, int b);
    class A
    {
        public static void F()
        {
            Console.WriteLine("委托的使用步骤");
        }

    }
   
    
}

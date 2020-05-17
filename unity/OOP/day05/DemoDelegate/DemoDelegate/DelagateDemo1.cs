using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate1
{
    //调用端
    class DelagateDemo1
    {
        static void Main1(string[] args)
        {
            //步骤2:实例化委托
            Handler handlerObj = new Handler(F1);
            //步骤3:调用委托
            handlerObj();
        }
       static  public void F1()
        { 
       
       }
       

       
    }
    //定义端
    //步骤1：声明委托，定义委托
    delegate void Handler();
    //delegate int CalHandler(int a, int b);
    class A
    {
        public static void F()
        {
            Console.WriteLine("委托的使用步骤");
        }

    }
   
    
}

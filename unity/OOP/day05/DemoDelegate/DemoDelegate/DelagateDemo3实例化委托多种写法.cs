using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate3
{
    //调用端
    class DelagateDemo3
    {
        static void Main1(string[] args)
        {
            //步骤2:实例化委托

            //写法1,2 先定义好【要 绑定的】方法
            //Handler handlerObj = new Handler(F1);//写法1
            //Handler handlerObj = F1;//写法2   F1委托对象

            //写法3,4 不需要定义好【要 绑定的】方法 ，方法在**心中**定义好  
            //Handler handlerObj = delegate() 
            //{
            //    Console.WriteLine(1);
            //    Console.WriteLine(2);
            //};
            //写法 4 不需要定义好【要 绑定的】方法 ，方法在**心中**定义好
            Handler handlerObj = () =>
            {
                Console.WriteLine(1);
                Console.WriteLine(2);            
            };
            //步骤3:调用委托
            handlerObj();
        }
        static public void F1()
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

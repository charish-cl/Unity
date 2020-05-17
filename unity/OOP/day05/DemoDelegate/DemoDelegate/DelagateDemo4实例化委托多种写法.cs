using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate4
{
    //调用端
    class DelagateDemo4
    {
        static void Main2(string[] args)
        {
            //步骤2:实例化委托

            //写法1,2 先定义好【要 绑定的】方法
            //Handler handlerObj = new Handler(Add);//写法1
            //Handler handlerObj = Add;//写法2   F1委托对象

            //写法3,4 不需要定义好【要 绑定的】方法 ，方法在**心中**定义好  
            //Handler handlerObj = delegate(int x,int y)
            //{
            //    int re = x + y;
            //    re = re * x;
            //    return re;
            //};
            //写法 4 不需要定义好【要 绑定的】方法 ，方法在**心中**定义好
            //Handler handlerObj = (int x, int y) =>
            //{
            //    int re = x + y;
            //    re = re * x;
            //    return re;
            //};
            //Handler handlerObj = (me, you) =>
            //{
            //    int re = me + you;
            //    re = re * me;
            //    return re;
            //};
            //Handler handlerObj = (me, you) =>
            //{
            //    return (me + you) * me;
            //};
            Handler handlerObj = (a, b) =>(a + b) * a;
          //步骤3:调用委托
            int returnValue=handlerObj(6,2);
        }
        //static public int Add(int a,int b)
        //{
        //    return a + b;
        //}
    }
    //定义端
    //步骤1：声明委托，定义委托   
    delegate int Handler(int a, int b);

   
    
}

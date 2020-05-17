using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prj2ClassLibrary1;

namespace Prj1
{

    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("这是一个两数相加的程序：");
            //2获得输入：提示，获得输入
            Console.WriteLine("请输入加数：");
            string s = Console.ReadLine();
            Console.WriteLine("请输入被加数：");
            string s2 = Console.ReadLine();
            //3处理
            int a = Convert.ToInt32(s);
            int a2 = Convert.ToInt32(s2);
            int re=0;
            AddClass obj = new AddClass();
            re = obj.Add(a, a2);
            //4输出 
            Console.WriteLine("计算的结果是："+re);
            Console.ReadKey();

            
        }
    }

    
}

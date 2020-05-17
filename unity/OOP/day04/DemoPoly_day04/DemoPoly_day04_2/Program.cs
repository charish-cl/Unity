using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoly_day04_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class A
    {
        //F1方法的实现 是否有分子类需要
        //所有的子类都不用，都要全部重写！ 写成抽象的
        //有些子类要用，那就写成虚的。
        //全部重写-扩展重写
        virtual public void F1()
        {
            Console.WriteLine("aaaaa");
        }
    }
    class B : A
    {
        public override void F1()
        {
            base.F1();//父类中的我需要
            Console.WriteLine("bbbbbb");
        }
    }
    class C : A
    { 
    
    }
}

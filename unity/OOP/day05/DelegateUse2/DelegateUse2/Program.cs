using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUse2
{
    //需求 回家                做事情(？复习，看电视，玩游戏，聊天)
    //      唯一，能确定的  不确定的

    //调用端
    class Program
    {
        static void Main(string[] args)
        {
            //版本1，2
            //Student stu = new Student();
            //stu.GoHome();
            //stu.Dowork();
            //版本3 
            //Student stu = new Student();
            //IDowork dowork=new My2();
            //stu.GoHome(dowork);
            //需求多变-代码膨胀
            //版本4
            Student stu = new Student();
            stu.Gohome(() => Console.WriteLine("复习"));

            Console.ReadKey();
        }
    }
    //定义端
    //需求1》需求2 开闭原则 》需求3

    //版本1  数据类型急剧增加！ 
    /*
    class Student
    {
        public void GoHome()
        {
            Console.WriteLine("回家");
        }
        public void Dowork()
        {
            Console.WriteLine("复习！");
        }
    }
    class Student2 : Student
    {
        public void Dowork()
        {
            Console.WriteLine("看电视！");
        }
    }
    //class Student3
    */
    /*
    //版本2  数据类型急剧增加！ 
    //变化的提取单独封装
    interface IDowork
    {
        void Dowork();
    }
    class Student : IDowork
    {
        public void GoHome()
        {
            Console.WriteLine("回家");
        }
        public void Dowork()
        {
            Console.WriteLine("复习！");
        }
    }
    //class Student2
     */
    //版本3 
    /*
    interface IDowork
    {
        void Dowork();
    }
    class Student 
    {
        public void GoHome(IDowork dowork)
        {
            Console.WriteLine("回家");
            dowork.Dowork();
        }
    }
    class My : IDowork
    {
        public void Dowork()
        {
            Console.WriteLine("复习");
        }
    }
    class My2 : IDowork
    {
        public void Dowork()
        {
            Console.WriteLine("看电视");
        }
    }
     */
    //版本4 使用委托做参数
    class Student
    {
        public void Gohome(DoworkHandler handler)
        {
            //能确定的 唯一 不变的
            Console.WriteLine("回家");
            //不能确定 多样的 变化
            handler();
        }
    }
    delegate void DoworkHandler();
}

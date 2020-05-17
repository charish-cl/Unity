using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    //调用端
    class Demo1
    {
        static void Main1(string[] args)
        {
            Animal obj = new Animal();
            obj.Walk();// 写法1

            Dog obj2 = new Dog();
            obj2.Walk();// 写法2

            Animal obj3 = new Dog(); //复用概念
            obj3.Walk();//// 写法3
        }
    }
    //定义端
    class Animal 
    {

        public void Walk()
        {
            //Console.WriteLine("Animal  Walk....");
            Console.WriteLine("动物走....");
        }
    }
    class Dog : Animal//:Object
    { 
    
    }
}

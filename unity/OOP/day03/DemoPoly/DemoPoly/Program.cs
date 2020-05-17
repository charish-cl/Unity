using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoly
{
    class Program
    {
        static void Main1(string[] args)
        {
            //简单 继承
            //调用run方法 
            Animal obj1 = new Animal();
            obj1.Run();
            Dog obj2 = new Dog();
            obj2.Run();
            Animal obj3 = new Dog();
            obj3.Run();         

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //简单 继承 ? 然后隐藏或者重写
            //调用run方法 
            //Animal obj1 = new Animal();
            //obj1.Run();

            //Dog obj2 = new Dog();
            //obj2.Run();

            //Animal obj3 = new Dog();//隐藏(父的）  
            //                                          //重写（子的：声明父new子调子=父调子）
            //obj3.Run();

            //PegDog p = new PegDog();
            //p.Run();
            A obj = new A();

            Console.ReadKey();
        }
    }
    //
    class Animal
    {
         virtual public void Run()
        {
            Console.WriteLine("Animal run.....");
        }
    
    }
    class Dog : Animal
    {
        sealed override public void Run()
        {
            Console.WriteLine("Dog run.....");
        }
        public void WaWa()
        { 
        
        }
    }
    class PegDog : Dog
    {
        //public override void Run()
        //{
        //    //base.Run();
        //    Console.WriteLine("PegDog run.....");
        //}
    }

    sealed  class A { }
   // class B : A { }
}

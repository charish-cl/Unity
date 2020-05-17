using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoly_day04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal obj = null;// new Animal();
            //obj = new Dog();

            //Animal[] arr = new Animal[2];
            //arr[0] = new Dog();
            //arr[1] = new Cat();
            ////调用 炸弹 爆炸了
            //foreach (Animal a in arr)
            //{
            //    a.Call();
            //}
            Console.ReadLine();


        }
    }
    //定义端
    abstract class Animal
    {
        int id;
        string name;
        public abstract  void Run();
        abstract public void Walk();      
    }
    class Dog : Animal
    {
        override public void Run() //
         {
             throw new NotImplementedException();
         }
         public override void Walk()
         {
             throw new NotImplementedException();
         }
    }
    class PegDog : Dog
    {
        public override void Run()
        {
            base.Run();
        }
    }


}
    

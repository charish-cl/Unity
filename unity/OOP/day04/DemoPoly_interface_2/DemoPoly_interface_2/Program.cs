using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoly_interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hawk hawk = new Hawk();
            //一定程度的避免了接口的污染！ 无法彻底避免
           
            IAction hawk2 = new Hawk();
            hawk2.Swimm();

            Animal obj = new Animal();
            obj.Run();

            Dog obj2 = new Dog();  //2        
            obj.Eat();//

            Animal obj3 = new Dog(); //维护性好
            obj3.Eat();//
        }
    }
    // 鸟 老鹰 麻雀 鸵鸟  企鹅
   abstract  class Bird
    {
        int Leg;
        string feather;
       public abstract void Game();

    }
   interface IAction
   {
       void Walk();
       void Fly();
       void Swimm();
   }
   class Hawk : Bird, IAction
   {
       public override void Game()
       {
           throw new NotImplementedException();
       }
       public void Walk() { }
       public void Fly() { }
       void IAction.Swimm() { }
   }
   interface IA { void F(); void F1();}
   interface IB { void F(); void F2();}

   class My : IA, IB
   {
       void IA.F() { }//
       void IB.F() { }//
       public void F1() { }
       public void F2() { }
   }
   class Animal 
   { 
       public void Run() { }
       virtual public void Eat()
         { }
   }
   class Dog : Animal 
   { 
        public void Walk() { }
        public override void Eat()
        {
      
         }
   }
}

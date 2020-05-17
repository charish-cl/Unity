using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPublicPrivate
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    class A
    {
        int id;
        void F() { }
    
    }
    class Animal
    {
        public void F1()
        { }
        protected void F2()
        { }
    }
    class Dog : Animal
    {
        void FF()
        {
            //Animal obj = new Animal();
            //obj.F1();
            //obj.F2();
            base.F2();
            F2();//

            base.F1();
        }
    }
}

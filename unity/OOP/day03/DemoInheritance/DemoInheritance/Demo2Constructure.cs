using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Constructure
{
    //调用端
    class Demo1
    {
        static void Main(string[] args)
        {
           // Animal obj = new Animal();
         
           // Dog obj2 = new Dog(888);

            ClassRoom room1 = new ClassRoom();

            ClassRoom room2 = new ClassRoom("php");
           
        }
    }
    //定义端
    //class MyObject
    //{
    //    public MyObject()
    //    { 
        
    //    }
    //}
    class Animal
    {

        //public Animal()
        //{

        //}
        public Animal(int id)
        {
            this.id = id;
        }
        int id;
    }
    class Dog : Animal//:Object
    {
        public Dog(int id):base(id)
        { 
        
        }
    }

    class ClassRoom
    {
        string ev;
        string a;
        string b;
        public ClassRoom()
        {
            ev = "unity";
            //a = "aa";
        }
        public ClassRoom(string ev):this()
        {
            this.ev = ev;
            //b = "bbb";
        }
        //public ClassRoom()
        //{
        //    a = "aa";
        //    b = "bb";
        //}
    }
}

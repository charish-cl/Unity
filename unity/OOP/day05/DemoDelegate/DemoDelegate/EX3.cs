using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    //
    class EX3
    {
        static void Main33()
        { 
              
            //2> 4种写法
            //Handler handlerObj = new Handler(Fun);//111
            //Handler handlerObj = Fun;//222
            //Handler handlerObj = delegate(Person p) { ///333
            //    return p.Age;
            //};
            Handler handlerObj =p=>p.Age; //444
            //3>
            Person person=new Person(){
             Id=1, Name="aa", Age=20
            };
            int re = handlerObj(person);

        }
        //static int Fun(Person p)
        //{
        //    return p.Age;
        //}
    }
    //定义端 1>
    public delegate int Handler(Person p); //从一个对象中选一个属性的值 Person id或age
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}

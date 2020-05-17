using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate444
{
    //
    class EX4
    {
        static void Main()
        { 
              
            //2> 4种写法
            //Handler handlerObj = new Handler(Fun);//111
            //Handler handlerObj = Fun;//222
            //Handler handlerObj = delegate(List<Person> list, int id)
            //{
            //    Person person = null;
            //    foreach (var p in list)
            //    {
            //        if (p.Id == id)
            //        {
            //            person = p;
            //            break;
            //        }
            //    }
            //    return person;
            
            //};
            Handler handlerObj = (list, id) =>
            {
                Person person = null;
                foreach (var p in list)
                {
                    if (p.Id == id)
                    {
                        person = p;
                        break;
                    }
                }
                return person;
            
            }; //444
            
            //3>  
            List<Person> arr = new List<Person> 
            { 
                new Person(){Id = 1,Name = "aa",Age = 20},
                new Person(){Id = 2,Name = "bb",Age = 22}
            };
            var re = handlerObj(arr, 2);

        }
        //static Person Fun(List<Person> list, int id)
        //{
        //    Person person = null;
        //    foreach (var p in list)
        //    {
        //        if (p.Id == id)
        //        {
        //            person = p;
        //            break;
        //        }
        //    }
        //    return person;
        //}
    }
    //定义端 1>
   public  delegate  Person Handler(List< Person> list,int id);
    //从一个集合中选择编号=id的那个对象
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}

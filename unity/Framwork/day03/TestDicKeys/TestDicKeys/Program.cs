using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDicKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Animal>> cache = new Dictionary<string, List<Animal>>();

            cache.Add("d", new List<Animal>());
            cache["d"].Add(new Dog());
            cache["d"].Add(new Dog());

            cache.Add("c", new List<Animal>());
            cache["c"].Add(new Dog());
            cache["c"].Add(new Dog());

            //List<string> keys = new List<string>(cache.Keys);
            
            //string[] arr=new string[cache.Keys.Count];
            //cache.Keys.CopyTo(arr, 0);//开发 折腾！代码 
        }
    }
    class Animal
    { 
        
    }
    class Dog : Animal
    { }
    class Cat : Animal
    { }
}

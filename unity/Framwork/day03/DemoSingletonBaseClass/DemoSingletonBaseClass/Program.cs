using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingletonBaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = Student.instance;
        }
    }
   abstract  class Animal
    {
        //private Animal()
        //{ }
    
    }
    class Dog : Animal
    {
    
    }
}

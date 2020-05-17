using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenric2
{
    class GenricBase2
    {
        static void Main11()
        {
            //My<int> my1 = new My<int>();
            //My<NormalizationForm> my11 = new My<NormalizationForm>();

            //My<string> my2 = new My<string>();
            My<Dog> my3 = new My<Dog>();
        
        }
    }
    //class My<T> where T:struct //值类型：枚举 结构
    //{ 
    
    //}
    //class My<T> where T : class //引用类型：类，接口，委托
    //{

    //}
    class My<T> where T :Animal,IFly
    {

    }
    interface IFly
    { }
    class Animal
    { }
    class Dog:Animal,IFly { }
}

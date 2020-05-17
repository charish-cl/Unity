using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace DemoGenric
{
    class GenricBase1
    {
        static void Main2(string[] args)
        {
            My<int> myobj = new My<int>();
            myobj.Add(1);     //T 好 object好：
            //myobj.Add("aa");//更安全，第一时间告诉 放的不合适
            myobj.Add(2);     //不需要类型转换 性能更好； object<int 很多 性能
            myobj.Add(3);
            myobj.Add(4);
        }
        static void Main1(string[] args)
        {
            My<int> myobj = new My<int>();
            myobj.Add(1);

            My<String> myobj2 = new My<String>();
            myobj2.Add("aa");

            Your your1 = new Your();
            //your1.Add<int>(1);
            //your1.Add<int>(2);
            your1.Add(1);
            your1.Add(2);

        }

        static void Main3(string[] args)
        {
            string a = "aas";
            string b = "bb";
            Console.WriteLine(a);
            Console.WriteLine(b);
            My<string> my = new My<string>();
            my.Swap(ref a, ref b);
            //Fun????
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }

    //class My
    //{
    //    ArrayList arrList = new ArrayList();//
    //    public void Add(int i)
    //    {
    //        arrList.Add(i);
    //    }
    //}
    class My<T>
    {
        ArrayList arrList = new ArrayList();//
        public void Add(T i)
        {
            arrList.Add(i);
        }
        public void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    class Your
    {
        ArrayList arrList = new ArrayList();//
        public void Add<T>(T i)
        {
            arrList.Add(i);
        }
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}

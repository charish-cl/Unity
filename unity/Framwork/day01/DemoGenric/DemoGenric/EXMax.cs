using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenric3
{
    class EXMax
    {
        static void Main()
        {
            var re=My.Max(2, 5);
            var re2 = My.Max("aa", "bb");
        }
    }
    class My 
    {
        //static  public int Max(int a, int b)
        //{
        //    if (a.CompareTo(b) > 0)
        //        return a;
        //    else
        //        return b;
        //}
        static public T Max<T>(T a, T b) 
            where T : IComparable
        {
            if (a.CompareTo(b) > 0)
                return a;
            else
                return b;
        }
    
    }
}

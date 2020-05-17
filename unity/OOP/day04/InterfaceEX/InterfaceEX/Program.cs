using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace InterfaceEX
{
    class Program
    {
        static void Main1(string[] args)
        {
            //需求1：比较两个整数数据
            //需求2                   字符串 ：名单
            //需求3: 比较两个学生 年龄大  学习好 身高

            //需求1：比较两个整数数据
            //int a = 1;
            //int b = 2;
            ////bool re1 = a > b;
            //int re1=a.CompareTo(b);
            //需求2
            string a = "as";
            string b = "as";
            int re1 = a.CompareTo(b);

        }
        static void Main(string[] args)
        {
          
            //需求3: 比较两个学生 年龄大  学习好 身高
            Student zs = new Student 
            {  Name="zs", Age=20, Tall=200};
            Student ls = new Student
            {
                Name = "lisi",
                Age = 22,
                Tall = 160
            };
            //自定义对象的比较
            //写法1：
            //int re1 = zs.Age.CompareTo(ls.Age);


            //写法2： 希望使用写法2
            //一般做法 自定义的类 只选择一个属性去比较 实现比较接口
            //                            如果要比较其它属性 开闭原则 
            //                           实现另一个比较器

            //默认比较：年龄
            int re1 = zs.CompareTo(ls); //封装细节！
            //如果要比较其它属性
            TallCompare tallcom = new TallCompare();
            int re2=tallcom.Compare(zs, ls);

        }
    }

    class Student:IComparable
    {       
        public int Age { get; set; }
        public string Name { get; set; }
        public int Tall { get; set; }

        public int CompareTo(object obj)
        { 
            return this.Age.CompareTo((obj as Student).Age);
        }
    }

    class TallCompare : IComparer
    {
        public int Compare(object x, object y)
        {
             return  (x as Student).Tall.
                 CompareTo((y as Student).Tall);
        }
    }
}

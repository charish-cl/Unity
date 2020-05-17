using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//调用端 测试端：用来测试 方法是否正确
class Program
{
    static void Main1(string[] args)
    {
        //版本1
        //版本2
        //版本3
        var arr1 = new int[] { 1, 5, 3 };
        var arr2 = new string[] { "aa", "张三", "哈哈" };
        //ArrayHelper.OrderBy3(arr1);
        //ArrayHelper.OrderBy3(arr2);

        var arr3 = new Student[] 
        { 
            new Student{ Id=1, Name="aa", Age=20, Tall=200}, 
            new Student{ Id=2, Name="cc", Age=30, Tall=190}, 
            new Student{Id=3, Name="bb",  Age=25, Tall=180} 
        };
        //ArrayHelper.OrderBy3(arr3);//默认 按照年龄 如果想 ？身高？体重？。。。。任何属性 怎么做方便！
        //ArrayHelper.OrderBy3(arr3, new TallCompare());// 如果想 非默认？身高？体重？

       
    }
    static void Main()
    {
        //版本4  
        //证明 SelectHandler  使用        
        //SelectHandler<Student,int> handlerObj = (p) => p.Age;

        //Student zsObj=new Student{ Id=1, Name="aa", Age=20, Tall=200};
        //int re=handlerObj(zsObj);
        //************************
        var arr1 = new int[] { 1, 5, 3 };
        var arr2 = new string[] { "aa", "张三", "哈哈" };
        var arr3 = new Student[] 
        { 
            new Student{ Id=1, Name="aa", Age=11, Tall=200}, 
            new Student{ Id=2, Name="cc", Age=12, Tall=190}, 
            new Student{Id=3, Name="bb",  Age=20, Tall=180} 
        };

        //ArrayHelper.OrderBy(arr1, a =>a);
        //ArrayHelper.OrderBy(arr2, a =>a);
        //ArrayHelper.OrderBy(arr3, a => a.Age);
        //ArrayHelper.OrderBy(arr3, a => a.Name);
        //ArrayHelper.OrderBy(arr3, (a) => a.head);

       //var re1= ArrayHelper.Max(arr1, a => a);
       //var re2 = ArrayHelper.Max(arr2, a => a);
       //var re3 = ArrayHelper.Max(arr3, a => a.Age);
       //var re4 = ArrayHelper.Max(arr3, a => a.Name);

        //var re1 = ArrayHelper.Find(arr1, a => a==1);
        //var re2 = ArrayHelper.Find(arr2, a => a!="aa");
        //var re3 = ArrayHelper.Find(arr3, a => a.Age>20);
        //var re4 = ArrayHelper.Find(arr3, a => a.Name!="aa");

        //var re1 = ArrayHelper.FindAll(arr1, a => a == 1);
        //var re2 = ArrayHelper.FindAll(arr2, a => a != "aa");
        //var re3 = ArrayHelper.FindAll(arr3, a => a.Age > 20);
        //var re4 = ArrayHelper.FindAll(arr3, a => a.Name != "aa");

        //var re5 = ArrayHelper.FindAll(arr3, a => a.Age < 20&&a.Tall>180);

        var arrNew=ArrayHelper.Select(arr3, a => a.Tall);
    }
}
class Student//:IComparable<Student>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Tall { get; set; }
    public Head head { get; set; }

    //public int CompareTo(Student other)
    //{
    //    return this.Age.CompareTo(other.Age);
    //}
}
class Head//:IComparable<Head>
{ 

}
class TallCompare : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        return x.Tall.CompareTo(y.Tall);

    }
}

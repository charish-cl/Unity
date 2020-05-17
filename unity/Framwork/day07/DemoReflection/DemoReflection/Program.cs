using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;//

namespace DemoReflection
{
    class Program
    {
        static void Main1(string[] args)
        {
            //1得到Type类数据类型的对象！
            //Type typeObj = Type.GetType("DemoReflection.Student");
            //Type typeObj = (new Student()).GetType();
            Type typeObj = typeof(Student);
            //2	了解类型信息（查看类型信息，了解本身信息,成员信息）
            //或动态创建对象
            //或动态调用方法
            MemberInfo[] mArr= typeObj.GetMembers();
            //MemberInfo[] mArr2 = typeObj.GetMethods();
            //var re = typeObj.GetEvents();
        }

        static void Main(string[] args)
        {
            //1得到Type类数据类型的对象！
            Type typeObj = Type.GetType("DemoReflection.Student");           
            //2	动态【使用反射技术】创建对象//或动态调用方法
             //静态创建对象Student obj = new Student();
            object  obj=Activator.CreateInstance(typeObj);
            Student stuObj = (Student)obj;
            //动态【使用反射技术】调用方法
            MethodInfo method = typeObj.GetMethod("Test2");
            method.Invoke(stuObj, new Object[]{"ok:"});
            Console.ReadKey();
            
           }
    }
    class Student
    {
        public string Name = "ok";//使用反射调用Name
        public int Id { get; set; }
        public void Test()
        {
            Console.WriteLine("考试~！");
        }
        public void Test2(string a)
        {
            Console.WriteLine(a+"考试~！");
        }
    }
}

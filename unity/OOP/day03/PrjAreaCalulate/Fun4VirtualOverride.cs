using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjAreaCalulate4
{
   
    //调用端
    class Client
    {
    
        static void Main1(string[] args)
        {
            BeginCaculate();
            Console.ReadKey();
        }
       
       /// <summary>
       /// 作为任务的分发，以及交互
       /// </summary>
       static void BeginCaculate()
       {
           //1总体提示
           string info = "我可以帮你计算一个图形的面积,"+
               "我可以计算的图形包括：圆形1，矩形2和三角形3";
           Console.WriteLine(info);
           //2输入提示
           Console.WriteLine("请输入你要计算的图形");
           //3获得输入
           string type = Console.ReadLine();
           //4处理
           Shape shape = null;
           float re = 0;
           switch (type)
           {
               case "圆形":
               case "1":
                   Console.WriteLine("请输入半径");
                   float radius = int.Parse(Console.ReadLine());
                   shape = new Circle(radius);
                   re = shape.AreaCaculate();                    
                   break;
               case "矩形":
               case "2":
                   Console.WriteLine("请输入长");
                   float x = int.Parse(Console.ReadLine());
                   Console.WriteLine("请输入宽");
                   float y = int.Parse(Console.ReadLine());
                   shape = new Rectangle(x, y);
                   re = shape.AreaCaculate();                
                   break;
               case "三角形":
               case "3":
                   Console.WriteLine("请输入长");
                   float bottom = int.Parse(Console.ReadLine());
                   Console.WriteLine("请输入宽");
                   float height = int.Parse(Console.ReadLine());
                   shape = new Triangle(bottom, height);
                   re = shape.AreaCaculate();                     
                   break;
               default:
                   Console.WriteLine("输入错误,程序重新启动");                   
                   return;
           }
           Console.WriteLine("面积为" + re);
         
       }   
    
    }
   
    //定义端 》使用虚方法 重写
    class Shape
    {
        virtual public  float AreaCaculate()
        {
            return 0;
        }
    }
    class Circle:Shape
    {
        float r;
        public Circle(float r)
        {
            this.r = r;           
        }
        override  public float AreaCaculate()
        {
            return (float)Math.PI * r * r;
        }
    }
    class Rectangle:Shape
    {
        float l,w;
        public Rectangle(float l,float w)
        {
            this.l = l;
            this.w = w;    
        }
        override public float AreaCaculate()
        {
            return l * w;
        }
    }
    class Triangle: Shape
    {
        float b, h;
        public Triangle(float b, float h)
        {
            this.b = b;
            this.h = h;    
        }
        override public float AreaCaculate()
        {
            return b * h/2;
        }  
   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjAreaCalulate
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
            AreaClass areaClass = new AreaClass();
            float re = 0;
            switch (type)
            {
                case "圆形":
                case "1":
                    Console.WriteLine("请输入半径");
                    float radius = int.Parse(Console.ReadLine());
                    re= areaClass.AreaCaculate(radius);                    
                    break;
                case "矩形":
                case "2":
                    Console.WriteLine("请输入长");
                    float x = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入宽");
                    float y = int.Parse(Console.ReadLine());
                    re=areaClass.AreaCaculate(x, y);                  
                    break;
                case "三角形":
                case "3":
                    Console.WriteLine("请输入长");
                    float bottom = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入宽");
                    float height = int.Parse(Console.ReadLine());
                    re=areaClass.AreaCaculate(bottom, height, 0);                   
                    break;
                default:
                    Console.WriteLine("输入错误,程序重新启动");                   
                    return;
            }
            Console.WriteLine("面积为" + re);
        }         
    }
    //定义端 》复用  控制台 unity web
    public class AreaClass
    {   
        /// <summary>
        /// 计算园的面积
        /// </summary>
        /// <param name="radius">半径</param>
        public float AreaCaculate(float radius)
        {
            float area = (float)(radius * radius * Math.PI);
            return area;
        }
        /// <summary>
        /// 计算矩形面积
        /// </summary>
        /// <param name="x">长</param>
        /// <param name="y">宽</param>
        public float AreaCaculate(float l, float w)
        {
            float area = l * w;
            return area;
        }
        /// <summary>
        ///计算三角形面积  办法 1 改类型 int 精度一致！
        ///                                 2改公式 简单》复杂化！
        ///                                 3 精度一致+ 简单+【张三？】 加标识 加个参数 区别
        /// </summary>
        /// <param name="Bottom">底</param>
        /// <param name="height">高</param>
        /// <param name="value">这是个标识参数：取值随意</param>
        public float AreaCaculate(float Bottom, float height, int a = 0)
        {
            float area = Bottom * height * 0.5f;
            return area;           
          
        }
    }
}

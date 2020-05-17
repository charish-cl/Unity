using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChairMan zobj = new ChairMan();
            //ChairMan lobj = new ChairMan();

            ClassMonitor zobj = ClassMonitor.GetObj;
            ClassMonitor lobj = ClassMonitor.GetObj;

            int id = zobj.GetHashCode();
            int id2 = lobj.GetHashCode();

            bool b = id == id2;
        }
    }

    class ChairMan//总统 主席 饿汉模式
    { 
        //字段
        public string Name { get; set; }
        //方法

        //1>
        private ChairMan()
        { }
        //2>
        static private ChairMan obj = new ChairMan();
        //3> 提供 得到唯一对象 的唯一通道
        static public ChairMan GetObj()
        {
            return obj;//
        }
        
    }
    class President//总统 主席 懒汉模式
    {
        //字段
        public string Name { get; set; }
        //方法

        //1>
        private President()
        { }
        //2>
        static private President obj = null;
        //3> 提供 得到唯一对象 的唯一通道
        static public President GetObj()
        {
            if( obj==null)obj=new  President();
            return obj;//
        }
    }

    class ClassMonitor//班长
    {
        //字段
        public string Name { get; set; }
        //方法

        //1>
        private ClassMonitor()
        { }
        //2>
        static private ClassMonitor obj = null;
        //3> 提供 得到唯一对象 的唯一通道
        static public ClassMonitor GetObj
        {
            get {
                if (obj == null) obj = new ClassMonitor();                
                return obj;
            }
        }
    }


    class Singleton//单身，一个，单个
    {
        //字段
        public string Name { get; set; }
        //方法

        //1>
        private Singleton()
        { }
        //2>
        static private Singleton obj = null;
        //3> 提供 得到唯一对象 的唯一通道
        static public Singleton GetObj
        {
            get
            {
                if (obj == null) obj = new Singleton();
                return obj;
            }
        }
    }
}

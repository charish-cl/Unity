
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoly_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotherEye son = new Son2();
            son.Eye();
        }
    }
    interface ISwitch
    {
        void On();
        void Off();        
    }
    class Door : ISwitch
    {
       public void On() { }
       public void Off() { }
    }

    class Father { }
    class Mother { }
    interface IMotherEye { void Eye();}
    interface IMotherNose { }
    class Son : Father{ }

    class Son2 : Father, IMotherEye, IMotherNose
    {
        //1》	隐式实现 常用       
        //public void Eye() { }
        //2》	显式实现 很少用
        void IMotherEye.Eye() { }
    }

    interface IMy : IMotherEye
    {
        
    
    }
    //struct MyStruct : IMotherEye
    //{
    //    public void Eye() { }
    //}
    struct MyStruct 
    {
       
    }
}

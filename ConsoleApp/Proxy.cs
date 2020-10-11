using System;

namespace ConsoleApp
{
    abstract partial class Subject
    {
        public abstract void Request();//抽象类，类中不需要有内容，必须被强制重写
    }
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实的请求！！！");
        }
    }

    class Proxy : Subject
    {
        RealSubject realSubject;
        public Proxy(RealSubject realSubject) => this.realSubject = realSubject;
        public override void Request()
        {
            if (realSubject != null)
            {
                realSubject.Request();
            }
        }
    }

}
using System;

namespace ConsoleApp
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求");
        }
    }

    class Adaptee
    {
        public void SpecificRequest() => Console.WriteLine("特殊请求");
    }
    
    class Adapter:Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
using System;

namespace ConsoleApp
{
    /*
     * 桥接模式
     */
    public class Bridge
    {
        
    }

    abstract class Implementor
    {
        public abstract void Operator();
    }

    class ConcreteImplementorA:Implementor
    {
        public override void Operator()
        {
            Console.WriteLine("具体实现方法A的方法执行");
        }
    }

    class ConcreteImplementorB:Implementor
    {
        public override void Operator()
        {
            Console.WriteLine("具体实现方法B的方法执行");
        }
    }

    class Abstraction
    {
        protected Implementor _implementor;

        public void SetImplementor(Implementor implementor)
        {
            this._implementor = implementor;
        }

        public virtual void Operator()
        {
            _implementor.Operator();
        }
    }

    class RefinedAbstraction:Abstraction
    {
        public override void Operator()
        {
            _implementor.Operator();
        }
    }
}
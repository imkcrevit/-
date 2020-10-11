using System;

namespace ConsoleApp
{
    abstract class Component
    {
        public abstract void Operation();
    }
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作！");
        }
    }
    abstract class Decorator : Component
    {
        protected Component _component;

        public void SetCompont(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            if (_component != null)
            {
                _component.Operation();
            }
        }
    }
    class ConcreteDecoratorA : Decorator
    {
        public string AddStates;
        public override void Operation()
        {
            base.Operation();
            AddStates = "New States";
            Console.WriteLine("具体对象A的操作方式");
        }
    }

    class ConcreteDeciratorB : Decorator
    {
        public void AddBehavior()
        {
            Console.WriteLine("behavor!!!");
        }
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
            Console.WriteLine("具体对象B的实现方法!");
        }
       
    }


    
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Composite:CComponent
    {
        private IList<CComponent> children = new List<CComponent>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(CComponent c)
        {
            children.Add(c);
        }

        public override void Remove(CComponent c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine((new string('-',depth))+name);
            foreach (CComponent child in children)
            {
                child.Display(depth+2);
            }
        }
    }

    abstract class CComponent
    {
        protected string name;
        public CComponent(string name) => this.name = name;

        public abstract void Add(CComponent c);
        public abstract void Remove(CComponent c);
        public abstract void Display(int depth);
    }

    class Leaf:CComponent
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(CComponent c)
        {
            Console.WriteLine("cannot add to a leaf");
        }

        public override void Remove(CComponent c)
        {
            Console.WriteLine("cannot remove a leaf");
            ;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+name);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }

    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }

    class ConcreteElementA:Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
            
        }
    }

    class ConcreteElementB:Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
            
        }
    }

    class ConcreteVisitor:Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} 被 {1} 访问",concreteElementA.GetType().Name,this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} 被 {1} 访问",concreteElementB.GetType().Name,this.GetType().Name);
        }
    }
    
    class ConcreteVisitor2:Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} 被 {1} 访问",concreteElementA.GetType().Name,this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} 被 {1} 访问",concreteElementB.GetType().Name,this.GetType().Name);
        }
    }

    class ObjectStructure
    {
        private IList<Element> elements = new List<Element>();

        public void Attach(Element element)
        {
            elements.Add(element);
        }

        public void Detach(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
        

    }
}
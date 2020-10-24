using System;

namespace ConsoleApp
{
    abstract class ChainOfResponsibilty
    {
        protected ChainOfResponsibilty successor;

        public void SetChainOfResponsilbility(ChainOfResponsibilty chainOfResponsibilty)
        {
            successor = chainOfResponsibilty;
        }

        public abstract void HandlerRequest(int request);
    }

    class ConcreteHandler:ChainOfResponsibilty
    {
        public override void HandlerRequest(int request)
        {
            if (request>=0&& request<10)
            {
                Console.WriteLine("{0} 处理请求 {1}",this.GetType().Name,request);
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }

    class ConcreteHandlerB:ChainOfResponsibilty
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} 处理请求 {1}",this.GetType().Name,request);
            }
            else if(successor !=null)
            {
                successor.HandlerRequest(request);
            }
            
        }
    }

    class ConcreteHandlerC:ChainOfResponsibilty
    {
        public override void HandlerRequest(int request)
        {
            if (request > 20 && request < 30)
            {
                Console.WriteLine("{0} 处理请求 {1}",this.GetType().Name,request);
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
            
        }
    }
}
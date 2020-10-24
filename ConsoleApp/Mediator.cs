using System;

namespace ConsoleApp
{
    abstract class Mediator
    {
        public abstract void Send(string message,Colleague colleague);
    }

    abstract class Colleague
    {
        protected Mediator _mediator;
        public Colleague(Mediator mediator) => _mediator = mediator;
    }

    class ConcreteMediator:Mediator
    {
        private ConcreteColleague _colleague1;
        private ConcreteColleague2 _colleague2;

        public ConcreteColleague Colleague1
        {
            set => _colleague1 = value;
        }

        public ConcreteColleague2 Colleague2
        {
            set => _colleague2 = value;
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else
            {
                _colleague1.Notify(message);
            }
        }
    }

    class ConcreteColleague:Colleague
    {
        public ConcreteColleague(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message,this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("同事1得到的信息是: "+ message);
        }
    }

    class ConcreteColleague2:Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            _mediator.Send(message,this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("同事2得到的信息是: "+message);
        }
        
    }
    
}
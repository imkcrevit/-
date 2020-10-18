using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp
{
    //状态模式
    abstract class State
    {
        public abstract void Handle(Content content);
    }

    class ConcreteStateA:State
    {
        public override void Handle(Content content)
        {
            content.State=new ConcreteStateB();
        }
    }

    class ConcreteStateB:State
    {
        public override void Handle(Content content)
        {
            content.State=new ConcreteStateA();
        }
    }

    internal class Content
    {
        private State _state;

        public Content(State state)
        {
            this._state = state;
        }

        public State State
        {
            get => _state;
            set { _state = value; Console.WriteLine("当前状态:"+_state.GetType().Name);}
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
    //example
    abstract class EState
    {
        public abstract void WriteProgram(Work work);
    }

    class Work
    {
        private EState _state;

        public Work(EState state)
        {
            _state = state;
        }

        private double _hour;

        public double Hour
        {
            get => _hour;
            set => _hour = value;
        }

        private bool _finish;

        public bool Finish
        {
            get => _finish;
            set => _finish = value;
        }

        public void SetState(EState state) => _state = state;//更换状态

        public void WriteProgram() => _state.WriteProgram(this);

    }
    class ForenoonState:EState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 12)
                Console.WriteLine("当前时间:{0}点 上午工作，精神百倍", work.Hour);
            else
                work.SetState(new NoonState()); work.WriteProgram();
        }
    }

    class NoonState:EState
    {
        public override void WriteProgram(Work work)
        {
            if(work.Hour<13)
                Console.WriteLine("当前时间: {0}点 午休，犯困");
            else
                work.SetState(new AfternoonState());
        }
    }

    class AfternoonState:EState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Finish)
                work.SetState(new ResetState());
            else
                Console.WriteLine("加班!");
        }
        
    }

    class ResetState:EState
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("当前时间: {0} 点，下班回家");
            
        }
    }
}
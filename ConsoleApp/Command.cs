using System;

namespace ConsoleApp
{
    abstract class Command
    {
        protected Receiver _receiver;
        public Command(Receiver receiver) => _receiver = receiver;
        abstract public void Execute();
    }

    class ConcreteCommand:Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            _receiver.Action();
        }
    }

    class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }

    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("执行请求");
        }
    }
}
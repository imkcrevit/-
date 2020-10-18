using System;

namespace ConsoleApp
{
    //备忘录，负责存储Originator对象的内部状态，病防治其他对象访问备忘录Memeneto
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string State
        {
            get => _state;//仅能够获取状态
        }
    }

    class Originator//发起人，创建一个备忘录Memento，用来记录当前时刻它的内部状态，并能回复状态
    {
        private string _state;

        public string State
        {
            get => _state;
            set { _state = value; }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void SetMemento(Memento memento)
        {
            _state = memento.State;
        }

        public void Show() => Console.WriteLine("State: " + _state);
    }
    //管理者，存储备忘录，但是不能对备忘录进行修改或操作
    class Caretaker
    {
        private Memento _memento;

        public Memento Memento
        {
            get => _memento;
            set => _memento = value;
        }
    }
}
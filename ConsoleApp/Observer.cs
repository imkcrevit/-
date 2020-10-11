using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    //观察者模式
    abstract class Observer
    {
        public abstract void Update();
    }
    /*
     * 通知类
     * 增加或移除观察者
     * 最终通过Notify方法输出结果
     * 使用委托时，增加或移除观察者类可以取消
     */
    delegate void SubjectHandler();//声明委托
    abstract class OSubject
    {
        private IList<Observer> _observers = new List<Observer>();

        public event SubjectHandler Update;//创建委托类Update
        //增加观察者
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        //移除观察者
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }
        
        //通知
        public void Notify()
        {
            Update();//调用委托
            // foreach (var observer in _observers)
            // {
            //     observer.Update();
            // }
        }
    }

    /*
     * 具体观察者，书中所讲老板或前台
     * 增加角色本身的状态
     */
    class ConcreteSubject : OSubject
    {
        private string subjectState;
        
        
        public string SubjectState
        {
            get => subjectState;
            set => subjectState = value;
        }
    }

    /*
     * 具体通知者，如书中所讲的摸鱼人员
     */
    class ConcreteObserver:Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject concreteSubject;//具体通知者
        

        public ConcreteObserver(string name, ConcreteSubject concreteSubject)
        {
            this.concreteSubject = concreteSubject;
            this.name = name;
        }
        
        public override void Update()
        {
            observerState = ConcreteSubject.SubjectState;//获取统治者状态
            Console.WriteLine("观察者{0}的新状态是{1}",name,observerState);
        }
        
       public ConcreteSubject ConcreteSubject
       {
           get => concreteSubject;
           set => concreteSubject = value;
       }
    }
    
    
}
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp
{
    class Program
    {
        //private static double money = 0.0d;
        static void Main(string[] args)
        {
            //Facade
           // Facade facade = new Facade();
           // facade.MethodA();
           //Builder
           // ConcreteBuilder1 builder1 = new ConcreteBuilder1();//建造者1
           // ConcreteBuilder2 builder2 = new ConcreteBuilder2();//建造者2
           // Director dir= new Director();//初始化指挥
           // dir.Construe(builder1);//传入建造者创建指定部件
           // var product1 = builder1.GetResult();
           // dir.Construe(builder2);
           // var product2 = builder2.GetResult();
           // product2.Show();
           // product1.Show();
           //Observer
           // ConcreteSubject subject = new ConcreteSubject();
           //  subject.Attach(new ConcreteObserver("X",subject));
           //  subject.Attach(new ConcreteObserver("Y",subject));
           //  ConcreteSubject subject2 = new ConcreteSubject();
           //  subject2.Attach(new ConcreteObserver("Z",subject2));
           //  subject.Update+=new SubjectHandler(new ConcreteObserver("X",subject).Update);
           //  subject.Update+=new SubjectHandler(new ConcreteObserver("Y",subject).Update);
           //  subject2.Update+=new SubjectHandler(new ConcreteObserver("Z",subject2).Update);
           //
           // subject.SubjectState = "is subject";
           // subject.Notify();
           //
           // subject2.SubjectState = "is subject2";
           // subject2.Notify();
           //AbstractFactory
           // const string dbName = "mysql";
           // User u = new User();
           // u.Name = "noName";
           // u.Id = 1;
           // AbstractFactory factory = new AbstractFactory();
           // var user = factory.CreateUser(dbName);
           // user.Insert(u);
           //State
           // Content c = new Content(new ConcreteStateA());
           // c.Request();
           // c.Request();
           // c.Request();
           // c.Request();
           //Adapter
           // Target target = new Adapter();
           // target.Request();
           //Memento
           //创建组织者，并赋值
           // Originator originator = new Originator();
           // originator.State = "On";
           // originator.Show();
           // //创建管理者，并存储备忘录
           // Caretaker  caretaker = new Caretaker();
           // caretaker.Memento = originator.CreateMemento();
           //  //修改组织者的值
           // originator.State = "Off";
           // originator.Show();
           // //还原为初始值
           // originator.SetMemento(caretaker.Memento);
           // originator.Show();
           //Composite
           // Composite site = new Composite("root");
           // site.Add(new Leaf("Leaf A"));
           // site.Add(new Leaf("Leaf B"));
           //
           // Composite comp = new Composite("Composite X");
           // comp.Add(new Leaf("Leaf XA"));
           // comp.Add(new Leaf("Leaf XB"));
           // site.Add(comp);
           //
           // Composite comp2 = new Composite("Composite XY");
           // comp2.Add(new Leaf("Leaf XYA"));
           // comp2.Add(new Leaf("Leaf XYB"));
           // comp.Add(comp2);
           //
           // site.Add(new Leaf("Leaf C"));
           //
           // Leaf leaf = new Leaf("Leaf D");
           // site.Add(leaf);
           //
           // site.Display(1);
           //Bridge
           // Abstraction abstraction = new RefinedAbstraction();
           // abstraction.SetImplementor(new ConcreteImplementorA());
           // abstraction.Operator();
           // abstraction.SetImplementor(new ConcreteImplementorB());
           // abstraction.Operator();
           //Command
           // Receiver re = new Receiver();
           // Command c = new ConcreteCommand(re);
           // Invoker i = new Invoker();
           // i.SetCommand(c);
           // i.ExecuteCommand();
           //ChainOfResponsibility
           // ConcreteHandler handle1 = new ConcreteHandler();
           // ConcreteHandlerB handle2 = new ConcreteHandlerB();
           // ConcreteHandlerC handle3 = new ConcreteHandlerC();
           // handle1.SetChainOfResponsilbility(handle2);
           // handle3.SetChainOfResponsilbility(handle3);
           // int[] resquests = {2, 5, 14, 22, 18, 3, 27, 20};
           // foreach (var i in resquests)
           // {
           //     handle1.HandlerRequest(i);
           // }
           //Mediator
           // ConcreteMediator m = new ConcreteMediator();
           // ConcreteColleague c1 = new ConcreteColleague(m);
           // ConcreteColleague2 c2   = new ConcreteColleague2(m);
           // m.Colleague1 = c1;
           // m.Colleague2 = c2;
           // c2.Send("吃过饭了，你那？");
           // c1.Send("没有那，一起？");
           //FlyWeight

           // int i = 22;
           // FlyWeightFactory f = new FlyWeightFactory();
           //
           // FlyWeight fx = f.GetFlyWeight("X");
           // fx.Operation(--i);
           //
           // FlyWeight fy = f.GetFlyWeight("Y");
           // fy.Operation(--i);
           //
           // FlyWeight fz = f.GetFlyWeight("Z");
           // fz.Operation(--i);
           //
           // FlyWeight uf = new UnSharedConcreteFlyWeight();
           // uf.Operation(--i);
           
           //Interpreter
           IContext context = new IContext();
           List<AbstractExpression> list = new List<AbstractExpression>();
           list.Add(new NonterminalExpression());
           list.Add(new TerminalExpression());
           list.Add(new TerminalExpression());
           
           foreach (var expression in list)
           {
               expression.Interpret(context);
           }
           
           // Visitor
           // ObjectStructure structure = new ObjectStructure();
           // structure.Attach(new ConcreteElementA());
           // structure.Attach(new ConcreteElementB());
           //
           // ConcreteVisitor v1 = new ConcreteVisitor();
           // ConcreteVisitor2 v2 = new ConcreteVisitor2();
           //
           // structure.Accept(v1);
           // structure.Accept(v2);
           
           //Singleton
           Singleton s1 = Singleton.GetInstance();
           Singleton s2 = Singleton.GetInstance();
           if (s1 == s2)
           {
               Console.WriteLine("两个对象是相同的实例");
           }
           Console.Read();
        }

        #region 策略模式 Strategy
        abstract class Strategy
        {
            public abstract void AlgorithmInterface();
        }

        class ConcreteStrategyA:Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("算法A实现!");
            }
        }

        class ConcreteStrategyB:Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("算法B实现!");
            }
        }

        class ConcreteStrategyC:Strategy
        {
            public override void AlgorithmInterface()
            {
                Console.WriteLine("算法C实现!");
            }
        }

        class Context
        {
            private Strategy _strategy;

            public Context(Strategy strategy)
            {
                this._strategy = strategy;
            }

            public void ContextInterface()
            {
                _strategy.AlgorithmInterface();
            }
            
        }

        #endregion
        
        
        
        #region 工厂模式

         class CashFactory
         {
            private static CashSuper ce;
             
            public CashFactory(string type)
            {
                ce = null;
                switch (type)
                {
                    case "正常收费":
                        ce = new CashNormal();
                        break;
                    case "满300-30":
                        ce = new CashReturn("300","30");
                        break;
                    case "打八折":
                        ce = new CashRebate("0.8");
                        break;
                }
            }

            public double ConTextInterface(double money)
            {
                return ce.AcceptCash(money);
            }
        }

         class CashContext
         {
             private CashSuper _cashSuper;

             public CashContext(CashSuper cashSuper)
             {
                 _cashSuper = cashSuper;
             }

             public double ContextInterface(double money)
             {
                 return _cashSuper.AcceptCash(money);
             }
             
             
         }
        //抽象类
        abstract class CashSuper
        {
            public abstract double AcceptCash(double money);
        }
        /// <summary>
        /// 正常收费
        /// </summary>
        class CashNormal:CashSuper
        {
            public override double AcceptCash(double money)
            {
                Console.WriteLine("收费: {0}",money);
                return money;
            }
        }
        /// <summary>
        /// 折扣时的费用
        /// </summary>
        class CashRebate:CashSuper
        {
            private double moneyRebate = 1d;
            /// <summary>
            /// 输入折扣额度
            /// </summary>
            /// <param name="moneyRebate"></param>
            public CashRebate(String moneyRebate)
            {
                this.moneyRebate = double.Parse(moneyRebate);
            }
            
            public override double AcceptCash(double money)
            {
                Console.WriteLine("收费:{0} 利率:{1}",money * moneyRebate,moneyRebate);
                return money * moneyRebate;
            }
        }
        /// <summary>
        /// 返利（300-30）
        /// </summary>
        class CashReturn:CashSuper
        {
            private double returnMoney = 0.0d;//返利金额
            private double targetMoney = 0.0d;//满减金额

            public CashReturn(string target,string re)
            {
                this.returnMoney = double.Parse(re);
                this.targetMoney = double.Parse(target);
            }
            public override double AcceptCash(double money)
            {
                if (money>=targetMoney)//用户获得返利条件
                {
                    double count = money / targetMoney;
                    double m = money - Math.Floor(count) * returnMoney;
                    Console.WriteLine("收费：{0} ，活动为满{1}减{2}",m,targetMoney,returnMoney);
                    return m;
                }
                else//没有达到返利条件
                {
                    return money;
                }
            }
        }

        #endregion
       
    }
}
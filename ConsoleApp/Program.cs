using System;

namespace ConsoleApp
{
    class Program
    {
        //private static double money = 0.0d;
        static void Main(string[] args)
        {
           TestPaperA tpa = new TestPaperA();
           tpa.TestQuestion1();
           TestPaperB tpb = new TestPaperB();
           tpb.TestQuestion1();
            Console.ReadLine();
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
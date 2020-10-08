using System.Net.NetworkInformation;

namespace ConsoleApp
{
    /*
     * 工厂模式，为每个类建立一个工厂方法
     * 开放-封闭原则：对于拓展是开放的，对于修改是封闭的
     * 相较于简单工厂模式，如果新增解决办法需要修改工厂类
     * 违背了开放封闭原则，在后期改动较大的情况下使用工厂
     * 办法要由于简单工厂办法
     */
    abstract class Operation
    {
        private double _num1;
        private double _num2;

        public double Num1
        {
            get => _num1;
            set => _num1 = value;
        }

        public double Num2
        {
            get => _num2;
            set => _num2 = value;
        }

        public abstract double GetResult();
    }

    class AddOperation:Operation
    {
        public override double GetResult()
        {
            return Num1 + Num2;
        }
    }

    class SubOperation:Operation
    {
        public override double GetResult()
        {
            return Num1 - Num2;
        }
    }
    interface IOperation
    {
        Operation CreatOperation();
    }
    class Factory
    {
        public class AddOperationFactory:IOperation
        {
            public Operation CreatOperation()
            {
                Operation operation = new AddOperation();
                return operation;
            }
        }
        public class SubOperationFactory:IOperation
        {
            public Operation CreatOperation()
            {
                Operation operation = new SubOperation();
                return operation;
            }
        }
        
    }
}
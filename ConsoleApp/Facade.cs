using System;

namespace ConsoleApp
{
    public class Facade
    {
        private SubSymbolOne _symbolOne;
        private SubSymbolTwo _symbolTwo;
        private SubSymbolThree _symbolThree;
        private SubSymbolFour _symbolFour;
        public Facade()
        {
            _symbolOne = new SubSymbolOne();
            _symbolTwo = new SubSymbolTwo();
            _symbolThree = new SubSymbolThree();
            _symbolFour = new SubSymbolFour();
        }

        public void MethodA()
        {
            _symbolOne.MethodOne();
            _symbolTwo.MethodTwo();
            _symbolFour.MethodFour();
        }

        public void MethodB()
        {
            _symbolThree.MethodThree();
        }
    }

    class SubSymbolOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系统方法一");
        }
    }

    class SubSymbolTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法二");
        }
    }

    class SubSymbolThree
    {
        public void MethodThree() => Console.WriteLine("子系统方法三");
    }

    class SubSymbolFour
    {
        public void MethodFour() => Console.WriteLine("子系统方法四");
    }
}
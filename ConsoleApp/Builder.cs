using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp
{
    /*
     * 抽象建造类，确定部件有几部分组成
     * 并生命一个活的结果的办法
     */
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("产品的结果是:\n");
            foreach (var part in parts)
            {
                    Console.WriteLine(part);
            }
        }
    }

    class ConcreteBuilder1:Builder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("MethodA");
        }

        public override void BuildPartB()
        {
            _product.Add("MethodB");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    class ConcreteBuilder2:Builder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("MethodC");
        }

        public override void BuildPartB()
        {
            _product.Add("MethodD");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    class Director
    {
        public void Construe(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
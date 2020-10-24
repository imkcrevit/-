using System;
using System.Collections;

namespace ConsoleApp
{ 
    abstract class FlyWeight
    {
        public abstract void Operation(int exterinsicatae);
    }

    class ConcreteFlyWeight:FlyWeight
    {
        public override void Operation(int exterinsicatae)
        {
            Console.WriteLine("具体FlyWeight: "+exterinsicatae);
        }
    }

    class UnSharedConcreteFlyWeight:FlyWeight
    {
        public override void Operation(int exterinsicatae)
        {
            Console.WriteLine("不共享的具体FlyWeight: " + exterinsicatae);
        }
    }

    class FlyWeightFactory
    {
        private Hashtable flyWeights = new Hashtable();

        public FlyWeightFactory()
        {
            flyWeights.Add("X",new ConcreteFlyWeight());
            flyWeights.Add("Y",new ConcreteFlyWeight());
            flyWeights.Add("Z",new ConcreteFlyWeight());
        }

        public FlyWeight GetFlyWeight(string key)
        {
            return (FlyWeight) flyWeights[key];
        }
        
    }
}
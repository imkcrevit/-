using System;

namespace ConsoleApp
{
    public class TemplateMethod
    {
        public void TestQuestion1()
        {
            Console.WriteLine("第一个题目的答案为：A：a,B:b,C:c,D:d");
            Console.WriteLine("answer:{0}",Answer1());
        }

        protected virtual string Answer1()
        {
            return "";
        }
        
    }

    class TestPaperA:TemplateMethod
    {
        protected override string Answer1()
        {
            return "A";
        }
    }

    class TestPaperB:TemplateMethod
    {
        protected override string Answer1()
        {
            return "C";
        }
    }
}
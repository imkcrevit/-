using System;

namespace ConsoleApp
{
   abstract class AbstractExpression
   {
      public abstract void Interpret(IContext context);
   }
   class NonterminalExpression:AbstractExpression
   {
      public override void Interpret(IContext context)
      {
         Console.WriteLine("非终端解释器");
      }
   }

   class TerminalExpression:AbstractExpression
   {
      public override void Interpret(IContext context)
      {
         Console.WriteLine("终端解释器");
      }
   }

   class IContext
   {
      private string _input;

      public string Input
      {
         get => _input;
         set => _input = value;
      }

      private string _output;

      public string Output
      {
         get => _output;
         set => _output = value;
      }
   }
}
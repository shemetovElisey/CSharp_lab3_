using System;
using System.Collections.Generic;

namespace CSharp_lab3
{
   public abstract class Expr
   {
      public abstract double Compute(IReadOnlyDictionary<string, double> variableValues);
      public abstract IEnumerable<string> Variables { get; protected set; }
      public abstract bool IsConstant { get; }
      public abstract bool IsPolynom { get; }
   }
}

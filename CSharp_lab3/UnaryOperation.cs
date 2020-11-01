using System.Collections.Generic;

namespace CSharp_lab3
{
	abstract class UnaryOperation : Expr
	{
		private Expr _arg;

		protected abstract double Calculate(double arg);

		public UnaryOperation(Expr arg)
		{
			_arg = arg;
		}

		public override double Compute(IReadOnlyDictionary<string, double> variableValues)
			=> Calculate(_arg.Compute(variableValues));
	}
}

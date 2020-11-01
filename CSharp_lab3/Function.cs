using System.Collections.Generic;
using System.Linq;

namespace CSharp_lab3
{
	abstract class Function : Expr
	{
		private Expr[] _args;

		protected abstract double Calculate(params double[] args);

		public Function(Expr[] args)
		{
			_args = args;
		}

		public override double Compute(IReadOnlyDictionary<string, double> variableValues)
			=> Calculate(_args.Select(x => x.Compute(variableValues)).ToArray());
	}
}

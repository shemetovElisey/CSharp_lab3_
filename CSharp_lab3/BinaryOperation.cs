using System.Collections.Generic;

namespace CSharp_lab3
{
	public abstract class BinaryOperation : Expr
	{
		private Expr _lhs;
		private Expr _rhs;

		protected abstract double Calculate(double lhs, double rhs);

		public BinaryOperation(Expr lhs, Expr rhs)
		{
			_lhs = lhs;
			_rhs = rhs;
		}

		public override double Compute(IReadOnlyDictionary<string, double> variableValues)
			=> Calculate(_lhs.Compute(variableValues), _rhs.Compute(variableValues));

	}
}

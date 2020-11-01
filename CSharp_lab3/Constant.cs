using System.Collections.Generic;

namespace CSharp_lab3
{
	public class Constant : Expr
	{
		private double _val;

		public Constant(double val)
		{
			_val = val;
		}

		public override bool IsConstant => true;

		public override bool IsPolynom => true;

		public override double Compute(IReadOnlyDictionary<string, double> variableValues) 
			=> _val;
	}
}

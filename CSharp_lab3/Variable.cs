using System.Collections.Generic;

namespace CSharp_lab3
{
	public class Variable : Expr
	{
		private string _var;

		public Variable(string name)
		{
			_var = name;
		}

		public override double Compute(IReadOnlyDictionary<string, double> variableValues) 
			=> variableValues[_var];
		
		public override bool IsConstant => false;

		public override bool IsPolynom => true;

		
	}
}

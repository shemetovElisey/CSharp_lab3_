using System;
namespace CSharp_lab3
{
	public class Summation : BinaryOperation
	{
		public Summation(Expr lhs, Expr rhs) : base(lhs, rhs)
		{ }

		public override bool IsConstant => throw new NotImplementedException();

		public override bool IsPolynom => throw new NotImplementedException();

		protected override double Calculate(double lhs, double rhs) => lhs + rhs;
	}
}

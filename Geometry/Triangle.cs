using System;

namespace Geometry
{
	public class Triangle : IFigure
	{
		public double SideA { get; private set; }
		public double SideB { get; private set; }

		public double SideC { get; private set; }

		public Triangle(double sideA, double sideB, double sideC) =>
			(SideA, SideB, SideC) = (sideA, sideB, sideC);

		public double Area()
		{
			var p = (SideA + SideB + SideC) / 2;
			return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
		}

		public bool IsRightTriangle
		{
			get
			{
				var result = SideA * SideA + SideB * SideB;
				if (result == SideC * SideC) return true;

				result = SideA * SideA + SideC * SideC;
				if (result == SideB * SideB) return true;

				result = SideB * SideB + SideC * SideC;
				if (result == SideA * SideA) return true;

				return false;
			}
		}
	}
}
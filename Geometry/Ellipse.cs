using System;

namespace Geometry
{
	public class Ellipse : Rectangle
	{
		public Ellipse(double width, double height) : base(width, height) { }

		public override double Area() => Width * Height * Math.PI;
	}
}
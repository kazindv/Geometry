using Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTest
{
	[TestClass]
	public class ÑalculationTest
	{
		[TestMethod]
		public void SumArrea()
		{
			var figures = new IFigure[]
			{
				new Rectangle(40, 25),
				new Ellipse(53, 89),
				new Triangle(12, 17, 25),
				new Circle(11.03),
				new Square(10)
			};

			var sumArea = 0d;

			foreach (var figure in figures)
			{
				sumArea += figure.Area();
			}

			Assert.AreEqual(1000 + 14818.892546983054 + 90 + 95.5522474172806 + 100, sumArea);
		}

		[TestMethod]
		public void IsRightTriangleTrue()
		{
			var triangle = new Triangle(6, 8, 10);
			Assert.AreEqual(true, triangle.IsRightTriangle);
		}

		[TestMethod]
		public void IsRightTriangleFalse()
		{
			var triangle = new Triangle(12, 17, 25);

			Assert.AreEqual(false, triangle.IsRightTriangle);
		}
	}
}
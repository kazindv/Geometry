namespace Geometry
{
	public class Rectangle : IFigure
	{
		protected double Width { get; set; }
		protected double Height { get; set; }

		public Rectangle(double width, double height) =>
			(Width, Height) = (width, height);

		public virtual double Area() => Width * Height;
	}
}
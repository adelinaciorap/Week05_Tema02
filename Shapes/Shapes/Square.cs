namespace Shapes
{
    public class Square : Shape
    {
        public Square(double lat)
            : base(lat, lat)
        {

        }

        public override double CalculateSurface()
        {
            double surface = this.Height * this.Width;
            return surface;
        }

    }
}




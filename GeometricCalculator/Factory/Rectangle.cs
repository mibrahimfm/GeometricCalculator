namespace GeometricCalculator.Factory
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override Shape CreateShape()
        {
            return new Rectangle();
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return (Height * 2) + (Width * 2);
        }

        public override string RequestNecessaryParametersForShape()
        {
            return "Inform Height and Width, in that order, one in each line";
        }
        public override void ReadNecessaryParametersForShape()
        {
            Height = int.Parse(Console.ReadLine());
            Width = int.Parse(Console.ReadLine());
        }
    }
}

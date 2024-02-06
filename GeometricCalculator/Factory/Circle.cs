namespace GeometricCalculator.Factory
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override double CalculateArea()
        {
            return PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * PI * Radius;
        }

        public override string RequestNecessaryParametersForShape()
        {
            return "Inform the Circle's radius:";
        }

        public override void ReadNecessaryParametersForShape()
        {
            Radius = int.Parse(Console.ReadLine());
        }
    }
}

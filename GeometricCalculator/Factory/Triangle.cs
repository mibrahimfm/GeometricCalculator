namespace GeometricCalculator.Factory
{
    public class Triangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public override Shape CreateShape()
        {
            return new Triangle();
        }

        public override double CalculateArea()
        {
            double sp = CalculateSemiPerimeter();
            return Math.Sqrt(sp * (sp - SideA) * (sp - SideB) * (sp - SideC));
        }

        private double CalculateSemiPerimeter()
        {
            return CalculatePerimeter() / 2;
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public override string RequestNecessaryParametersForShape()
        {
            return "Inform the size of the 3 triangle sizes, one by line";
        }

        public override void ReadNecessaryParametersForShape()
        {
            SideA = int.Parse(Console.ReadLine());
            SideB = int.Parse(Console.ReadLine());
            SideC = int.Parse(Console.ReadLine());
        }
    }
}

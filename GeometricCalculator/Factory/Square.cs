namespace GeometricCalculator.Factory
{
    public class Square : Shape
    {
        public int Size { get; set; }

        public override double CalculateArea()
        {
            return Size * Size;
        }

        public override double CalculatePerimeter()
        {
            return Size * 4;
        }

        public override string RequestNecessaryParametersForShape()
        {
            return "Inform size of the square";
        }

        public override void ReadNecessaryParametersForShape()
        {
            Size = int.Parse(Console.ReadLine());
        }
    }
}

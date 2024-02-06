namespace GeometricCalculator.Factory
{
    public abstract class Shape
    {
        public const double PI = 3.1415;
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public abstract string RequestNecessaryParametersForShape();
        public abstract void ReadNecessaryParametersForShape();

        public override string ToString()
        {
            return $"Area: {CalculateArea():F2} \nPerimeter: {CalculatePerimeter():F2}";
        }
    }
}

namespace GeometricCalculator.Factory.Creator
{
    public abstract class ShapeCreator
    {
        public abstract Shape Create();
        public virtual string FillShapeInformationAndPrintShape()
        {
            var s = Create();
            Console.WriteLine(s.RequestNecessaryParametersForShape());
            s.ReadNecessaryParametersForShape();
            return s.ToString();
        }
    }
}

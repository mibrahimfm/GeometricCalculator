namespace GeometricCalculator.Factory.Creator
{
    public class TriangleCreator : ShapeCreator
    {
        public override Shape Create()
        {
            return new Triangle();
        }
    }
}

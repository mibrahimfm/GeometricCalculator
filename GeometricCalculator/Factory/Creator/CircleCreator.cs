namespace GeometricCalculator.Factory.Creator
{
    public class CircleCreator : ShapeCreator
    {
        public override Shape Create()
        {
            return new Circle();
        }
    }
}

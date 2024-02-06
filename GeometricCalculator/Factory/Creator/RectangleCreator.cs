namespace GeometricCalculator.Factory.Creator
{
    public class RectangleCreator : ShapeCreator
    {
        public override Shape Create()
        {
            return new Rectangle();
        }
    }
}

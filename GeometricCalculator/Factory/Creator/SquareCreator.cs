namespace GeometricCalculator.Factory.Creator
{
    public class SquareCreator : ShapeCreator
    {
        public override Shape Create()
        {
            return new Square();
        }
    }
}

// See https://aka.ms/new-console-template for more information
using GeometricCalculator.Exceptions;
using GeometricCalculator.Factory.Creator;

Console.WriteLine("Select shape: \n 1 - Square\n 2 - Circle\n 3 Rectangle\n 4 - Triangle");
int shapeSelected = int.Parse(Console.ReadLine());
ShapeCreator creator;

switch (shapeSelected)
{
    case 1:
        creator = new SquareCreator();
        break;
    case 2:
        creator = new CircleCreator();
        break;
    case 3:
        creator = new RectangleCreator();
        break;
    case 4:
        creator = new TriangleCreator();
        break;
    default:
        throw new NonExistentShapeException("Informed shape does not exist");
}

Console.WriteLine(creator.FillShapeInformationAndPrintShape());
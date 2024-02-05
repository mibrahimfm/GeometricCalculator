// See https://aka.ms/new-console-template for more information
using GeometricCalculator.Exceptions;
using GeometricCalculator.Factory;

Console.WriteLine("Select shape: \n 1 - Square\n 2 - Circle\n 3 Rectangle\n 4 - Triangle");
int shapeSelected = int.Parse(Console.ReadLine());
Shape shape;

switch (shapeSelected)
{
    case 1:
        shape = new Square();
        break;
    case 2:
        shape = new Circle();
        break;
    case 3:
        shape = new Rectangle();
        break;
    case 4:
        shape = new Triangle();
        break;
    default:
        throw new NonExistentShapeException("Informed shape does not exist");
}

Console.WriteLine(shape.RequestNecessaryParametersForShape());
shape.ReadNecessaryParametersForShape();

Console.WriteLine(shape.ToString());
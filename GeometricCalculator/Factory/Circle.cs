using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator.Factory
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override Shape CreateShape()
        {
            return new Circle();
        }

        public override double CalculateArea()
        {
            return PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * PI * Radius;
        }

        public override string RequestNecessaryParametersForShape()
        {
            return "Inform the Circle's radius:";
        }

        public override void ReadNecessaryParametersForShape()
        {
            Radius = int.Parse(Console.ReadLine());
        }
    }
}

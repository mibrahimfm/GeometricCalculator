using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator.Exceptions
{
    public class NonExistentShapeException : Exception
    {
        public NonExistentShapeException() : base() { }

        public NonExistentShapeException(string message) : base(message) { }
    }
}

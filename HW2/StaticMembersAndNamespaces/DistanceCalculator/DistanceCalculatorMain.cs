using System;
using EuclidianSpace;

namespace DistanceCalculator
{
    class DistanceCalculatorMain
    {
        static void Main()
        {
            Point3D a = new Point3D(1, 1, 1);
            Point3D b = new Point3D(3.23, 4, 1);
            Console.WriteLine(DistanceCalculator.CalculateDistance(a, b));
        }
    }
}

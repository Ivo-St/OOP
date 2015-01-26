using System;
using EuclidianSpace;
namespace DistanceCalculator
{
    static class DistanceCalculator
    {
        public static double CalculateDistance (Point3D a, Point3D b)
        {
            double diffX = a.X - b.X,
                diffY = a.Y - b.Y,
                diffZ = a.Z - b.Z;
            return Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2) + Math.Pow(diffZ, 2));
        }
    }
}

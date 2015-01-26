namespace EuclidianSpace
{
   public class Point3D
    {
        private static readonly double startX=0;
        private static readonly double startY=0;
        private static readonly double startZ=0;
        public double X { set; get; }
        public double Y { set; get; }
        public double Z { set; get; }
        public static double[] StartPoint
        {
            get
            {
                return new double[3] { startX, startY, startZ };
            }
        }
        public Point3D(double x=0, double y=0, double z=0)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return "(" + X + ", " + Y + ", " + Z + ")";
        }
    }
}

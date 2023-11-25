using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleMesh
{
    public class MyPoint3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Vector3D NormVector { get; set; }

        public MyPoint3D(int x, int y, int z, bool calcNorm = false)
        {
            X = x;
            Y = y;
            Z = z;

            if (calcNorm)
                NormVector = Vector3D.CaclculateNormVector(X, Y, Z);
        }

        public MyPoint3D(int x, int y, int z, Vector3D vec)
        {
            X = x;
            Y = y;
            Z = z;
            NormVector = vec;
        }

        public static double DistanceTo(MyPoint3D pointA, MyPoint3D pointB)
        {
            double deltaX = pointB.X - pointA.X;
            double deltaY = pointB.Y - pointA.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        public double DerivativeVector(MyPoint3D Vector)
        {
            return 0;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleMesh
{
    public static class Helpers
    {
        public static double BezierPoint(int i, double t)
        {
            int first;
            switch (i)
            {
                case 0:
                    first = 1; break;
                case 1:
                    first = 3; break;
                case 2:
                    first = 3; break;
                case 3:
                    first = 1; break;
                default:
                    first = 1;
                    break;
            }

            return first * Math.Pow(t, i) * Math.Pow(1 - t, 1 - i);
        }

        public static double CalculateZPoint(double x, double y)
        {
            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int Z = TriangleMesh.ControlPoints[j, i].Z / TriangleMesh.HeightView;

                    sum += Z * BezierPoint(i, x) * BezierPoint(j, y);
                }
            }

            return sum;
        }
    }
}

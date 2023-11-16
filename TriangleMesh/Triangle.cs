using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleMesh
{
    public class Triangle
    {
        public MyPoint3D p1, p2, p3; 

        public Triangle(MyPoint3D p1, MyPoint3D p2, MyPoint3D p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Triangle(MyPoint3D[] triangle)
        {
            p1 = triangle[0];
            p2 = triangle[1];
            p3 = triangle[2];
        }

        public static double CalculateTriangleArea(MyPoint3D p1, MyPoint3D p2, MyPoint3D p3)
        {
            // Wzór Herona do obliczenia pola trójkąta na podstawie długości boków
            double a = MyPoint3D.DistanceTo(p2, p3);
            double b = MyPoint3D.DistanceTo(p1, p3);
            double c = MyPoint3D.DistanceTo(p1, p2);

            double s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static double CalculateTriangleArea(Triangle triangle)
        {
            // Wzór Herona do obliczenia pola trójkąta na podstawie długości boków
            double a = MyPoint3D.DistanceTo(triangle.p2, triangle.p3);
            double b = MyPoint3D.DistanceTo(triangle.p1, triangle.p3);
            double c = MyPoint3D.DistanceTo(triangle.p1, triangle.p2);

            double s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleMesh
{
    public class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Example method to calculate the magnitude (length) of the vector
        public double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        // Example method to normalize the vector
        public void Normalize()
        {
            double magnitude = Magnitude();

            if (magnitude != 0)
            {
                X /= magnitude;
                Y /= magnitude;
                Z /= magnitude;
            }
        }

        // Example method to calculate the dot product with another vector
        public double DotProduct(Vector3D other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        // Example method to calculate the cross product with another vector
        public Vector3D CrossProduct(Vector3D other)
        {
            return new Vector3D(
                Y * other.Z - Z * other.Y,
                Z * other.X - X * other.Z,
                X * other.Y - Y * other.X
            );
        }

        public static Vector3D CalculateUnitVector(MyPoint3D pointOnMap, MyPoint3D sunPosition)
        {
            // Oblicz różnicę wektorową
            Vector3D vectorDifference = new Vector3D(
                sunPosition.X - pointOnMap.X,
                sunPosition.Y - pointOnMap.Y,
                sunPosition.Z - pointOnMap.Z
            );

            // Oblicz długość wektora różnicy
            double magnitude = vectorDifference.Magnitude();

            // Podziel każdą składową przez długość, aby uzyskać wersor
            Vector3D unitVector = new Vector3D(
                vectorDifference.X / magnitude,
                vectorDifference.Y / magnitude,
                vectorDifference.Z / magnitude
            );

            return unitVector;
        }

        public static Vector3D CaclculateNormVector(double x, double y, double z)
        {
            Vector3D Vector = new Vector3D(x / TriangleMesh.width, y / TriangleMesh.height, z / TriangleMesh.HeightView);

            Vector3D VectorU = new Vector3D(1, 0, 0);
            Vector3D VectorV = new Vector3D(0, 1, 0);

            double h = 1e-6;
            double derivativeU = (Helpers.CalculateZPoint(Vector.X + h, Vector.Y) - Helpers.CalculateZPoint(Vector.X - h, Vector.Y)) / (2 * h);
            double derivativeV = (Helpers.CalculateZPoint(Vector.X, Vector.Y + h) - Helpers.CalculateZPoint(Vector.X, Vector.Y - h)) / (2 * h);
            VectorU.Z = derivativeU;
            VectorV.Z = derivativeV;

            Vector3D crossedVector = VectorU.CrossProduct(VectorV);
            crossedVector.Normalize();

            return crossedVector;
        }

        public static Vector3D CalculateBarycentricCoordinates(Triangle triangle, MyPoint3D point)
        {
            // Wzory barycentryczne dla trójkąta ABC i punktu P:
            // P = u * A + v * B + w * C, gdzie u + v + w = 1

            double areaABC = Triangle.CalculateTriangleArea(triangle);

            // Współczynniki barycentryczne
            double u = Triangle.CalculateTriangleArea(point, triangle.p2, triangle.p3) / areaABC;
            double v = Triangle.CalculateTriangleArea(triangle.p1, point, triangle.p3) / areaABC;
            double w = Triangle.CalculateTriangleArea(triangle.p1, triangle.p2, point) / areaABC;

            return new Vector3D(u, v, w);
        }
        public static Vector3D InterpolateVectors(Vector3D vectorA, Vector3D vectorB, Vector3D vectorC, Vector3D coords)
        {
            double x = vectorA.X * coords.X + vectorB.X * coords.Y + vectorC.X * coords.Z;
            double y = vectorA.Y * coords.X + vectorB.Y * coords.Y + vectorC.Y * coords.Z;
            double z = vectorA.Z * coords.X + vectorB.Z * coords.Y + vectorC.Z * coords.Z;

            return new Vector3D(x, y, z);
        }

        public static double InterpolateValues(int valueA, int valueB, int valueC, Vector3D coords)
        {
            return valueA * coords.X + valueB * coords.Y + valueC * coords.Z;
        }

        public static (Vector3D, double) CalculateInterpolatedVectorAndValue(Triangle triangle, MyPoint3D point)
        {
            Vector3D barycentricCoords = CalculateBarycentricCoordinates(triangle, point);
            Vector3D interpolatedNormal = InterpolateVectors(
                    triangle.p1.NormVector,
                    triangle.p2.NormVector,
                    triangle.p3.NormVector,
                    barycentricCoords
                );
            interpolatedNormal.Normalize();

            double interpolatedZ = InterpolateValues(
                triangle.p1.Z,
                triangle.p2.Z,
                triangle.p3.Z,
                barycentricCoords
            );

            return (interpolatedNormal, interpolatedZ);
        }

        // Funkcja do obliczania iloczynu skalarnego dwóch wektorów
        public static double DotProduct(Vector3D vector1, Vector3D vector2)
        {
            return vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z;
        }

        public static Vector3D MultiplyByScalar(Vector3D vector, double scalar)
        {
            return new Vector3D(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);
        }

        public static Vector3D Subtract(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(vector1.X - vector2.X, vector1.Y - vector2.Y, vector1.Z - vector2.Z);
        }

        // Example method to display the vector
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}

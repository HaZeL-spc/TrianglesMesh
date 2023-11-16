using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace TriangleMesh
{
    public class ScanlineFill
    {
        public MyPoint3D[] Vertices { get; private set; }
        public List<Edge> ActiveEdgeTable { get; private set; }
        public DirectBitmap drawArea;

        public ScanlineFill(DirectBitmap _drawArea, MyPoint3D[] points)
        {
            Vertices = points;
            ActiveEdgeTable = new List<Edge>();
            drawArea = _drawArea;
        }


        public void FillPolygon()
        {
            Color randomColor = TriangleMesh.ColorRgb;

            MyPoint3D[] P = (MyPoint3D[])Vertices.Clone();
            int[] ind = Vertices.Select((p, index) => index)
                     .OrderBy(index => Vertices[index].Y)
                     .ToArray();
            List<Edge> AET = new List<Edge>();
            List<int> indexScanLine = new List<int>();

            if (Vertices.Count() < 3)
                return;

            int minY = Vertices[0].Y;
            int maxY = Vertices[Vertices.Count() - 1].Y;

            // preproccess
            int count = Vertices.Count();
            for (int i = 0; i < count; i++)
            {
                if (Vertices[i].Y == minY)
                {
                    Edge E1 = new Edge(Vertices[i], Vertices[(i + count - 1) % count]);
                    Edge E2 = new Edge(Vertices[i], Vertices[(i + 1) % count]);
                    indexScanLine.Add(i);

                    if (E1.End.Y != minY)
                        AET.Add(E1);
                    
                    if (E2.End.Y != minY)
                        AET.Add(E2);
                }
            }

            for (int y = minY + 1; y <= maxY; y++)
            {
                int minMaxY = AET.Max(p => p.End.Y);
                int newEdgeY = P[ind[indexScanLine[indexScanLine.Count() - 1]]].Y;

                AET.Sort((edge1, edge2) => edge1.CurrentX.CompareTo(edge2.CurrentX));

                for (int i = 0; i < AET.Count(); i = i + 2) {
                    double x1 = AET[i].CurrentX;
                    double x2 = AET[i + 1].CurrentX;

                    for (int x = (int)Math.Min(x1, x2); x <= Math.Max(x1, x2); x++)
                    {
                        //drawArea.SetPixel(x, y, randomColor);
                        PrepareColorsLight(x, y, randomColor, TriangleMesh.SunLight, Vertices, drawArea);
                    }

                    AET[i].ChangeCurrentX();
                    AET[i + 1].ChangeCurrentX();
                }
            }
        }

        static int FindMinMaxY(Point[] points)
        {
            if (points == null || points.Length == 0)
            {
                throw new ArgumentException("The array of points is empty or null.");
            }

            int maxY = points[0].Y;

            for (int i = 1; i < points.Length; i++)
            {
                if (points[i].Y > maxY)
                {
                    maxY = points[i].Y;
                }
            }

            return maxY;
        }

        public void PrepareColorsLight(int x, int y, Color rgbValueObj, Color rgbValueSun, MyPoint3D[] _triangle, DirectBitmap drawArea)
        {
            Triangle triangle = new Triangle(_triangle);
            Vector3D V = new Vector3D(0, 0, 1);
            (Vector3D N, double z) normVectorValue = Vector3D.CalculateInterpolatedVectorAndValue(triangle, new MyPoint3D(x, y, -1));
            Vector3D N = normVectorValue.Item1;
            int z = (int)(normVectorValue.Item2 * TriangleMesh.HeightView);
            Vector3D L = Vector3D.CalculateUnitVector(new MyPoint3D(x, y, z), TriangleMesh.SunCoords);
            Vector3D R = Vector3D.Subtract(Vector3D.MultiplyByScalar(N, 2 * Vector3D.DotProduct(N, L)), L);

            double cosFirst = Vector3D.DotProduct(N, L);
            if (cosFirst < 0) cosFirst = 0;

            double cosSecond = Vector3D.DotProduct(V, R);
            if (cosSecond < 0) cosSecond = 0;

            double colorRed = PrepareOneColorLight(cosFirst, cosSecond, rgbValueObj.R, rgbValueSun.R);
            double colorGreen = PrepareOneColorLight(cosFirst, cosSecond, rgbValueObj.G, rgbValueSun.G);
            double colorBlue = PrepareOneColorLight(cosFirst, cosSecond, rgbValueObj.B, rgbValueSun.B);

            drawArea.SetPixel(x, y, Color.FromArgb((int)(colorRed * 255), (int)(colorGreen * 255), (int)(colorBlue * 255)));
        }

        public double PrepareOneColorLight(double cosFirst, double cosSecond, double rgbValueObj, double rgbValueSun)
        {
            double Ll = rgbValueObj / 255;
            double Lo = rgbValueSun / 255;

            double l = TriangleMesh.Kd * Lo * Ll * cosFirst + TriangleMesh.Ks * Lo * Ll * Math.Pow(cosSecond, TriangleMesh.m);

            if (l > 1) return 1;
            
            return l;
        }
    }
}

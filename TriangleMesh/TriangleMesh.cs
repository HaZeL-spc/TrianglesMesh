using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleMesh
{
    public class TriangleMesh
    {
        public static int TRIANGLES_X = 5;
        public static int TRIANGLES_Y = 5;
        public static int COLOUR_RED = 0;
        public static int COLOUR_BLUE = 0;
        public static int COLOUR_GREEN = 0;
        public static int COLOUR_RED_SUN = 255;
        public static int COLOUR_BLUE_SUN = 255;
        public static int COLOUR_GREEN_SUN = 255;
        public static Color ColorRgb = Color.FromArgb(0,0,0), SunLight = Color.FromArgb(255, 255, 255);
        public static MyPoint3D SunCoords = new MyPoint3D(300, 300, 40);
        public static MyPoint3D[,] ControlPoints = new MyPoint3D[4, 4];
        public static double Kd = 1, Ks = 1;
        public static int m = 1;
        public static int HeightView = 150;
        public static DirectBitmap drawArea;
        public static List<Triangle> triangles;
        public static int width;
        public static int height;
        public static int sunZ = 40;
        public static bool drawTriangulation = true;
        public static bool moveSun = true;

        public TriangleMesh(DirectBitmap _drawArea, int Width, int Height)
        {
            drawArea = _drawArea;
            width = Width;
            height = Height;
            triangles = new List<Triangle>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ControlPoints[j, i] = new MyPoint3D(j * height / 4, i * width / 4, 0);
                }
            }

            PrepareTriangles();
        }

        public void Paint()
        {
            drawArea.Refresh();

            // Parallel loop to process each triangle concurrently
            //foreach (var triangle in triangles)
            //{
            //    MyPoint3D[] points = { triangle.p1, triangle.p2, triangle.p3 };
            //    ScanlineFill scanline = new ScanlineFill(points);

            //    scanline.FillPolygon();

            //    //drawArea.SetPixel(triangle.p1.X, triangle.p1.Y, Color.Black);
            //}

            MyPoint3D[] examplePolygon = {new MyPoint3D(200, 300, 0), new MyPoint3D(300, 340, 0),
                new MyPoint3D(250, 400, 0), new MyPoint3D(500, 310, 0), new MyPoint3D(100, 400, 0)};

			ScanlineFill scanline = new ScanlineFill(examplePolygon);
            scanline.FillPolygon(true);
		}

        public void PrepareTriangles()
        {
            triangles.Clear();
            double triangleWidth = (double)(width - 1) / (double)TRIANGLES_X;
            double triangleHeight = (double)(height - 1) / (double)TRIANGLES_Y;

            for (int j = 0; j < TRIANGLES_Y; j++)
            {
                for (int i = 0; i < TRIANGLES_X; i++)
                {
                    var trianglesUpDown = CalculateTrianglesUpDown(j, i, triangleWidth, triangleHeight);
                    triangles.Add(trianglesUpDown.Item1);
                    triangles.Add(trianglesUpDown.Item2);
                }
            }
            Console.Write("");
        }

        public (Triangle, Triangle) CalculateTrianglesUpDown(int index_height, int index_width, double triangleWidth, double triangleHeight)
        {
            MyPoint3D p1, p2, p3;

            if (index_width == 1 && index_height == 0)
                Console.WriteLine("");

            double z1 = Helpers.CalculateZPoint((triangleWidth * index_width) / width, (triangleHeight * index_height) / height);
            double z2 = Helpers.CalculateZPoint((triangleWidth * (index_width + 1)) / width, (triangleHeight * index_height) / height);
            double z3 = Helpers.CalculateZPoint((triangleWidth * index_width) / width, (triangleHeight * (index_height + 1)) / height);
            double z4 = Helpers.CalculateZPoint((triangleWidth * (index_width + 1)) / width, (triangleHeight * (index_height + 1)) / height);

            p1 = new MyPoint3D((int)(triangleWidth * index_width), (int)(triangleHeight * index_height), (int)(z1 * HeightView), true);
            p2 = new MyPoint3D((int)(triangleWidth * (index_width + 1)), (int)(triangleHeight * index_height), (int)(z2 * HeightView), true);
            p3 = new MyPoint3D((int)(triangleWidth * index_width), (int)(triangleHeight * (index_height + 1)), (int)(z3 * HeightView), true);

            Triangle triangleUp = new Triangle(p1, p2, p3);

            p1 = new MyPoint3D((int)(triangleWidth * (index_width + 1)), (int)(triangleHeight * index_height), (int)(z2 * HeightView), true);
            p2 = new MyPoint3D((int)(triangleWidth * (index_width + 1)), (int)(triangleHeight * (index_height + 1)), (int)(z4 * HeightView), true);
            p3 = new MyPoint3D((int)(triangleWidth * index_width), (int)(triangleHeight * (index_height + 1)), (int)(z3 * HeightView), true);

            Triangle triangleDown = new Triangle(p1, p2, p3);

            return (triangleUp, triangleDown);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleMesh
{
    public class Edge
    {
        public MyPoint3D Start { get; set; }
        public MyPoint3D End { get; set; }
        public double CurrentX { get; set; }
        public double InverseSlope { get; set; }

        public Edge(MyPoint3D start, MyPoint3D end)
        {
            Start = start;
            End = end;
            CurrentX = Start.X;
            InverseSlope = (double)(End.X - Start.X) / (End.Y - Start.Y);
        }

        public void ChangeCurrentX()
        {
            CurrentX = CurrentX + InverseSlope;
        }

        public (double, double, double, double) ReturnSortedXY()
        {
            if (Start.X < End.X)
                return (Start.X, Start.Y, End.X, End.Y);
            return (End.X, End.Y, Start.X, Start.Y);
        }
    }
}

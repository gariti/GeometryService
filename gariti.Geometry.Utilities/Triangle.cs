using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace gariti.Geometry.Utilities
{
    public class Triangle
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }


        public List<int[]> GetVerticies()
        {
            List<int[]> result = new List<int[]>();

            result.Add(new int[] { Point1.X, Point1.Y });
            result.Add(new int[] { Point2.X, Point2.Y });
            result.Add(new int[] { Point3.X, Point3.Y });

            return result;
        }

    }
}

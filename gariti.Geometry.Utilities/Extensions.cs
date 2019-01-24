using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace gariti.Geometry.Utilities
{
    public static class Extensions
    {
        public static double GetDistance(this Point point1, Point point2)
        {
            var a = (double)(point2.X - point1.X);
            var b = (double)(point2.Y - point1.Y);

            return Math.Sqrt(a * a + b * b);
        }
    }
}

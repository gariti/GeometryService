using System;
using System.Drawing;

namespace gariti.Geometry.Utilities
{
    public static class TriangleHelper
    {
        public static Triangle GetBottomTriangle(int xOffset, int yOffset, int squareSize)
        {
            return new Triangle()
            {
                //Point1 - Upperleft
                //Point2 - Bottomleft
                //Point3 - Bottomright
                
                Point1 = new Point(xOffset, yOffset),
                Point2 = new Point(xOffset, yOffset + squareSize),
                Point3 = new Point(xOffset + squareSize, yOffset + squareSize)
            };
        }
    }
}

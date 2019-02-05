using System.Drawing;

namespace gariti.Geometry.Utilities
{
    public class Line
    {
        public double Length { get; }
        public Point Point1 { get; }
        public Point Point2 { get; }

        public Line(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
            Length = point1.GetDistance(point2);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;

namespace gariti.Geometry.Utilities
{
    public class Grid
    {
        public int Length { get; }
        public int Height { get; }
        public int SquareSize { get; }
        public int NumberOfColumns { get; }
        public int NumberOfRows { get; }

        public Grid(int length, int height, int squareSize)
        {
            Length = length;
            Height = height;
            SquareSize = squareSize;

            if (Length % SquareSize != 0 || Height % SquareSize != 0 || SquareSize > Length || SquareSize > Height)
                throw new Exception(
                    string.Format("Invalid grid! Defined SquareSize must be divisible by the grid width & height{0}SquareSize={1}{0}Grid:{2}x{3}",
                    Environment.NewLine, SquareSize, Length, Height));

            NumberOfColumns = Length / SquareSize;
            NumberOfRows =  Height / SquareSize;
        }

        public Point CalculateGridStartingPoint(string letterNumberCoordinates)
        {
            int y = 0;
            int x = 0; 
            float num;
            
            if (letterNumberCoordinates.Length < 2 || !char.IsLetter(letterNumberCoordinates[0]) ||
                !float.TryParse(letterNumberCoordinates.Substring(1), out num))
                throw new Exception("Invalid coordinates: " + letterNumberCoordinates);

            int column = (int)Math.Ceiling(num / 2) - 1;

            x += column * SquareSize;

            //Convert letter (A-Z) into alphabet index 
            int rowNumber = char.ToUpper(letterNumberCoordinates[0]) - 65;

            y += rowNumber * SquareSize;

            return new Point(x, y);
        }

        public Triangle GetTriangle(string letterNumberCoordinates)
        {
            int num;

            if (letterNumberCoordinates.Length < 2 || !char.IsLetter(letterNumberCoordinates[0]) ||
                !int.TryParse(letterNumberCoordinates.Substring(1), out num))
                throw new Exception("Invalid coordinates: " + letterNumberCoordinates);

            Point startingPoint = this.CalculateGridStartingPoint(letterNumberCoordinates);

            Triangle triangle;
            if (num % 2 == 0)
            {
                triangle = Helper.GetTopTriangle(startingPoint.X, startingPoint.Y, SquareSize);
            } else
            {
                triangle = Helper.GetBottomTriangle(startingPoint.X, startingPoint.Y, SquareSize);
            }

            return triangle;
        }

        public string CalculateTriangleRowAndColumn(Point point1, Point point2, Point point3)
        {
            List<Point> points = new List<Point>() { point1 , point2, point3};
            ValidatePoints(points);


            //sort 3 points by lowest values to determine starting corner of square in grid (upperleft)
            points = new List<Point>(points.OrderBy(pt => pt.X + pt.Y)).ToList();
            int startingX = points.First().X;
            int startingY = points.First().Y;

            int row = (startingX / SquareSize);
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string letterPosition = alphabet[row].ToString();

            int column = (startingY / SquareSize) + 1;
            int numberPosition = 0;
            if (startingX == points.ElementAt(1).X || startingX == points.ElementAt(2).X)
            {
                //Bottom Triange
                numberPosition = (column * 2) - 1;
            }
            else if (startingY == points.ElementAt(1).Y || startingX == points.ElementAt(2).Y)
            {
                //Top Triangle
                numberPosition = (column * 2);
            }

            return letterPosition += numberPosition;
        }

        private void ValidatePoints(List<Point> points)
        {
            foreach (var point in points)
            {
                if (point.X % SquareSize != 0 || point.Y % SquareSize != 0)
                {
                    throw new Exception(string.Format("Invalid input!  Coordinates should be divisible by {0}: {1}{2}",
                        SquareSize, Environment.NewLine, points.ToString()));
                }
            }

            List<double> sideLengths = new List<double>();
            sideLengths.Add(points.ElementAt(0).GetDistance(points.ElementAt(1)));
            sideLengths.Add(points.ElementAt(0).GetDistance(points.ElementAt(2)));
            sideLengths.Add(points.ElementAt(1).GetDistance(points.ElementAt(2)));

            if (sideLengths.Where(len => len != SquareSize).Count() > 2)
                throw new Exception("Unexpected Triangle: " + points.ToString());


        }
    }
}

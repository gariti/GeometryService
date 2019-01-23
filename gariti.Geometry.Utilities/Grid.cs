using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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

            if (Length % SquareSize != 0 || Height % SquareSize != 0)
                throw new Exception(
                    string.Format("Defined SquareSize must be divisible by the grid width & height{0}SquareSize={1}{0}Grid:{2}x{3}",
                    Environment.NewLine, SquareSize, Length, Height));

            NumberOfColumns = Length / SquareSize;
            NumberOfRows =  Height / SquareSize;
            
        }

        public Point CalculateSquarePosition(string letterNumberCoordinates)
        {
            int y = 0;
            int x = 0; 
            float num;
            
            if (letterNumberCoordinates.Length < 2 || !char.IsLetter(letterNumberCoordinates[0]) ||
                !float.TryParse(letterNumberCoordinates.Substring(1), out num))
                throw new Exception("Invalid coordinates: " + letterNumberCoordinates);

            //Examples Input = A1
            //        Output = 0, 0
            //        Input = A2
            //        Output = 0, 0
            //        Input = F11
            //        Output = 50, 50
            //        Input = F12
            //        Output = 50, 50
            int column = (int)Math.Ceiling(num / 2) - 1;

            x += column * SquareSize;

            int rowNumber = char.ToUpper(letterNumberCoordinates[0]) - 65;
            y += rowNumber * SquareSize;

            return new Point(x, y);
        }
    }
}

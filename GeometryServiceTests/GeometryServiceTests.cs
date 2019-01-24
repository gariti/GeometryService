using Microsoft.VisualStudio.TestTools.UnitTesting;
using gariti.Geometry.Utilities;
using System.Drawing;

namespace gariti.Geometry.Tests
{
    [TestClass]
    public class GeometryServiceTests
    {
        [TestMethod]
        public void ShouldGetA1TriangleVerticies()
        {
            //Arrange
            //Coordinates represent offset from top left of the grid:
            //X = right offset
            //Y = down offset

            //x & y offset represents the upper-left coordinates of square
            int xSquarePos = 0;
            int ySquarePos = 0;

            //Act
            Triangle triangle = Helper.GetBottomTriangle(xSquarePos, ySquarePos, Constants.SQUARE_SIZE);

            //Assert
 
            //Upper Left corner - 0 , 0
            //Lower Left corner - 0 , 10
            //Lower Right corner - 10 , 10

            Assert.IsTrue(triangle.Point1.X == 0 && triangle.Point1.Y == 0);
            Assert.IsTrue(triangle.Point2.X == 0 && triangle.Point2.Y == 10);
            Assert.IsTrue(triangle.Point3.X == 10 && triangle.Point3.Y == 10);
        }

        [TestMethod]
        public void ShouldGetA2TriangleVerticies()
        {
            //Arrange
            //Coordinates represent offset from top left of the grid:
            //X = right offset
            //Y = down offset

            //x & y offset represents the upper-left coordinates of square
            int xSquarePos = 0;
            int ySquarePos = 0;

            //Act
            Triangle triangle = Helper.GetTopTriangle(xSquarePos, ySquarePos, Constants.SQUARE_SIZE);

            //Assert

            //Upper Left corner - 0 , 0
            //Upper Right corner - 10 , 0
            //Lower Right corner - 10 , 10

            Assert.IsTrue(triangle.Point1.X == 0 && triangle.Point1.Y == 0);
            Assert.IsTrue(triangle.Point2.X == 10 && triangle.Point2.Y == 0);
            Assert.IsTrue(triangle.Point3.X == 10 && triangle.Point3.Y == 10);
        }

        [TestMethod]
        public void ShouldGetA3TriangleVerticies()
        {
            //Arrange
            int xSquarePos = 10;
            int ySquarePos = 0;

            //Act
            Triangle triangle = Helper.GetBottomTriangle(xSquarePos, ySquarePos, Constants.SQUARE_SIZE);

            //Assert
            Assert.IsTrue(triangle.Point1.X == 10 && triangle.Point1.Y == 0);
            Assert.IsTrue(triangle.Point2.X == 10 && triangle.Point2.Y == 10);
            Assert.IsTrue(triangle.Point3.X == 20 && triangle.Point3.Y == 10);
        }

        [TestMethod]
        public void ShouldGetA4TriangleVerticies()
        {
            //Arrange
            int xSquarePos = 10;
            int ySquarePos = 0;

            //Act
            Triangle triangle = Helper.GetTopTriangle(xSquarePos, ySquarePos, Constants.SQUARE_SIZE);

            //Assert
            Assert.IsTrue(triangle.Point1.X == 10 && triangle.Point1.Y == 0);
            Assert.IsTrue(triangle.Point2.X == 20 && triangle.Point2.Y == 0);
            Assert.IsTrue(triangle.Point3.X == 20 && triangle.Point3.Y == 10);
        }

        [TestMethod]
        public void ShouldGetB3TriangleVerticies()
        {
            //Arrange
            int xSquarePos = 10;
            int ySquarePos = 10;

            //Act
            Triangle triangle = Helper.GetBottomTriangle(xSquarePos, ySquarePos, Constants.SQUARE_SIZE);

            //Assert
            Assert.IsTrue(triangle.Point1.X == 10 && triangle.Point1.Y == 10);
            Assert.IsTrue(triangle.Point2.X == 10 && triangle.Point2.Y == 20);
            Assert.IsTrue(triangle.Point3.X == 20 && triangle.Point3.Y == 20);
        }

        [TestMethod]
        public void ShouldGetB4TriangleVerticies()
        {
            //Arrange
            int xSquarePos = 10;
            int ySquarePos = 10;

            //Act
            Triangle triangle = Helper.GetTopTriangle(xSquarePos, ySquarePos, Constants.SQUARE_SIZE);

            //Assert
            Assert.IsTrue(triangle.Point1.X == 10 && triangle.Point1.Y == 10);
            Assert.IsTrue(triangle.Point2.X == 20 && triangle.Point2.Y == 10);
            Assert.IsTrue(triangle.Point3.X == 20 && triangle.Point3.Y == 20);
        }

        [TestMethod]
        public void ShouldGetF11TriangleVerticies()
        {
            //Arrange
            int xSquarePos = 50;
            int ySquarePos = 50;

            //Act
            Triangle triangle = Helper.GetBottomTriangle(xSquarePos, ySquarePos, Constants.SQUARE_SIZE);

            //Assert
            Assert.IsTrue(triangle.Point1.X == 50 && triangle.Point1.Y == 50);
            Assert.IsTrue(triangle.Point2.X == 50 && triangle.Point2.Y == 60);
            Assert.IsTrue(triangle.Point3.X == 60 && triangle.Point3.Y == 60);
        }

        [TestMethod]
        public void ShouldGetF12TriangleVerticies()
        {
            //Arrange
            int xSquarePos = 50;
            int ySquarePos = 50;

            //Act
            Triangle triangle = Helper.GetTopTriangle(xSquarePos, ySquarePos, Constants.SQUARE_SIZE);

            //Assert
            Assert.IsTrue(triangle.Point1.X == 50 && triangle.Point1.Y == 50);
            Assert.IsTrue(triangle.Point2.X == 60 && triangle.Point2.Y == 50);
            Assert.IsTrue(triangle.Point3.X == 60 && triangle.Point3.Y == 60);
        }

        //Test square starting positions
        //Examples Input = A1
        //        Output = 0, 0
        //        Input = A2
        //        Output = 0, 0
        //        Input = F11
        //        Output = 50, 50
        //        Input = F12
        //        Output = 50, 50
        [TestMethod]
        public void ShouldGetA1SquareStartingPosition()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);
            string input = "A1";

            //Act
            Point point = grid.CalculateGridStartingPoint(input);

            //Assert
            Assert.IsTrue(point.X == 0 && point.Y == 0);
        }

        [TestMethod]
        public void ShouldGetA2SquareStartingPosition()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);
            string input = "A2";

            //Act
            Point point = grid.CalculateGridStartingPoint(input);

            //Assert
            Assert.IsTrue(point.X == 0 && point.Y == 0);
        }

        [TestMethod]
        public void ShouldGetC6SquareStartingPosition()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);
            string input = "C6";

            //Act
            Point point = grid.CalculateGridStartingPoint(input);

            //Assert
            Assert.IsTrue(point.X == 20 && point.Y == 20);
        }

        [TestMethod]
        public void ShouldGetD7SquareStartingPosition()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);
            string input = "D7";

            //Act
            Point point = grid.CalculateGridStartingPoint(input);

            //Assert
            Assert.IsTrue(point.X == 30 && point.Y == 30);
        }

        [TestMethod]
        public void ShouldGetF11SquareStartingPosition()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);
            string input = "F11";

            //Act
            Point point = grid.CalculateGridStartingPoint(input);

            //Assert
            Assert.IsTrue(point.X == 50 && point.Y == 50);
        }

        [TestMethod]
        public void ShouldGetF12SquareStartingPosition()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);
            string input = "F12";

            //Act
            Point point = grid.CalculateGridStartingPoint(input);

            //Assert
            Assert.IsTrue(point.X == 50 && point.Y == 50);
        }

        [TestMethod]
        public void ShouldGetA1TriangleRowAndColumn()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 10);
            Point point3 = new Point(10, 10);

            //Act
            string result = grid.CalculateTriangleRowAndColumn(point1, point2, point3);

            //Assert
            Assert.AreEqual("A1", result);
        }

        [TestMethod]
        public void ShouldGetA2TriangleRowAndColumn()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(10, 0);
            Point point3 = new Point(10, 10);

            //Act
            string result = grid.CalculateTriangleRowAndColumn(point1, point2, point3);

            //Assert
            Assert.AreEqual("A2", result);
        }

        [TestMethod]
        public void ShouldGetF11TriangleRowAndColumn()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);
            Point point1 = new Point(50, 50);
            Point point2 = new Point(50, 60);
            Point point3 = new Point(60, 60);

            //Act
            string result = grid.CalculateTriangleRowAndColumn(point1, point2, point3);

            //Assert
            Assert.AreEqual("F11", result);
        }

        [TestMethod]
        public void ShouldGetF12TriangleRowAndColumn()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);
            Point point1 = new Point(50, 50);
            Point point2 = new Point(60, 50);
            Point point3 = new Point(60, 60);

            //Act
            string result = grid.CalculateTriangleRowAndColumn(point1, point2, point3);

            //Assert
            Assert.AreEqual("F12", result);
        }

    }
}

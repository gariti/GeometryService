using Microsoft.VisualStudio.TestTools.UnitTesting;
using gariti.Geometry.Utilities;
using System.Drawing;
using System.Collections.Generic;

namespace gariti.Geometry.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void ShouldGetA1TrianglePoints()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);

            //Act
            Triangle triangle = grid.GetTriangle("A1");

            //Assert

            //Upper Left corner - 0 , 0
            //Lower Left corner - 0 , 10
            //Lower Right corner - 10 , 10

            Assert.IsTrue(triangle.Point1.X == 0 && triangle.Point1.Y == 0);
            Assert.IsTrue(triangle.Point2.X == 0 && triangle.Point2.Y == 10);
            Assert.IsTrue(triangle.Point3.X == 10 && triangle.Point3.Y == 10);
        }

        [TestMethod]
        public void ShouldGetF12TrianglePoints()
        {
            //Arrange
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);

            //Act
            Triangle triangle = grid.GetTriangle("F12");

            //Assert

            //Upper Left corner - 0 , 0
            //Lower Left corner - 0 , 10
            //Lower Right corner - 10 , 10

            Assert.IsTrue(triangle.Point1.X == 50 && triangle.Point1.Y == 50);
            Assert.IsTrue(triangle.Point2.X == 60 && triangle.Point2.Y == 50);
            Assert.IsTrue(triangle.Point3.X == 60 && triangle.Point3.Y == 60);
        }

    }
}

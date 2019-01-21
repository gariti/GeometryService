using Microsoft.VisualStudio.TestTools.UnitTesting;
using gariti.Geometry.Utilities;

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
            Triangle triangle = TriangleHelper.GetBottomTriangle(xSquarePos, ySquarePos, Constants.SQUARE_SIZE);

            //Assert
 
            //Upper Left corner - 0 , 0
            //Lower Left corner - 0 , 10
            //Lower Right corner - 10 , 10

            Assert.IsTrue(triangle.Point1.X == 0 && triangle.Point1.Y == 0);
            Assert.IsTrue(triangle.Point2.X == 0 && triangle.Point2.Y == 10);
            Assert.IsTrue(triangle.Point3.X == 10 && triangle.Point3.Y == 10);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using gariti.Geometry.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace gariti.Geometry.API.Controllers
{
    public class GridController : Controller
    {
        [HttpGet("api/grid/triangle/byPoints")]
        //example query string localhost:44328/api/grid/gettriangle?x1=0&y1=0&x2=0&y2=10&x3=10&y3=10 returns "A1"
        public JsonResult GetTriangleRowAndColumn([FromQuery]int x1, [FromQuery]int y1, [FromQuery]int x2, [FromQuery]int y2, [FromQuery]int x3, [FromQuery]int y3)
        {
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);

            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Point point3 = new Point(x3, y3);

            return new JsonResult(grid.CalculateTriangleRowAndColumn(point1, point2, point3));
        }

        [HttpGet("api/grid/triangle/byLoc")]
        public JsonResult GetTrianglePoints([FromQuery] string loc)
        {
            Grid grid = new Grid(Constants.GRID_SIZE, Constants.GRID_SIZE, Constants.SQUARE_SIZE);

            Triangle triangle = grid.GetTriangle(loc);

            return new JsonResult(triangle);
        }

    }
}
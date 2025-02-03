using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP_5125_Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// This method receives a side length of a regular hexagon and returns the area of the hexagon.
        /// </summary>
        /// <param name="side">The side length of the hexagon</param>
        /// <returns>The area of the hexagon calculated using the formula (3 * √3 / 2) * side^2</returns>
        /// <example>
        /// GET: http://localhost:xx/api/q6/hexagon?side=1  -> 2.598076211353316
        /// GET: http://localhost:xx/api/q6/hexagon?side=1.5  -> 5.845671475544961
        /// GET: http://localhost:xx/api/q6/hexagon?side=20  -> 1039.2304845413264
        /// </example>
        [HttpGet("hexagon")]
        public double HexagonArea(double side)
        {
            // Calculate the area of the hexagon using the formula
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return area;
        }

    }
}

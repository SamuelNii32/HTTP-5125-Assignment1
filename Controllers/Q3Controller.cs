using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP_5125_Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// This endpoint returns the cube of the integer {base}.
        /// </summary>
        /// <param name="number">The integer to be cubed.</param>
        /// <returns>The cube of the input integer.</returns>
        /// <example>
        /// GET:localhost:xx/api/q3/cube/4
        /// -> 64
        /// </example>
        /// <example>
        /// GET:localhost:xx/api/q3/cube/-4
        /// -> -64
        /// </example>
        /// <example>
        /// GET:localhost:xx/api/q3/cube/10
        /// -> 1000
        /// </example>
        [HttpGet(template:"cube/{number}")]
        public int Cube(int number)
        {
            return number * number * number;
        }
    }

}

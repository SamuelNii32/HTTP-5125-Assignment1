using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP_5125_Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// This method receives a number of days and returns the date adjusted by that number of days.
        /// </summary>
        /// <param name="days">The number of days to adjust the current date</param>
        /// <returns>The adjusted date in the format yyyy-MM-dd</returns>
        /// <example>
        /// GET: http://localhost:xx/api/q7/timemachine?days=1 -> 2025-02-01
        /// GET: http://localhost:xx/api/q7/timemachine?days=-1 -> 2025-01-30
        /// </example>
        [HttpGet(template:"timemachine")]
        public string TimeMachine(int days)
        {
            // Get the current date and adjust it by the specified number of days
            DateTime adjustedDate = DateTime.Today.AddDays(days);

            // Return the adjusted date in yyyy-MM-dd format
            return adjustedDate.ToString("yyyy-MM-dd");
        }
    }
}

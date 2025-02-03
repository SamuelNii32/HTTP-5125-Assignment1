using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP_5125_Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : ControllerBase

    {
        /// <summary>
        /// This endpoint returns a welcome message.
        /// </summary>
        /// <returns>A welcome message showing the course code.</returns>
        /// <example>
        /// GET: localhost:xx/api/q1/welcome
        /// ->"Welcome to 5125!"
        /// </example>
        [HttpGet(template:"welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}

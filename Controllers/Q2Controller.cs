using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP_5125_Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// This endpoint returns a greeting to the provided name.
        /// </summary>
        /// <param name="name">The name to greet.</param>
        /// <returns>A greeting message for the specified name.</returns>
        /// <example>
        /// GET: localhost:xx/api/q2/greeting?name=Gary
        /// -> "Hi Gary!"
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/q2/greeting?name=Renée
        /// -> "Hi Renée!"
        /// </example>
        [HttpGet(template:"greeting")]
        public string Greeting(string name)
        {
            return $"Hi {name}!";
        }
    }
}

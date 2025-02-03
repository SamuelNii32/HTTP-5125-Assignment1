using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP_5125_Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// This method starts a knock-knock joke.
        /// </summary>
        /// <returns>
        /// "Who's there?"
        /// </returns>
        /// <example>
        /// POST: localhost:xx/api/q4/knockknock
        /// REQUEST HEADER: None
        /// REQUEST BODY: None
        /// -> "Who's there?"
        /// </example>
        [HttpPost(template:"knockknock")]
        public string KnockKnock()
        {
            return "Who's there?";
        }
    }
}

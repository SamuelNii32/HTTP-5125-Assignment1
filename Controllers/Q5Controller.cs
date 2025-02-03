using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP_5125_Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// This method acknowledges the {secret} integer sent in the request body.
        /// </summary>
        /// <param name="secret">The secret integer to acknowledge</param>
        /// <returns>A string confirming the secret received</returns>
        /// <example>
        /// POST: api/q5/secret
        /// Header: Content-Type: application/json
        /// REQUEST BODY: 5
        /// -> Shh.. the secret is 5
        /// </example>
        /// /// <example>
        /// POST: api/q5/secret
        /// Header: Content-Type: application/json
        /// REQUEST BODY:-200
        /// -> Shh.. the secret is -200
        /// </example>
        [HttpPost(template:"secret")]
        public string AcknowledgeSecret([FromBody] int secret)
        {
            return $"Shh.. the secret is {secret}";
        }

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP_5125_Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {
        /// <summary>
        /// This method calculates the checkout summary for SquashFellows plushies.
        /// It returns the total cost including tax for a given number of Small and Large plushies.
        /// </summary>
        /// <param name="Small">The number of Small SquashFellows plushies</param>
        /// <param name="Large">The number of Large SquashFellows plushies</param>
        /// <returns>A summary of the checkout including the number of items, subtotal, tax, and total amount</returns>
        /// <example>
        /// POST: localhost/api/q8/squashfellows
        /// Content-Type: application/x-www-form-urlencoded
        /// REQUEST BODY: Small=1&Large=1
        /// RESPONSE BODY: 1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58
        /// </example>
        [HttpPost("squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string SquashFellowsCheckout([FromForm] int Small, [FromForm] int Large)
        {
            double smallPrice = 25.50;
            double largePrice = 40.50;
            double taxRate = 0.13;

            // Calculate subtotal, tax, and total
            double smallTotal = Small * smallPrice;
            double largeTotal = Large * largePrice;
            double subtotal = smallTotal + largeTotal;
            double tax = Math.Round(subtotal * taxRate, 2);
            double total = subtotal + tax;

            // Format the response
            string summary = $"{Small} Small @ ${smallPrice} = ${smallTotal}; " +
                             $"{Large} Large @ ${largePrice} = ${largeTotal}; " +
                             $"Subtotal = ${subtotal}; Tax = ${tax} HST; Total = ${total}";

            return summary;
        }
    }
}

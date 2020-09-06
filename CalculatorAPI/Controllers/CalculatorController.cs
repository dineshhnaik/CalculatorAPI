using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculatorAPI.Controllers
{
    /// <summary>
    /// Calculator controller class.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        /// <summary>
        /// The Test method.
        /// </summary>
        /// <returns>String message</returns>
        [HttpGet]
        public string Get()
        {
            return "Hello from the Test API!";
        }

        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number</param>
        /// <returns>Sum of two numbers.</returns>
        [HttpGet]
        [Route("Add/{first}/{second}")]
        public decimal Add(int first, int second)
        {
            return first + second;
        }

        /// <summary>
        /// Subtracts two numbers.
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number</param>
        /// <returns>Difference between two numbers.</returns>
        [HttpGet]
        [Route("Subtract/{first}/{second}")]
        public decimal Subtract(decimal first, decimal second)
        {
            return first - second;
        }

        /// <summary>
        /// Multiples two numbers.
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number</param>
        /// <returns>Product of two numbers</returns>
        [HttpGet]
        [Route("Multiply/{first}/{second}")]
        public decimal Multiply(decimal first, decimal second)
        {
            return first * second;
        }

        /// <summary>
        /// Divides two numbers.
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number</param>
        /// <returns>Quotient of the two numbers.</returns>
        [HttpGet]
        [Route("Divide/{first}/{second}")]
        public decimal Divide(decimal first, decimal second)
        {
            if (second == 0) throw new InvalidOperationException("The second parameter should not be equal to zero.");

            return first / second;
        }
    }
}

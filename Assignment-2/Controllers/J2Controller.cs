using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Inputs two integers and returns the number of ways the value 10 may be rolled out
        /// </summary>
        /// <returns></returns>
        /// <param name="m">First Die Number of Sides</param>
        /// <param name="n">Second Die Number of Sides</param>
        /// <example>
        /// api/J2/DiceGame/6/8 -> "There are 5 total ways to get the sum 10"
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            // positive integers
            // 1st die has m sides
            // 2nd die has n sides

            // number of ways the sum of 10 can be rolled out
            int valueOfTen = 0;

            // i is position, start from 0
            // i will keep looping until it reaches max number = m (first die)
            // add +1 per iteration (incrementor)
            for (int i = 0; i <= m; i++)
            {
                // n is the max number of sides for the second die
                if (n >= 10 - i)
                {
                    valueOfTen = valueOfTen + 1; // checking for the value of 10
                }
            }
            if (valueOfTen == 1)
            {
                string messageTwo = "There is " + valueOfTen + " way to to get the sum 10.";
                return messageTwo;
            }
            string message = "There are " + valueOfTen + " ways to get the sum 10.";
            return message;


        }
    }
}
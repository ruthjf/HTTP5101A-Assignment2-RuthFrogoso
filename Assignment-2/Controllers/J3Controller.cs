using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
        ///Initiative Question: 2005 J3 "Returning Home"
        /// <summary>
        /// Takes an input and returns opposite instruction directions
        /// </summary>
        /// <param name="turn1">First input direction</param>
        /// <param name="turn2">Second input direction</param>
        /// <returns>String instructions for the opposite direction of input</returns>
        /// <example>
        /// api/J3/ReturningHome/L/R -> "Turn LEFT." "Turn RIGHT."
        /// </example>

        [HttpGet]
        [Route("api/J3/ReturningHome/{turn1}/{turn2}")] // .. should allow up to {turn10}
        public string ReturningHome(string turn1, string turn2)
        {

            // input must allow minimum of two characters and maximum ten characters
            // store in array ?

            // requires a string output to give instructions
            string turnRight = "Turn RIGHT.";
            string turnLeft = "Turn LEFT";
            string errorMessage = "Please enter L or R values.";

            // add a loop to run through every single input

            if (turn1 == "L") // condition to provide the opposite direction of input
            {
                return turnRight;

            } else if (turn1 == "R")
            {
                return turnLeft;
            }
            else
            {
                return errorMessage;
            }
        }
    }
}

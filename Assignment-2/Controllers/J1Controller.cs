using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Inputs four digit choices and provides the total calorie count corresponding each digit choice
        /// </summary>
        /// <param name="burger">Burger Digit Choice</param>
        /// <param name="drink">Drink Digit Choice</param>
        /// <param name="side">Side Digit Choice</param>
        /// <param name="dessert">Dessert Digit Choice</param>
        /// <returns>A string with the total number of calories</returns>
        /// <example>
        /// api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"
        /// </example>
        /// <example>
        /// api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0"
        /// </example>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            // burger calories
            int[] burgerArray = new int[] { 461, 431, 420, 0 };

            int burgerCal = 0;

            if (burger == 1)
            {
                burgerCal = burgerArray[0];
            }
            else if (burger == 2)
            {
                burgerCal = burgerArray[1];
            }
            else if (burger == 3)
            {
                burgerCal = burgerArray[2];
            }
            else if (burger == 4)
            {
                burgerCal = burgerArray[3];
            }

            // drink calories
            int[] drinkArray = new int[] { 130, 160, 118, 0 };
            int drinkCal = 0;

            if (drink == 1)
            {
                drinkCal = drinkArray[0];
            }
            else if (drink == 2)
            {
                drinkCal = drinkArray[1];
            }
            else if (drink == 3)
            {
                drinkCal = drinkArray[2];
            }
            else if (drink == 4)
            {
                drinkCal = drinkArray[3];
            }

            // side calories
            int[] sideArray = new int[] { 100, 57, 70, 0 };
            int sideCal = 0;

            if (side == 1)
            {
                sideCal = sideArray[0];
            }
            else if (side == 2)
            {
                sideCal = sideArray[1];
            }
            else if (side == 3)
            {
                sideCal = sideArray[2];
            }
            else if (side == 4)
            {
                sideCal = sideArray[3];
            }

            // dessert calories
            int[] dessertArray = new int[] { 167, 266, 75, 0 };
            int dessertCal = 0;

            if (dessert == 1)
            {
                dessertCal = dessertArray[0];
            }
            else if (dessert == 2)
            {
                dessertCal = dessertArray[1];
            }
            else if (dessert == 3)
            {
                dessertCal = dessertArray[2];
            }
            else if (dessert == 4)
            {
                dessertCal = dessertArray[3];
            }

            var totalCal = burgerCal + drinkCal + sideCal + dessertCal;
            string message = "Your total calorie count is ";

            return message + totalCal;

        }
    }
}

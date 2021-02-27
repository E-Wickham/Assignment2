using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{

    public class J1Controller : ApiController
    {
          
        [HttpGet]
        [Route("api/J1/Menu/{Burger}/{Drink}/{side}/{dessert}")]
        public int GetMenu (int Burger, int Drink, int side, int dessert) 
        {
            ///int Calories = 0;
            ///if statement to determine amount of calories, if less than two, its a cheeseburger, 
            ///if it is less than three -> fish burger, less than 4 veggie, 4 or higher -> no burger
            ///since using if burger = 1 gives an error, using if statements in this fashion will remove any potential issues with the menu
            
            if (Burger < 1) { 
                Burger = 0;
            } else if (Burger < 2) {
                Burger = 461;
            } else if (Burger < 3) {
                Burger = 431;
            } else if (Burger < 4) {
                Burger = 420;
            } else {
                Burger = 0;
            }

            // Drink If statement

            if (Drink < 1)
            {
                Drink = 0;
            }
            else if (Drink < 2)
            {
                Drink = 130;
            }
            else if (Drink < 3)
            {
                Drink = 160;
            }
            else if (Drink < 4)
            {
                Drink = 118;
            }
            else
            {
                Drink = 0;
            }

            // Side Order If statement

            if (side < 1)
            {
                side = 0;
            }
            else if (side < 2)
            {
                side = 100;
            }
            else if (side < 3)
            {
                side = 57;
            }
            else if (side < 4)
            {
                side = 70;
            }
            else
            {
                side = 0;
            }

            // dessert Order If statement

            if (dessert < 1)
            {
                dessert = 0;
            }
            else if (dessert < 2)
            {
                dessert = 167;
            }
            else if (dessert < 3)
            {
                dessert = 266;
            }
            else if (dessert < 4)
            {
                dessert = 75;
            }
            else
            {
                dessert = 0;
            }

            return Burger + Drink + side + dessert;

            ///<summary>
            ///Calculates calories of the meal based on the input from the user
            ///</summary>
            ///<param name="Burger">First Integer Factor</param>
            ///<param name="Drink">Second Integer Factor</param>
            ///<param name="side">First Integer Factor</param>
            ///<param name="dessert">Second Integer Factor</param>
            ///<example> api/J1/menu/1/1/1/1 -> 858</example>
            ///<example> api/J1/menu/2/2/2/2 -> 914</example> 
            ///<returns>The sum of the selected items</returns>
        }

    }
}

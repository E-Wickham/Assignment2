using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class DiceController : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public int Dice(m, n)
        {
            /// add all possible combinations of the two die with a for loop, then with an if statement, 
            /// have it count the number of times the sum of the two die equal ten
            ///
            /// I don't know if this code would actually work, but this is essentially what I think I would do for a problem like this. 
            /// Take the inputs from the user, use for loops to create every possible combination, then find the ones that sum to 10, 
            /// and have a variable counting the number of times you reach that sum
            /// Then at the very end, you return a statement saying "There are " + GoodRoll + " total ways to get the sum 10."
            ///
            /// GoodRoll = 0
            ///
            /// for (int i=1, i<=m, i++) {
            ///     for (int i2=1, i2<=n, i2++) {
            ///  if(i + i2 = 10) {
            ///    GoodRoll += 1
            ///     }
            /// 
            /// return string "There are " + GoodRoll + " total ways to get the sum 10."
            /// 
            ///<summary>
            ///Calculates all possible combinations of dice rolls to get 10 
            ///</summary>
            ///<param name="m">Die 1</param>
            ///<param name="n">Die 2</param>
            ///<example> api/J2/DiceGame/2/2 -> 0</example>
            ///<example> api/J2/DiceGame/5/5 -> 1</example> 
            ///<returns>The total number of possible combinations of the number ten depending on the number of sides per the two die </returns>

        }


    }
}


using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallenge11_APIBeginningsCThomason.Controllers
{



    [ApiController]
    [Route("api/[controller]")]
    public class userController : ControllerBase
    {
        
    [HttpGet]
    [Route("sayhello/{name}")]
    public ActionResult<string> GreetUser(string name)
    {
        return Ok($"Hello, {name}"); 
    }//end of method GreetUser
    [HttpGet]
    [Route("addtwonumbers/{num1}/{num2}")]
    public ActionResult<string> addTwoNumbers(string num1, string num2)
        {
            
            bool isNum = int.TryParse(num1, out int newNum);
            bool isNum2 = int.TryParse(num2, out int newNum2);
             if (!isNum || !isNum2)
           {
               return NotFound("One of your numbers contained invalid characters. Input a number and try again. "); 
            }
               int sum =  newNum + newNum2; 
            
            return Ok($"The sum of {newNum} and {newNum2} is {sum}"); 
        }//end of method addTwoNumbers

        [HttpGet]
        [Route("wakeup/{name}/{time}")]

        public ActionResult<string> wakeUp(string name, string time)
        {
            return Ok($"{name} woke up at {time}"; 
        } //end of method wakeUp

        [HttpGet("comparison/{num1}/{num2}")]

        public ActionResult<string> comparison(string num1, string num2)
        {
            bool isNum = int.TryParse(num1, out int newNum1); 
            bool isNum2 = int.TryParse(num2, out int newNum2); 
            if(isNum && isNum2)
            {
                if(newNum1 == newNum2)
                {
                    return Ok($"{newNum1} is equal too {newNum2}, and {newNum2} is equal too {newNum1}");
                }
                else if(newNum1 > newNum2)
                {
                    return Ok($"{newNum1} is greater than {newNum2}, and {newNum2} is less than {newNum1}");
                }
                else
                {
                    return Ok($"{newNum1} is less than {newNum2}, and {newNum2} is greater than {newNum1}");
                }
            }//end if
            return NotFound("One of the values you input is not valid. Input a number.");
        }//end of method comparison

        [HttpGet("madlib/{name}/{animal}/{animalName}/{num}/{noun}/{color}/{verb}/{place}/{adj}/{food}")]
        
        //TEST: http://localhost:5007/api/user/madlib/Callen/Horse/Tyler/2/sword/red/run/tacobell/hairy/beans
        public ActionResult<string> madLib(string name, string animal, string animalName, string num, string noun, string color, string verb, string place, string adj, string food)
        {
            
            return Ok($"There once was a man named {name}. He had a trusty pet {animal} named {animalName}. {name} and {animalName} did everything together. When {animalName} turned {num}, {name} gave him a {color} {noun}. Then the two {verb} to {place}. They saw a {adj} car, and ate all you could eat {food}! THE END! ");
        }
       
    }//end of class
}

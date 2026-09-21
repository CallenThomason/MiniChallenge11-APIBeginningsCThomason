
using Microsoft.AspNetCore.Mvc;

namespace MiniChallenge11_APIBeginningsCThomason.Controllers
{



    [ApiController]
    [Route("api/[controller]")]
    public class userController : ControllerBase
    {
        
    [HttpGet]
    [Route("sayhello/{name}")]
    public string GreetUser(string name)
    {
        return $"Hello, {name}"; 
    }//end of method GreetUser
    [HttpGet]
    [Route("addtwonumbers/{num1}/{num2}")]
    public string addTwoNumbers(string num1, string num2)
        {
            
            bool isNum = int.TryParse(num1, out int newNum);
            bool isNum2 = int.TryParse(num2, out int newNum2);
             if (!isNum || !isNum2)
           {
               return "Erorr: User did not input a number"; 
            }
               int sum =  newNum + newNum2; 
            
            return $"The sum of {newNum} and {newNum2} is {sum}"; 
        }//end of method addTwoNumbers

        [HttpGet]
        [Route("wakeup/{name}/{time}")]

        public string wakeUp(string name, string time)
        {
            return $"{name} woke up at {time}"; 
        }

    }//end of class
}

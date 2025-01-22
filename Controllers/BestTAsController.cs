using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using BestTAsControllerQuiz.Models;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BestTAsController : ControllerBase
    {
        [HttpGet]
        [Route("AddTwoNumbers/{firstNumberString}/{secondNumberString}")]
        public string AddTwoNumbers (string firstNumberString, string secondNumberString) 
        {
            int num1;
            int num2;
            int sum;
            bool validFirstNumber = int.TryParse(firstNumberString, out num1);
            bool validSecondNumber = int.TryParse(secondNumberString, out num2);

            if(validFirstNumber == false || validSecondNumber == false)
            {
                return "Invalid Input: Make sure you are typing two integer numbers.";
            }
            else
            {
                sum = num1 + num2;
            }

            return $"{sum}";
        }

        [HttpGet]
        [Route("ReverseIt/{inputString}")]
        public string ReverseIt(string inputString)
        {
            string result = "";
            for(int i = inputString.Length - 1; i >= 0; i--)
            {
                result += inputString[i];
            }
            return result;
        }

        [HttpGet]
        [Route("SayHello/{inputVariable}")]
        
        public string SayHello(string inputVariable)
        {
            return $"Hello {inputVariable}";
        }

        [HttpGet]
        [Route("SayHelloTwo")]
        public string SayHelloTwo(SayHelloTwoModel userName)
        {
            return $"Hello {userName.UserName}";
        }

    }
}
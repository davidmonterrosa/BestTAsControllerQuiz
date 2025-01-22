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
        [Route("AddTwoNumbers/{num1}/{num2}")]
        public int AddTwoNumbers (int num1, int num2) 
        {
            int sum = num1 + num2;
            return sum;
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
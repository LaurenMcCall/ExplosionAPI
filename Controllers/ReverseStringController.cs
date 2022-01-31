using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {
        // This will have one HttpGet method
        [HttpGet]
        public string ReverseString(string word)
        {
            return new string(word.ToArray().Reverse().ToArray());
        }
    }

}

// The method will accept a string either as a URL parameter or a query parameter. Your choice.
// This endpoint method will reverse the string passed to it, manipulate it according to the kata Reverse String and return the result
// Have your code return the string
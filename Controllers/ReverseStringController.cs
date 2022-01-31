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
        [HttpGet]
        public string ReverseString(string word)
        {

            string defaultWord = (word == null) ? "supercalifragilisticexpialidocious" : word;
            var reversedDefaultWord = new string(defaultWord.ToArray().Reverse().ToArray());

            return $"Behold! A reversed word: {reversedDefaultWord}";
        }
    }
}


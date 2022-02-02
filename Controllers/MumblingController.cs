using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        [HttpGet]
        public string Mumbling(string s)
        {
            var index = 1;
            var phrase = string.Join("-", s.Select(c => new String(c, index++))).ToLower();
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }

    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDS.MainApplication.Library.StringParser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CDS.MainApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {


        [HttpPost]
        [Route("/api/ParseString")]
        //Question 5
        public virtual IActionResult ParseString(string parse, string parser)
        {
            StringParser stringParser = new StringParser();
          var result =  stringParser.ParseString(parse,parser);

            return Ok(result);
        }
    }
}

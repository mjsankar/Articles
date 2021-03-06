﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionFilter.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [CustomExceptionFilter]
        public IEnumerable<string> Get()
        {
            throw new Exception();
            return new string[] { "value1", "value2" };
        }
        // GET api/values
        [HttpGet("New")]
        [CustomExceptionFilter]
        public IEnumerable<string> GetNovo()
        {
            //throw new Exception();
            return new string[] { "redirected" };
        }
        
    }
}

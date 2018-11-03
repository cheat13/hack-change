using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Change.lib;

namespace Change.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{pay}/{amount}")]
        public ChangeModels CalculateChange(int pay,int amount)
        {
            var changeLib = new CalculateChanges();
            var result = changeLib.Calculate(pay,amount);
            return result;
        }

    }
}

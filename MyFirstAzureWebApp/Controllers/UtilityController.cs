using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstAzureWebApp.Services;

namespace MyFirstAzureWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Utility")]
    public class UtilityController : Controller
    {
        [HttpGet("[action]")]
        public string GetRandomString(int length, bool useNumber = true, bool useLower = true, bool useUpper = true
                                                , bool useSpecial = false, string custom = "", string start = "")
        {
            return UtilityService.GetRandomString(length, useNumber, useLower, useUpper, useSpecial, custom, start);
        }
    }
}

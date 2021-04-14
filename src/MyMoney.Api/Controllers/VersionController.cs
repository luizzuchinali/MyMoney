using Microsoft.AspNetCore.Mvc;
using MyMoney.Api.Controllers;

namespace MyMoney.Api.Controllers
{

    [Route("api/[controller]")]
    public class VersionController : ApplicationController
    {

        [HttpGet]
        public IActionResult GetVersion(){
            return Ok(new { Server = "OK" });
        }
    }
}
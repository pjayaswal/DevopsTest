using System;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string SayHello(string message)
        {
            return $"Hello {message} from {Environment.MachineName}";
        }
    }
}
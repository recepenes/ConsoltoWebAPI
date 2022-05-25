using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebAPI.Controllers
{
    [ApiController]
    [Route("test/{action}")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello from get";
        }
        public string Get1()
        {
            return "Hello from get1";
        }
    }
}

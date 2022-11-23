using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace TESTWebApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
       [HttpGet]
       [Route("sayHello")]
      public string GetHello()
        {
            return "hello world";

        }
       
    }
}

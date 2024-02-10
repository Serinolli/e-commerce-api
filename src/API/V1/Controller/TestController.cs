using Microsoft.AspNetCore.Mvc;
using API.Controllers;

namespace API.V1.Controller
{
    [ApiController]
    [Route("[controller]")]
    public abstract class TestController : APIControllerBase
    {
        [HttpGet]
        [Route("/tests")]        
        public string TestingController()
        {
            return "Hey! I'm working!";
        }
    } 
}
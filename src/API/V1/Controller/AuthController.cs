using Microsoft.AspNetCore.Mvc;
using API.Controllers;

namespace API.V1.Controller
{
    [ApiController]
    [Route("api/v1/testing")]
    public abstract class AuthController : APIControllerBase
    {
        [HttpGet]
        [Route("/tests")]        
        public string TestingController()
        {
            return "Hey! I'm working!";
        }
    } 
}
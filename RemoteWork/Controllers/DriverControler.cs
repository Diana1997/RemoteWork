using System.ComponentModel;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace RemoteWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverController : ControllerBase
    {


        public DriverController()
        {
            
        }

        [HttpGet]
        public IActionResult Test()
        {
            XmlHelper.CreateObject();
            return Ok();
        }
    }
}
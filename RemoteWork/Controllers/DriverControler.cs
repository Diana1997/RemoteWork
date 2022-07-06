using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RemoteWork.Responses;

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
        public async Task<IActionResult> LX_VDetail_OrderInteractive()
        {
            string body = XmlService.LX_VDetail_OrderInteractiveRequest();
            Stream response = HttpHelper.Post(body);
            Record record = XmlService.LX_VDetail_OrderInteractiveResponse(response);
            return Ok(record);
        }
    }
}